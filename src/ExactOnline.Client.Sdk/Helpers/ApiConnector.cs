using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Enums;
using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Interfaces;
using Newtonsoft.Json;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for doing request to REST API
	/// </summary>
	public class ApiConnector : IApiConnector
	{
		private readonly AccessTokenManagerDelegate _accessTokenDelegate;

		#region Constructor

		/// <summary>
		/// Creates new instance of ApiConnector
		/// </summary>
		/// <param name="accessTokenDelegate">Valid oAuth Access Token</param>
		public ApiConnector(AccessTokenManagerDelegate accessTokenDelegate)
		{
			if (accessTokenDelegate == null) throw new ArgumentException("accessTokenDelegate");
			_accessTokenDelegate = accessTokenDelegate;
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Read Data: Perform a GET Request on the API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="oDataQuery">oData Querystring</param>
		/// <returns>String with API Response in Json Format</returns>
		public async Task<string> DoGetRequestAsync(string endpoint, string oDataQuery)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = await CreateRequestAsync(endpoint, oDataQuery, HttpMethod.Get);
			return await GetResponseAsync(request);
		}

		/// <summary>
		/// Create Data: Perform a POST Request on the API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="postdata">String containing data of new entity in Json format</param>
		/// <returns>String with API Response in Json Format</returns>
		public async Task<string> DoPostRequestAsync(string endpoint, string postdata)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(postdata)) throw new ArgumentException("Cannot perform request with empty endpoint or postdata");

            // Add POST data to the request
            if (string.IsNullOrEmpty(postdata))
            {
                // Post request needs data
                throw new BadRequestException();
            }

            var request = await CreateRequestAsync(endpoint, null, HttpMethod.Post, postdata);
            return await GetResponseAsync(request);
		}

		/// <summary>
		/// Update data: Perform a PUT Request on API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="putData">String containing updated entity data in Json format</param>
		/// <returns>String with API Response in Json Format</returns>
		public async Task<string> DoPutRequestAsync(string endpoint, string putData)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(putData)) throw new ArgumentException("Cannot perform request with empty endpoint or putData");

            if (string.IsNullOrEmpty(putData))
            {
                // Post request needs data
                throw new BadRequestException();
            }

            var request = await CreateRequestAsync(endpoint, null, HttpMethod.Put, putData);
			return await GetResponseAsync(request);
		}

		/// <summary>
		/// Delete entity: Perform a DELETE Request on API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <returns>String with API Response in Json Format</returns>
		public async Task<string> DoDeleteRequestAsync(string endpoint)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = await CreateRequestAsync(endpoint, null, HttpMethod.Delete);
			return await GetResponseAsync(request);
		}

		/// <summary>
		/// Request without 'Accept' Header
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		public async Task<string> DoCleanRequestAsync(string uri) // Build for doing $count function
		{
            var request = await CreateRequestAsync(uri, null, HttpMethod.Get);
			return await GetResponseAsync(request, false);
		}

		public async Task<int> GetCurrentDivisionAsync(string website)
		{
			var url = website + "/api/v1/current/Me" ;
			const string oDataQuery = "$select=CurrentDivision";
			
			var request = await CreateRequestAsync(url, oDataQuery, HttpMethod.Get);
			var response = await GetResponseAsync(request);
			var jsonObject = await JsonHelper.DeserializeObjectAsync<dynamic>(response);
			
			return (int)jsonObject.d["results"][0]["CurrentDivision"].Value;
		}

		#endregion

		#region Private methods

		private async Task<HttpRequestMessage> CreateRequestAsync(string url, string oDataQuery, HttpMethod method, string contentData = "")
		{
			if (!string.IsNullOrEmpty(oDataQuery))
			{
				url += "?" + oDataQuery;
			}

            var request = new HttpRequestMessage(method, url);
            var token = await _accessTokenDelegate();
            request.Headers.Add("Authorization", "Bearer " + token);

            if(!string.IsNullOrEmpty(contentData))
                request.Content = new StringContent(contentData, Encoding.UTF8, "application/json");

			Debug.WriteLine(request.Method);
			Debug.WriteLine(url);

			return request;
		}

		private async Task<string> GetResponseAsync(HttpRequestMessage request, bool addAcceptHeader = true)
		{
			// Grab the response
			var responseValue = string.Empty;
            HttpResponseMessage response = null;

			// Get response. If this fails: Throw the correct Exception (for testability)
			try
			{
                var client = new HttpClient();
                
                if (addAcceptHeader)
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                response = await client.SendAsync(request);
                responseValue = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
			}
            catch (HttpRequestException ex)
			{
                var statusCode = response.StatusCode;
				Debug.WriteLine(ex.Message);

				switch (statusCode)
				{
					case HttpStatusCode.BadRequest:
                        throw new BadRequestException(ex.Message, ex); // 400

					case HttpStatusCode.Unauthorized: //401
                        throw new UnauthorizedException(ex.Message, ex); // 401

					case HttpStatusCode.Forbidden:
                        throw new ForbiddenException(ex.Message, ex); // 403

					case HttpStatusCode.NotFound:
                        throw new NotFoundException(ex.Message, ex); // 404

					case HttpStatusCode.InternalServerError: // 500
                        throw new InternalServerErrorException(await GetInternalServerErrorMessageAsync(response), ex);

					case HttpStatusCode.MethodNotAllowed: // 405
						throw new BadRequestException(ex.Message, ex);
				}

				throw;
			}
            catch (Exception ex)
            {
                Debug.WriteLine($"Unhandled exception occurred: {ex.ToString()}");
                throw;
            }

			Debug.WriteLine(responseValue);

			return responseValue;
		}

        private static async Task<string> GetInternalServerErrorMessageAsync(HttpResponseMessage response)
        {
            var errorMessage = response.Content.ReadAsStringAsync().Result;

            try
            {
                var deserializedObject = await JsonHelper.DeserializeObjectAsync<dynamic>(errorMessage);
                return deserializedObject["error"]["message"]["value"];
            }
            catch
            {
                return errorMessage;
            }
        }

		#endregion

	}
}