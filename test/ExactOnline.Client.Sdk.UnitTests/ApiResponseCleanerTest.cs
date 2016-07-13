using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

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
		public async Task ApiResponseCleaner_FetchJsonArray_WithCorrectValues_Succeeds()
		{
			var jsonarray = await ApiResponseCleaner.GetJsonArrayAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array.txt"));
		}

        [TestCategory("Unit Test")]
        [TestMethod]
        public async Task ApiResponseCleaner_FetchJsonArray_WithoutResults_Succeeds()
        {
            var jsonarray = await ApiResponseCleaner.GetJsonArrayAsync(JsonFileReader.GetJsonFromFile("APIResponse_Json_Array_D_NoResults.txt"));
            Assert.AreEqual(1, jsonarray.Count);
        }

        [TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public async Task ApiResponseCleaner_FetchJsonArray_WithOutDKeyValuePair_Fails()
		{
            await ApiResponseCleaner.GetJsonArrayAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutDTag.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public async Task ApiResponseCleaner_FetchJsonArray_WithOutResultsKeyValuePair_Fails()
		{
            await ApiResponseCleaner.GetJsonArrayAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutResultsTag.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public async Task ApiResponseCleanerFetchJsonArrayWithEmptyLinkedEntitiesSucceeds()
		{
			const string expectedJson = @"[{""BankAccounts"":[]}]";
            var clean = await ApiResponseCleaner.GetJsonArrayAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithEmptyLinkedEntities.txt"));
            var expected = Tools.JsonHelper.ParseArray(expectedJson);
            Assert.IsTrue(JToken.DeepEquals(expected, clean));
		}
		#endregion

		#region Test: Fetch Json Object
		[TestCategory("Unit Test")]
		[TestMethod]
		public async Task ApiResponseCleaner_FetchJsonObject_WithCorrectValues_Succeeds()
		{
			await ApiResponseCleaner.GetJsonObjectAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object.txt"));
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public async Task ApiResponseCleaner_FetchJsonObject_WithEscapeCharacter_Succeeds()
		{
			const string sampleJsonResponse = @"{ ""d"": { ""Remarks"": ""\\escape test"" }}";			

			var cleanedJson = await ApiResponseCleaner.GetJsonObjectAsync(sampleJsonResponse);

			const string expectedCleanedJson = @"{""Remarks"":""\\escape test""}";
            var expected = Tools.JsonHelper.ParseObject(expectedCleanedJson);

            Assert.IsTrue(JToken.DeepEquals(cleanedJson, expected));
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public async Task ApiResponseCleaner_FetchJsonObject_WithoutDKeyValuePair_Fails()
		{
            await ApiResponseCleaner.GetJsonObjectAsync(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object_WithoutD.txt"));
		}
		#endregion
	}

}
