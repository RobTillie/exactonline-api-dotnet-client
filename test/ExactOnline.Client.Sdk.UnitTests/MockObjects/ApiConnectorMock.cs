using System;
using ExactOnline.Client.Sdk.Interfaces;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{

	/// <summary>
	/// Simulates APIConnector class
	/// </summary>
	public class ApiConnectorMock : IApiConnector 
	{
		public String Data { get; set; }

		public async Task<string> DoCleanRequestAsync(string uri)
		{
			return "";
		}


		public int Count()
		{
			return 0;
		}

		#region IAPIConnector Members

		public async Task<string> DoGetRequestAsync(string endpoint, string parameters)
		{
			return string.Empty;
		}

		public async Task<string> DoPostRequestAsync(string endpoint, string postdata)
		{
			Data = postdata;
			return string.Empty;
		}

		public async Task<string> DoPutRequestAsync(string endpoint, string putData)
		{
			return string.Empty;
		}

		public async Task<string> DoDeleteRequestAsync(string endpoint)
		{
			return string.Empty;
		}

		public async Task<int> GetCurrentDivisionAsync(string website)
		{
			return -1;
		}

		#endregion
	}
}