using System;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for connection to a specific part of the REST API (for example: Account, Invoice, Sales, etc.)
	/// </summary>
	public class ApiConnection : IApiConnection
	{
		private readonly IApiConnector _conn;
		public IApiConnector Conn
		{
			get { return _conn; }
		}

		public string EndPoint { get; set; } // private before. Changed for $extend= functionality
		//private string _extend;

		/// <summary>
		/// Creates a new instance of APIConnection
		/// </summary>
		/// <param name="conn">Instance of APIConnector</param>
		/// <param name="endPoint">Specific endpoint of API</param>
		public ApiConnection(IApiConnector conn, string endPoint)
		{
			if (conn != null && endPoint != string.Empty)
			{
				_conn = conn;
				EndPoint = endPoint;
			}
			else
			{
				throw new ArgumentException("APIConnector and/or endPoint are required");
			}
		}

		/// <summary>
		/// Perform a GET (Read) request on the API
		/// </summary>
		/// <param name="parameters">oData Parameters</param>
		/// <returns>Json String</returns>
		public async Task<string> GetAsync(string parameters)
		{
			string response = await _conn.DoGetRequestAsync(EndPoint, parameters);
			if(response.Contains("Object moved"))
			{
				throw new Exception("Invalid Access Token");
			}
			return response;
		}

		/// <summary>
		/// Performs a GET (Read) request on the API for one specific entity
		/// </summary>
		/// <param name="keyname">Name of the field that is the unique identifier</param>
		/// <param name="guid">Global Unique Identifier of the entity</param>
		/// <param name="parameters">Parameters</param>
		/// <returns>Json String</returns>
		public async Task<string> GetEntityAsync(string keyname, string guid, string parameters)
		{
			if (guid == string.Empty || keyname == string.Empty)
			{
				throw new Exception("guid and/or Keyname are not specified");
			}

			// Create call
			string endpoint = EndPoint;
			if (keyname.Contains("ID"))
			{
				endpoint += "(guid'" + guid + "')";
			}
			else
			{
				endpoint += "(" + guid + ")";
			}
			
			string response = await _conn.DoGetRequestAsync(endpoint, parameters);
			return response;
		}

		/// <summary>
		/// Performs a POST (Create) request on the API
		/// </summary>
		/// <param name="data">Json String that representes new entity</param>
		/// <returns>Result from the API in Json Format</returns>
		public async Task<string> PostAsync(string data)
		{
			string response;
			if (data != string.Empty)
			{
				response = await _conn.DoPostRequestAsync(EndPoint, data);
			}
			else
			{
				throw new Exception("No postdata specified");
			}
			return response;
		}

		/// <summary>
		/// Performs a PUT Request (Update) on the API
		/// </summary>
		/// <param name="keyName">Name of key field</param>
		/// <param name="guid">Global Unique Identifier of the entity</param>
		/// <param name="data">Json String that represents the new state of the entity</param>
		/// <returns>True if succeeded</returns>
		public async Task<bool> PutAsync(string keyName, string guid, string data)
		{
			Boolean returnValue = false;
			if (guid != string.Empty && data != string.Empty && keyName != string.Empty)
			{
				// Create correct endpoint
				string endpoint = EndPoint;
				if(keyName.Contains("ID")) endpoint += "(guid'" + guid + "')";
				else endpoint += "(" + guid + ")";

				string response = await _conn.DoPutRequestAsync(endpoint, data);

				// Reponse is empty on success
				if (!response.Contains("error"))
				{
					returnValue = true;
				}
			}
			else
			{
				throw new Exception("No Guid, keyName or data specified");
			}
			return returnValue;
		}

		/// <summary>
		/// Performs a DELETE Request on the API
		/// </summary>
		/// <param name="keyName">Name of key field</param>
		/// <param name="guid">Global Unique Identifier of the entity</param>
		/// <returns>True if succeeded</returns>
		public async Task<bool> DeleteAsync(string keyName, string guid)
		{
			Boolean returnValue = false;
			if (guid != string.Empty && keyName != string.Empty)
			{
				// Create correct endpoint
				string endpoint = EndPoint;
				if (keyName.Contains("ID")) endpoint += "(guid'" + guid + "')";
				else endpoint += "(" + guid + ")";

				// Create endpoint and get response
				string response = await _conn.DoDeleteRequestAsync(endpoint);

				// Reponse is empty on success
				if (response == string.Empty)
				{
					returnValue = true;
				}
			}
			else
			{
				throw new Exception("No GUID specified");
			}
			return returnValue;
		}

		/// <summary>
		/// Counts the number of resources/entities
		/// </summary>
		/// <returns></returns>
		public async Task<int> CountAsync()
		{
			string response = await _conn.DoCleanRequestAsync(EndPoint + "/$count");
			return int.Parse(response);
		}
	}
}