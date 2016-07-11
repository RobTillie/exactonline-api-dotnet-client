﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    public class ServicesContainer
    {
        public Dictionary<string, string> Services = new Dictionary<string, string>();
        public ServicesContainer()
        {
            Services.Add("AcceptedQuotation", "CRM/AcceptQuotation");
            Services.Add("Account", "CRM/Accounts");
            Services.Add("AccountClass", "CRM/AccountClasses");
            Services.Add("AccountClassification", "CRM/AccountClassifications");
            Services.Add("AccountClassificationName", "CRM/AccountClassificationNames");
            Services.Add("AccountInvolvedAccount", "Accountancy/AccountInvolvedAccounts");
            Services.Add("AccountOwner", "Accountancy/AccountOwners");
            Services.Add("ActiveEmployment", "Payroll/ActiveEmployments");
            Services.Add("Address", "CRM/Addresses");
            Services.Add("AddressState", "CRM/AddressStates");
            Services.Add("AgingAmountsPayable", "Read/Financial/AgingPayablesList");
            Services.Add("AgingAmountsReceivable", "Read/Financial/AgingReceivablesList");
            Services.Add("AgingOverview", "Read/Financial/AgingOverview");
            Services.Add("Asset", "Assets/Assets");
            Services.Add("Bank", "Cashflow/Banks");
            Services.Add("BankAccount", "CRM/BankAccounts");
            Services.Add("BankEntry", "FinancialTransaction/BankEntries");
            Services.Add("BankEntryLine", "FinancialTransaction/BankEntryLines");
            Services.Add("BatchNumber", "Inventory/BatchNumbers");
            Services.Add("Budget", "Budget/Budgets");
            Services.Add("CashEntry", "FinancialTransaction/CashEntries");
            Services.Add("CashEntryLine", "FinancialTransaction/CashEntryLines");
            Services.Add("Contact", "CRM/Contacts");
            Services.Add("Costcenter", "HRM/Costcenters");
            Services.Add("CostTransaction", "Project/CostTransactions");
            Services.Add("Costunit", "HRM/Costunits");
            Services.Add("Currency", "General/Currencies");
            Services.Add("Department", "HRM/Departments");
            Services.Add("DepreciationMethod", "Assets/DepreciationMethods");
            Services.Add("DirectDebitMandate", "Cashflow/DirectDebitMandates");
            Services.Add("Division", "HRM/Divisions");
            Services.Add("Document", "Documents/Documents");
            Services.Add("DocumentAttachment", "Documents/DocumentAttachments");
            Services.Add("DocumentCategory", "Documents/DocumentCategories");
            Services.Add("DocumentFolder", "Documents/DocumentFolders");
            Services.Add("DocumentType", "Documents/DocumentTypes");
            Services.Add("DocumentTypeCategory", "Documents/DocumentTypeCategories");
            Services.Add("DocumentTypeFolder", "Documents/DocumentTypeFolders");
            Services.Add("Employee", "Payroll/Employees");
            Services.Add("Employment", "Payroll/Employments");
            Services.Add("EmploymentContract", "Payroll/EmploymentContracts");
            Services.Add("EmploymentContractFlexPhase", "Payroll/EmploymentContractFlexPhases");
            Services.Add("EmploymentEndReason", "Payroll/EmploymentEndReasons");
            Services.Add("EmploymentOrganization", "Payroll/EmploymentOrganizations");
            Services.Add("EmploymentSalary", "Payroll/EmploymentSalaries");
            Services.Add("ExchangeRate", "Financial/ExchangeRates");
            Services.Add("FinancialPeriod", "Financial/FinancialPeriods");
            Services.Add("GeneralJournalEntry", "GeneralJournalEntry/GeneralJournalEntries");
            Services.Add("GeneralJournalEntryLine", "GeneralJournalEntry/GeneralJournalEntryLines");
            Services.Add("GLAccount", "Financial/GLAccounts");
            Services.Add("GLClassification", "Financial/GLClassifications");
            Services.Add("GLScheme", "Financial/GLSchemes");
            Services.Add("GLTransactionType", "Financial/GLTransactionTypes");
            Services.Add("GoodsDelivery", "SalesOrder/GoodsDeliveries");
            Services.Add("GoodsDeliveryLine", "SalesOrder/GoodsDeliveryLines");
            Services.Add("HourCostType", "Read/Project/HourCostTypes");
            Services.Add("InvoiceSalesOrders", "SalesInvoice/InvoiceSalesOrders");
            Services.Add("InvolvedUser", "Accountancy/InvolvedUsers");
            Services.Add("InvolvedUserRole", "Accountancy/InvolvedUserRoles");
            Services.Add("Item", "Logistics/Items");
            Services.Add("ItemGroup", "Logistics/ItemGroups");
            Services.Add("ItemVersion", "Logistics/ItemVersions");
            Services.Add("ItemWarehouse", "Inventory/ItemWarehouses");
            Services.Add("JobGroup", "HRM/JobGroups");
            Services.Add("JobTitle", "HRM/JobTitles");
            Services.Add("Journal", "Financial/Journals");
            Services.Add("JournalStatus", "Read/Financial/JournalStatusList");
            Services.Add("Layout", "SalesInvoice/Layouts");
            Services.Add("Mailbox", "Mailbox/Mailboxes");
            Services.Add("MailMessage", "Mailbox/MailMessages");
            Services.Add("MailMessageAttachment", "Mailbox/MailMessageAttachments");
            Services.Add("ManufacturingTimeTransaction", "Manufacturing/TimeTransactions");
            Services.Add("OpeningBalanceAfterEntry", "OpeningBalance/CurrentYear/AfterEntry");
            Services.Add("OpeningBalancePreviousYearAfterEntry", "OpeningBalance/PreviousYear/AfterEntry");
            Services.Add("OpeningBalancePreviousYearProcessed", "OpeningBalance/PreviousYear/Processed");
            Services.Add("OpeningBalanceProcessed", "OpeningBalance/CurrentYear/Processed");
            Services.Add("Operation", "Manufacturing/Operations");
            Services.Add("OperationResource", "Manufacturing/OperationResources");
            Services.Add("Opportunity", "Read/CRM/Opportunities");
            Services.Add("OpportunityContact", "Read/CRM/OpportunityContacts");
            Services.Add("OutstandingInvoiceOverview", "Read/Financial/OutstandingInvoicesOverview");
            Services.Add("Payable", "Read/Financial/PayablesList");
            Services.Add("PaymentCondition", "Cashflow/PaymentConditions");
            Services.Add("PeriodRevenue", "Read/Financial/RevenueList");
            Services.Add("PriceList", "Sales/PriceLists");
            Services.Add("PrintedQuotation", "CRM/PrintQuotation");
            Services.Add("PrintedSalesInvoice", "SalesInvoice/PrintedSalesInvoices");
            Services.Add("PrintedSalesOrder", "SalesOrder/PrintedSalesOrders");
            Services.Add("ProductionArea", "Manufacturing/ProductionAreas");
            Services.Add("ProfitLossOverview", "Read/Financial/ProfitLossOverview");
            Services.Add("Project", "Project/Projects");
            Services.Add("ProjectBudgetType", "Project/ProjectBudgetTypes");
            Services.Add("ProjectHourBudget", "Project/ProjectHourBudgets");
            Services.Add("ProjectRestrictionEmployee", "Project/ProjectRestrictionEmployees");
            Services.Add("ProjectRestrictionItem", "Project/ProjectRestrictionItems");
            Services.Add("ProjectRestrictionRebilling", "Project/ProjectRestrictionRebillings");
            Services.Add("ProjectTerm", "Project/InvoiceTerms");
            Services.Add("PurchaseEntry", "PurchaseEntry/PurchaseEntries");
            Services.Add("PurchaseEntryLine", "PurchaseEntry/PurchaseEntryLines");
            Services.Add("PurchaseOrder", "PurchaseOrder/PurchaseOrders");
            Services.Add("PurchaseOrderLine", "PurchaseOrder/PurchaseOrderLines");
            Services.Add("Quotation", "CRM/Quotations");
            Services.Add("QuotationLine", "CRM/QuotationLines");
            Services.Add("ReasonCode", "CRM/ReasonCodes");
            Services.Add("Receivable", "Read/Financial/ReceivablesList");
            Services.Add("RecentCosts", "Read/Project/RecentCosts");
            Services.Add("RecentHours", "Read/Project/RecentHours");
            Services.Add("RejectedQuotation", "CRM/RejectQuotation");
            Services.Add("ReopenedQuotation", "CRM/ReopenQuotation");
            Services.Add("ReportingBalance", "Financial/ReportingBalance");
            Services.Add("ReviewedQuotation", "CRM/ReviewQuotation");
            Services.Add("SalesEntry", "SalesEntry/SalesEntries");
            Services.Add("SalesEntryLine", "SalesEntry/SalesEntryLines");
            Services.Add("SalesInvoice", "SalesInvoice/SalesInvoices");
            Services.Add("SalesInvoiceLine", "SalesInvoice/SalesInvoiceLines");
            Services.Add("SalesItemPrice", "Logistics/SalesItemPrices");
            Services.Add("SalesOrder", "SalesOrder/SalesOrders");
            Services.Add("SalesOrderID", "SalesInvoice/SalesOrderID");
            Services.Add("SalesOrderLine", "SalesOrder/SalesOrderLines");
            Services.Add("SalesPriceListDetail", "Sales/SalesPriceListDetails");
            Services.Add("Schedule", "HRM/Schedules");
            Services.Add("SerialNumber", "Inventory/SerialNumbers");
            Services.Add("ShippingMethod", "Sales/ShippingMethods");
            Services.Add("ShopOrder", "Manufacturing/ShopOrders");
            Services.Add("ShopOrderMaterialPlan", "Manufacturing/ShopOrderMaterialPlans");
            Services.Add("ShopOrderRoutingStepPlan", "Manufacturing/ShopOrderRoutingStepPlans");
            Services.Add("SolutionLink", "Accountancy/SolutionLinks");
            Services.Add("StockBatchNumber", "Inventory/StockBatchNumbers");
            Services.Add("StockCount", "Inventory/StockCounts");
            Services.Add("StockCountLine", "Inventory/StockCountLines");
            Services.Add("StockSerialNumber", "Inventory/StockSerialNumbers");
            Services.Add("StorageLocation", "Inventory/StorageLocations");
            Services.Add("Subscription", "Subscription/Subscriptions");
            Services.Add("SubscriptionChargeType", "Subscription/SubscriptionLineTypes");
            Services.Add("SubscriptionLine", "Subscription/SubscriptionLines");
            Services.Add("SubscriptionReasonCode", "Subscription/SubscriptionReasonCodes");
            Services.Add("SubscriptionRestrictionEmployee", "Subscription/SubscriptionRestrictionEmployees");
            Services.Add("SubscriptionRestrictionItem", "Subscription/SubscriptionRestrictionItems");
            Services.Add("SubscriptionType", "Subscription/SubscriptionTypes");
            Services.Add("TaxComponentRate", "VAT/TaxComponentRates");
            Services.Add("TaxDocument", "Read/Financial/Returns");
            Services.Add("TaxEmploymentEndFlexCode", "Payroll/TaxEmploymentEndFlexCodes");
            Services.Add("TaxSchedule", "VAT/TaxSchedules");
            Services.Add("TaxScheduleComponent", "VAT/TaxScheduleComponents");
            Services.Add("TimeAndBillingAccount", "Read/Project/TimeAndBillingEntryAccounts");
            Services.Add("TimeAndBillingAccountDetails", "Read/Project/TimeAndBillingAccountDetails");
            Services.Add("TimeAndBillingActivitiesAndExpenses", "Read/Project/TimeAndBillingActivitiesAndExpenses");
            Services.Add("TimeAndBillingItemDetails", "Read/Project/TimeAndBillingItemDetails");
            Services.Add("TimeAndBillingProject", "Read/Project/TimeAndBillingEntryProjects");
            Services.Add("TimeAndBillingProjectDetails", "Read/Project/TimeAndBillingProjectDetails");
            Services.Add("TimeAndBillingRecentAccount", "Read/Project/TimeAndBillingEntryRecentAccounts");
            Services.Add("TimeAndBillingRecentActivitiesAndExpenses", "Read/Project/TimeAndBillingEntryRecentActivitiesAndExpenses");
            Services.Add("TimeAndBillingRecentHourCostType", "Read/Project/TimeAndBillingEntryRecentHourCostTypes");
            Services.Add("TimeAndBillingRecentProject", "Read/Project/TimeAndBillingEntryRecentProjects");
            Services.Add("TimeCorrection", "Project/TimeCorrections");
            Services.Add("TimeTransaction", "Project/TimeTransactions");
            Services.Add("Transaction", "FinancialTransaction/Transactions");
            Services.Add("TransactionLine", "FinancialTransaction/TransactionLines");
            Services.Add("Unit", "Logistics/Units");
            Services.Add("User", "Users/Users");
            Services.Add("UserRole", "Users/UserRoles");
            Services.Add("UserRolePerDivision", "Users/UserRolesPerDivision");
            Services.Add("VATCode", "VAT/VATCodes");
            Services.Add("VatPercentage", "VAT/VatPercentages");
            Services.Add("Warehouse", "Inventory/Warehouses");
            Services.Add("Workcenter", "Manufacturing/Workcenters");
        }
    }
}
