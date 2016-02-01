using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace ExactOnline.Client.Sdk.UnitTests
{
	[TestClass]
	public class ApiResponseCleanerTest
	{

		#region Additional Test Attributes

		public TestContext TestContext { get; set; }

		#endregion

		#region Test: Fetch Json Array
		[TestCategory("Unit Test")]
		[TestMethod]
		public void ApiResponseCleaner_FetchJsonArray_WithCorrectValues_Succeeds()
		{
			var jsonarray = ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array.txt"));
		}

        [TestCategory("Unit Test")]
        [TestMethod]
        public void ApiResponseCleaner_FetchJsonArray_WithoutResults_Succeeds()
        {
            var jsonarray = ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("APIResponse_Json_Array_D_NoResults.txt"));
            Assert.AreEqual(1, jsonarray.Count);
        }

        [TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void ApiResponseCleaner_FetchJsonArray_WithOutDKeyValuePair_Fails()
		{
			ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutDTag.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void ApiResponseCleaner_FetchJsonArray_WithOutResultsKeyValuePair_Fails()
		{
			ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutResultsTag.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void ApiResponseCleanerFetchJsonArrayWithEmptyLinkedEntitiesSucceeds()
		{
			const string expectedJson = @"[{""BankAccounts"":[]}]";
            var clean = ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithEmptyLinkedEntities.txt"));
            var expected = JsonHelper.ParseArray(expectedJson);
            Assert.IsTrue(JToken.DeepEquals(expected, clean));
		}
		#endregion

		#region Test: Fetch Json Object
		[TestCategory("Unit Test")]
		[TestMethod]
		public void ApiResponseCleaner_FetchJsonObject_WithCorrectValues_Succeeds()
		{
			ApiResponseCleaner.GetJsonObject(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void ApiResponseCleaner_FetchJsonObject_WithEscapeCharacter_Succeeds()
		{
			const string sampleJsonResponse = @"{ ""d"": { ""Remarks"": ""\\escape test"" }}";			

			var cleanedJson = ApiResponseCleaner.GetJsonObject(sampleJsonResponse);

			const string expectedCleanedJson = @"{""Remarks"":""\\escape test""}";
            var expected = JsonHelper.ParseObject(expectedCleanedJson);

            Assert.IsTrue(JToken.DeepEquals(cleanedJson, expected));
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void ApiResponseCleaner_FetchJsonObject_WithoutDKeyValuePair_Fails()
		{
			ApiResponseCleaner.GetJsonObject(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object_WithoutD.txt"));
		}
		#endregion
	}

}
