﻿using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.MockObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{
	[TestClass]
	public class ExactOnlineQueryTest
	{
		Controller<Account> _acccountController;
		ControllerMock<Account> _controllerMock;
		ApiConnectionMock _conn;

		[TestInitialize]
		public void Setup()
		{
			_conn = new ApiConnectionMock();
			_controllerMock = new ControllerMock<Account>();
			_acccountController = new Controller<Account>(_conn);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_TestAnd_WithCorrectString_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.Where("Name+eq+'Test Testname'")
				.And("Code+eq+'123'")
				.And("Code+eq+'456'")
				.GetAsync();

			Assert.AreEqual("$filter=Name+eq+'Test Testname'&Code+eq+'123'&Code+eq+'456'&$select=Code,Name", _controllerMock.ODataQuery);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQuery_TestAnd_WithNoWhereClause_Fails()
		{
			_controllerMock = new ControllerMock<Account>();
			await new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.And("Code+eq+'123'")
				.GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQuery_TestAnd_WithEmptyString_Fails()
		{
			await new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.Where("Name+eq+'Test Testname'")
				.And(string.Empty)
				.GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Delete_WithEntity_Succeeds()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock);
			Assert.IsTrue(await query.DeleteAsync(new Account()));
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQueryDelete_WithNullEntity_Fails()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock);
			Assert.IsTrue(await query.DeleteAsync(null));
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQueryFor_WithExistingEntity_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock).Select("Code").GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQueryFor_WithEmptyController_Fails()
		{
			await new ExactOnlineQuery<Account>(null).GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(Exception))]
		public async Task ExactOnlineQuery_Get_WithoutSelect_Fails()
		{
            await new ExactOnlineQuery<Account>(_controllerMock).GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Get_WithSelect_Succeeds()
		{
            await new ExactOnlineQuery<Account>(_controllerMock).Select("Code").GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_GetEntity_WithIdentifier_Succeeds()
		{
            await new ExactOnlineQuery<Account>(_acccountController).GetEntityAsync("asdfasdfasdfadf");
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQuery_GetEntity_WithoutIdentifier_Fails()
		{
            await new ExactOnlineQuery<Account>(_acccountController).GetEntityAsync(string.Empty);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Insert_WithObject_Succeeds()
		{
			var newAccount = new Account();
			await new ExactOnlineQuery<Account>(_controllerMock).InsertAsync(newAccount);
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Insert_WithNullObject_Fails()
		{
			Account newAccount = null;
			await new ExactOnlineQuery<Account>(_controllerMock).InsertAsync(newAccount);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQuery_Update_WithNullObject_Fails()
		{
			await new ExactOnlineQuery<Account>(_controllerMock).UpdateAsync(null);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Update_WithObject_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock).UpdateAsync(new Account());
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Where_WithString_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock)
			.Select(new[] { "Code", "Name" })
			.Where("Name+eq+'Test Testname'")
			.GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task ExactOnlineQuery_Where_WithEmptyString_Fails()
		{
			await new ExactOnlineQuery<Account>(_controllerMock)
			.Where(string.Empty)
			.GetAsync();
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_SingleSelect_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock).Select("Description").GetAsync();
			const string expected = "$select=Description";
			var query = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, query);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_MultipleSelect_Succeeds()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock).Select(new[] {"Description", "Name"});
			var list = await query.GetAsync();

			const string expected = "$select=Description,Name";
			var result = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_Top_Succeeds()
		{
			await new ExactOnlineQuery<Account>(_controllerMock).Top(10).Select(new[] { "Code", "Name" }).GetAsync();
			const string expected = "$select=Code,Name&$top=10";
			var query = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, query);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task ExactOnlineQuery_WithAllOptions_Succeeds()
		{
			var query = await new ExactOnlineQuery<Account>(_controllerMock)
				.Where("Name+eq+'Test'")
				.And("Name+eq+'Test2'")
				.Select(new[] { "Description", "Name" })
				.Expand("BankAccounts")
				.Skip(10)
				.Top(10).GetAsync();


			const string expected = "$filter=Name+eq+'Test'&Name+eq+'Test2'&$select=Description,Name&$skip=10&$expand=BankAccounts&$top=10";
			var data = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, data);
		}
	}
}
