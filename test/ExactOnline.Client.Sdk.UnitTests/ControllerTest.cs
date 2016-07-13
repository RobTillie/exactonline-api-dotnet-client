using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using ExactOnline.Client.Sdk.UnitTests.MockObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{

	[TestClass()]
	public class ControllerTest
	{
		IApiConnection _mockConnection;

		[TestInitialize]
		public void Setup()
		{
			_mockConnection = new ApiConnectionMock();
        }

		[TestMethod]
		[TestCategory("Unit Test")]
		public void Controller_Constructor_With_CorrectTypeAndConnection_Succeeds()
		{
			var accountController = new Controller<Account>(_mockConnection);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(Exception))]
		public void Controller_Constructor_WithoutValidType_Fails()
		{
			var accountController = new Controller<object>(_mockConnection);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void Controller_Create_WithoutValidTypeAndConnection_Fails()
		{
			var accountController = new Controller<object>(null);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void Controller_GetIdentifierValueForCompoundKey_Fails()
		{
			// JournalStatus has a compound key
			var journalStatusController = new Controller<JournalStatus>(_mockConnection);
			var journalStatus = new JournalStatus();
			var exceptionThrown = false;
			var exceptionMessage = "";

			try
			{
				journalStatusController.GetIdentifierValue(journalStatus);
			}
			catch (Exception ex)
			{
				exceptionThrown = true;
				exceptionMessage = ex.Message;
			}

			Assert.IsTrue(exceptionThrown);
			Assert.AreEqual("Currently the SDK doesn't support entities with a compound key.", exceptionMessage);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task Controller_Delete_WithEntity_Succeeds()
		{
			var accountController = new Controller<Account>(_mockConnection);
			Account testAccount = await accountController.GetEntityAsync("dummyGUID", string.Empty);

			// Delete Entity and Test if Entity still exists
			Assert.IsTrue(await accountController.DeleteAsync(testAccount));
			Assert.IsFalse(accountController.IsManagedEntity(testAccount));
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task Controller_Delete_WithoutEntity_Fails()
		{
			var accountController = new Controller<Account>(_mockConnection);
			await accountController.DeleteAsync(null);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task Controller_Get_Succeeds()
		{
			var accountController = new Controller<Account>(_mockConnection);
			await accountController.GetAsync(string.Empty);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task Controller_GetMultipleTimes_Succeeds()
		{
			var accountController = new Controller<Account>(_mockConnection);

			// Get accounts again to test for double entitycontrollers
			var accounts = await accountController.GetAsync(string.Empty);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public async Task Controller_Update_WithoutEntity_Fails()
		{
			var accountController = new Controller<Account>(_mockConnection);
			Assert.IsFalse(await accountController.UpdateAsync(null));
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task Controller_Update_WithEntity_Succeeds()
		{
			var accountController = new Controller<Account>(_mockConnection);
			Account testAccount = await accountController.GetEntityAsync("dummyGUID", string.Empty);
			Assert.IsTrue(await accountController.UpdateAsync(testAccount));
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public async Task Controller_Test_ManagedEntities_WithLinkedEntities_Succeeds()
		{
			// Test if controller registrates linked entities
			IApiConnector conn = new ApiConnectorControllerMock();
			var controllerList = new ControllerList(conn, string.Empty);

			var salesinvoicecontroller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
			var invoicelines = (Controller<SalesInvoiceLine>)controllerList.GetController<SalesInvoiceLine>();
			salesinvoicecontroller.GetManagerForEntity = controllerList.GetEntityManager;

			// Verify if sales invoice lines are registrated entities
			var invoices = await salesinvoicecontroller.GetAsync("");
            var invoice = invoices[0];
            SalesInvoiceLine line = ((List<SalesInvoiceLine>)invoice.SalesInvoiceLines)[0];
			Assert.IsTrue(invoicelines.IsManagedEntity(line), "SalesInvoiceLine isn't a managed entity");
		}
	}
}
