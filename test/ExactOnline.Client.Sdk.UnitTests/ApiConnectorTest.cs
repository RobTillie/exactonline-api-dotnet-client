using System;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{
	[TestClass]
	public class ApiConnectorTest
	{
		IApiConnector _connector;

		private static async Task<string> GetAccessToken()
		{
			return "accessToken";
		}

		[TestInitialize]
		public void Setup()
		{
			_connector = new ApiConnector(GetAccessToken);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ApiConnector_Constructor_WithoutDelegate_Fails()
		{
			var connector = new ApiConnector(null);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void ApiConnector_Constructor_WithDelegate_Succeeds()
		{
			var connector = new ApiConnector(GetAccessToken);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ApiConnector_DoDeleteRequest_With_EmptyValues_Fails()
		{
			await _connector.DoDeleteRequestAsync(string.Empty);
		}




	}
}
