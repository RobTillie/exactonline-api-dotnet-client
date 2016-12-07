using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// Last generated on 2016-07-06 07:30:03Z

namespace ExactOnline.Client.Models
{

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class AcceptedQuotation
    {
        ///<![CDATA[0 = No action, 1 = create sales order, 2 = create sales invoice, 3 = create project.]]>
        public Int32 Action { get; set; }
        ///<![CDATA[Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.]]>
        public bool? CreateProjectWBS { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the acception of the quotation.]]>
        public string ErrorMessage { get; set; }
        ///<![CDATA[The journal in which the sales invoice will be booked. Only needed for Action = 2.]]>
        public Int32 InvoiceJournal { get; set; }
        ///<![CDATA[The budget type of the project that will be created.]]>
        public Int32 ProjectBudgetType { get; set; }
        ///<![CDATA[The code of the project that will be created.]]>
        public string ProjectCode { get; set; }
        ///<![CDATA[The description of the project that will be created.]]>
        public string ProjectDescription { get; set; }
        ///<![CDATA[The invoicing date of the project. Only needed for ProjectInvoicingAction = 2.]]>
        public DateTime ProjectInvoiceDate { get; set; }
        ///<![CDATA[The project invoicing action. 1 = Create invoice terms, 2 = As quoted.]]>
        public Int32 ProjectInvoicingAction { get; set; }
        ///<![CDATA[The prepaid type. Only needed for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.]]>
        public Int32 ProjectPrepaindTypes { get; set; }
        ///<![CDATA[PriceAgreement.]]>
        public double? ProjectPriceAgreement { get; set; }
        ///<![CDATA[Contains information if the project was successfully created.]]>
        public string ProjectSuccess { get; set; }
        ///<![CDATA[The type of the project that will be created. 2 = Fixed price, 3 = Time and Material, 4 = Non billable, 5 = Prepaid.]]>
        public Int32 ProjectType { get; set; }
        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Reason why the quotation was accepted.]]>
        public Guid ReasonCode { get; set; }
        ///<![CDATA[Contains information if the sales invoice was successfully created.]]>
        public string SalesInvoiceSuccess { get; set; }
        ///<![CDATA[Contains information if the sales order was successfully created.]]>
        public string SalesOrderSuccess { get; set; }
        ///<![CDATA[Contains information if the quotation was successfully accepted.]]>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Account
    {
        ///<![CDATA[Reference to the accountant of the customer. Conditions: The referred accountant must have value > 0 in the field IsAccountant]]>
        public Guid Accountant { get; set; }
        ///<![CDATA[ID of the account manager]]>
        public Guid AccountManager { get; set; }
        ///<![CDATA[Name of the account manager]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountManagerFullName { get; set; }
        ///<![CDATA[Number of the account manager  ]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AccountManagerHID { get; set; }
        ///<![CDATA[Reference to Activity sector of the account]]>
        public Guid ActivitySector { get; set; }
        ///<![CDATA[Reference to Activity sub-sector of the account]]>
        public Guid ActivitySubSector { get; set; }
        ///<![CDATA[Visit address first line]]>
        public string AddressLine1 { get; set; }
        ///<![CDATA[Visit address second line]]>
        public string AddressLine2 { get; set; }
        ///<![CDATA[Visit address third line]]>
        public string AddressLine3 { get; set; }
        ///<![CDATA[Collection of Bank accounts]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<BankAccount> BankAccounts { get; set; }
        ///<![CDATA[Indicates if the account is blocked]]>
        public bool? Blocked { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid BRIN { get; set; }
        ///<![CDATA[Reference to the business type of the account]]>
        public Guid BusinessType { get; set; }
        ///<![CDATA[Indicates the default for the possibility to drop ship when an item is linked to a supplier]]>
        public bool? CanDropShip { get; set; }
        ///<![CDATA[Chamber of commerce number]]>
        public string ChamberOfCommerce { get; set; }
        ///<![CDATA[Visit address City]]>
        public string City { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Classification { get; set; }
        ///<![CDATA[Account classification 1]]>
        public Guid Classification1 { get; set; }
        ///<![CDATA[Account classification 2]]>
        public Guid Classification2 { get; set; }
        ///<![CDATA[Account classification 3]]>
        public Guid Classification3 { get; set; }
        ///<![CDATA[Account classification 4]]>
        public Guid Classification4 { get; set; }
        ///<![CDATA[Account classification 5]]>
        public Guid Classification5 { get; set; }
        ///<![CDATA[Account classification 6]]>
        public Guid Classification6 { get; set; }
        ///<![CDATA[Account classification 7]]>
        public Guid Classification7 { get; set; }
        ///<![CDATA[Account classification 8]]>
        public Guid Classification8 { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        ///<![CDATA[Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces]]>
        public string Code { get; set; }
        ///<![CDATA[Code under which your own company is known at the account]]>
        public string CodeAtSupplier { get; set; }
        ///<![CDATA[Reference to Company size of the account]]>
        public Guid CompanySize { get; set; }
        ///<![CDATA[Consolidation scenario (Time & Billing). Values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project. Item means in this case including Unit and Price, these also have to be the same to consolidate]]>
        public byte? ConsolidationScenario { get; set; }
        ///<![CDATA[Date of the latest control of account data with external web service]]>
        public DateTime ControlledDate { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Costcenter { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte CostPaid { get; set; }
        ///<![CDATA[Country code]]>
        public string Country { get; set; }
        ///<![CDATA[Country name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit]]>
        public double? CreditLinePurchase { get; set; }
        ///<![CDATA[Maximum amount of credit for sales. If no value has been defined, there is no credit limit]]>
        public double? CreditLineSales { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Currency { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime CustomerSince { get; set; }
        ///<![CDATA[DATEV creditor code for Germany legislation]]>
        public string DatevCreditorCode { get; set; }
        ///<![CDATA[DATEV debtor code for Germany legislation]]>
        public string DatevDebtorCode { get; set; }
        ///<![CDATA[Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055]]>
        public double? DiscountPurchase { get; set; }
        ///<![CDATA[Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055]]>
        public double? DiscountSales { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Document { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DunsNumber { get; set; }
        ///<![CDATA[E-Mail address of the account]]>
        public string Email { get; set; }
        ///<![CDATA[Determines in combination with the start date if the account is active. If the current date is > end date the account is inactive]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[RegistrationDate]]>
        public DateTime EstablishedDate { get; set; }
        ///<![CDATA[Fax number]]>
        public string Fax { get; set; }
        ///<![CDATA[Default (corporate) GL offset account for purchase (cost)]]>
        public Guid GLAccountPurchase { get; set; }
        ///<![CDATA[Default (corporate) GL offset account for sales (revenue)]]>
        public Guid GLAccountSales { get; set; }
        ///<![CDATA[Default GL account for Accounts Payable]]>
        public Guid GLAP { get; set; }
        ///<![CDATA[Default GL account for Accounts Receivable]]>
        public Guid GLAR { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Suppressed warning message when there is duplication on the DATEV code]]>
        public bool IgnoreDatevWarningMessage { get; set; }
        ///<![CDATA[Intrastat Area]]>
        public string IntraStatArea { get; set; }
        ///<![CDATA[Intrastat delivery method]]>
        public string IntraStatDeliveryTerm { get; set; }
        ///<![CDATA[System for Intrastat]]>
        public string IntraStatSystem { get; set; }
        ///<![CDATA[Transaction type A for Intrastat]]>
        public string IntraStatTransactionA { get; set; }
        ///<![CDATA[Transaction type B for Intrastat]]>
        public string IntraStatTransactionB { get; set; }
        ///<![CDATA[Transport method for Intrastat]]>
        public string IntraStatTransportMethod { get; set; }
        ///<![CDATA[ID of account to be invoiced instead of this account]]>
        public Guid InvoiceAccount { get; set; }
        ///<![CDATA[Code of InvoiceAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }
        ///<![CDATA[Name of InvoiceAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }
        ///<![CDATA[Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed]]>
        public Int32 InvoiceAttachmentType { get; set; }
        ///<![CDATA[Method of sending for sales invoices. Values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)]]>
        public Int32 InvoicingMethod { get; set; }
        ///<![CDATA[Indicates whether the account is an accountant. Values: 0 = No accountant, 1 = True, but accountant doesn't want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants]]>
        public byte IsAccountant { get; set; }
        ///<![CDATA[Indicates whether the accounti is an agency]]>
        public byte IsAgency { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsBank { get; set; }
        ///<![CDATA[Indicates whether the account is a competitor]]>
        public byte IsCompetitor { get; set; }
        ///<![CDATA[Indicates whether a customer is eligible for extra duty]]>
        public bool? IsExtraDuty { get; set; }
        ///<![CDATA[Indicates if the account is excluded from mailing marketing information]]>
        public byte IsMailing { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMember { get; set; }
        ///<![CDATA[Indicates whether the account is a pilot account]]>
        public bool? IsPilot { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsPurchase { get; set; }
        ///<![CDATA[Indicates whether the account is a reseller]]>
        public bool? IsReseller { get; set; }
        ///<![CDATA[Indicates whether the account is allowed for sales]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsSales { get; set; }
        ///<![CDATA[Indicates whether the account is a supplier]]>
        public bool? IsSupplier { get; set; }
        ///<![CDATA[Language code]]>
        public string Language { get; set; }
        ///<![CDATA[Language description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LanguageDescription { get; set; }
        ///<![CDATA[Latitude (used by Google maps)]]>
        public double? Latitude { get; set; }
        ///<![CDATA[Reference to Lead source of an account]]>
        public Guid LeadSource { get; set; }
        ///<![CDATA[Bytes of the logo image]]>
        public byte[] Logo { get; set; }
        ///<![CDATA[The file name (without path, but with extension) of the image]]>
        public string LogoFileName { get; set; }
        ///<![CDATA[Thumbnail url of the logo]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoThumbnailUrl { get; set; }
        ///<![CDATA[Url to retrieve the logo]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoUrl { get; set; }
        ///<![CDATA[Longitude (used by Google maps)]]>
        public double? Longitude { get; set; }
        ///<![CDATA[Reference to main contact person]]>
        public Guid MainContact { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Account name]]>
        public string Name { get; set; }
        ///<![CDATA[ID of the parent account]]>
        public Guid Parent { get; set; }
        ///<![CDATA[Indicates the loan repayment plan for UK legislation]]>
        public string PayAsYouEarn { get; set; }
        ///<![CDATA[Code of default payment condition for purchase]]>
        public string PaymentConditionPurchase { get; set; }
        ///<![CDATA[Description of PaymentConditionPurchase]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionPurchaseDescription { get; set; }
        ///<![CDATA[Code of default payment condition for sales]]>
        public string PaymentConditionSales { get; set; }
        ///<![CDATA[Description of PaymentConditionSales]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionSalesDescription { get; set; }
        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone number extention]]>
        public string PhoneExtension { get; set; }
        ///<![CDATA[Visit address postcode]]>
        public string Postcode { get; set; }
        ///<![CDATA[Default sales price list for account]]>
        public Guid PriceList { get; set; }
        ///<![CDATA[Currency of purchase]]>
        public string PurchaseCurrency { get; set; }
        ///<![CDATA[Description of PurchaseCurrency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseCurrencyDescription { get; set; }
        ///<![CDATA[Indicates number of days required to receive a purchase. Acts as a default]]>
        public Int32 PurchaseLeadDays { get; set; }
        ///<![CDATA[Default VAT code used for purchase entries]]>
        public string PurchaseVATCode { get; set; }
        ///<![CDATA[Description of PurchaseVATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseVATCodeDescription { get; set; }
        ///<![CDATA[Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax]]>
        public bool? RecepientOfCommissions { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[ID of the reseller account. Conditions: the target account must have the property IsReseller turned on]]>
        public Guid Reseller { get; set; }
        ///<![CDATA[Code of Reseller]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerCode { get; set; }
        ///<![CDATA[Name of Reseller]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerName { get; set; }
        ///<![CDATA[Fiscal number for NL legislation]]>
        public string RSIN { get; set; }
        ///<![CDATA[Currency of Sales used for Time & Billing]]>
        public string SalesCurrency { get; set; }
        ///<![CDATA[Description of SalesCurrency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesCurrencyDescription { get; set; }
        ///<![CDATA[Default tax schedule when creating sales orders or sales invoices]]>
        public Guid SalesTaxSchedule { get; set; }
        ///<![CDATA[Code of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleCode { get; set; }
        ///<![CDATA[Description of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleDescription { get; set; }
        ///<![CDATA[Default VAT code for a sales entry]]>
        public string SalesVATCode { get; set; }
        ///<![CDATA[Description of SalesVATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVATCodeDescription { get; set; }
        ///<![CDATA[Search code]]>
        public string SearchCode { get; set; }
        ///<![CDATA[Security level (0 - 100)]]>
        public Int32 SecurityLevel { get; set; }
        ///<![CDATA[Separate invoice per project (Time & Billing)]]>
        public byte SeparateInvPerProject { get; set; }
        ///<![CDATA[Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line]]>
        public byte SeparateInvPerSubscription { get; set; }
        ///<![CDATA[Indicates the number of days it takes to send goods to the customer. Acts as a default]]>
        public Int32 ShippingLeadDays { get; set; }
        ///<![CDATA[Default shipping method]]>
        public Guid ShippingMethod { get; set; }
        ///<![CDATA[Indicates in combination with the end date if the account is active]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[State/Province code]]>
        public string State { get; set; }
        ///<![CDATA[Name of State]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StateName { get; set; }
        ///<![CDATA[If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer]]>
        public string Status { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime StatusSince { get; set; }
        ///<![CDATA[Trade name can be registered and shown with the client (for all legislations)]]>
        public string TradeName { get; set; }
        ///<![CDATA[Account type: Values: A = Relation, D = Division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }
        ///<![CDATA[Unique taxpayer reference for UK legislation]]>
        public string UniqueTaxpayerReference { get; set; }
        ///<![CDATA[Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium]]>
        public string VATLiability { get; set; }
        ///<![CDATA[The number under which the account is known at the Value Added Tax collection agency]]>
        public string VATNumber { get; set; }
        ///<![CDATA[Website of the account]]>
        public string Website { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClass
    {
        ///<![CDATA[Classification code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Default credit management scenario to be used for new payment terms]]>
        public Guid CreditManagementScenario { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassification
    {
        ///<![CDATA[Reference to Account classification name]]>
        public Guid AccountClassificationName { get; set; }
        ///<![CDATA[Description of AccountClassificationName]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountClassificationNameDescription { get; set; }
        ///<![CDATA[Account classification code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassificationName
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Sequence number]]>
        public Int32 SequenceNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountInvolvedAccount
    {
        ///<![CDATA[ID of account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Name of account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[ID of involved account]]>
        public Guid InvolvedAccount { get; set; }
        ///<![CDATA[Description of relation type]]>
        public string InvolvedAccountRelationTypeDescription { get; set; }
        ///<![CDATA[TermId of description of relation type]]>
        public Int32 InvolvedAccountRelationTypeDescriptionTermId { get; set; }
        ///<![CDATA[ID of relation type]]>
        public Int16 InvolvedAccountRelationTypeId { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Use to record details of important information]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountOwner
    {
        ///<![CDATA[ID of the account that is owned]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of the account that is owned]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of the account that is owned]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[ID of the account who owns specified account]]>
        public Guid OwnerAccount { get; set; }
        ///<![CDATA[Code of the account who owns specified account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountCode { get; set; }
        ///<![CDATA[Name of the account who owns specified account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountName { get; set; }
        ///<![CDATA[Percentage of shares that is owned. 1 is 100%, 0.5 is 50%]]>
        public double? Shares { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ActiveEmployment
    {
        ///<![CDATA[The average number of contract days that an employee works per week]]>
        public double? AverageDaysPerWeek { get; set; }
        ///<![CDATA[The average number of contract hours that an employee works per week]]>
        public double? AverageHoursPerWeek { get; set; }
        ///<![CDATA[Employment contract ID]]>
        public Guid Contract { get; set; }
        ///<![CDATA[Document ID of the employment contract]]>
        public Guid ContractDocument { get; set; }
        ///<![CDATA[End date of employment contract]]>
        public DateTime ContractEndDate { get; set; }
        ///<![CDATA[Employment probation end date]]>
        public DateTime ContractProbationEndDate { get; set; }
        ///<![CDATA[Employment probation period]]>
        public Int32 ContractProbationPeriod { get; set; }
        ///<![CDATA[Start date of employment contract]]>
        public DateTime ContractStartDate { get; set; }
        ///<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
        public Int32 ContractType { get; set; }
        ///<![CDATA[Description of employment contract type]]>
        public string ContractTypeDescription { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Department of employee]]>
        public Guid Department { get; set; }
        ///<![CDATA[Department code of employee]]>
        public string DepartmentCode { get; set; }
        ///<![CDATA[Description of department]]>
        public string DepartmentDescription { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Employee ID]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Numeric number of Employee]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Organization of employment]]>
        public Guid EmploymentOrganization { get; set; }
        ///<![CDATA[End date of employment]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Hourly wage]]>
        public double? HourlyWage { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Internal rate for time & billing or professional service user]]>
        public double? InternalRate { get; set; }
        ///<![CDATA[Job title of employee]]>
        public Guid Jobtitle { get; set; }
        ///<![CDATA[Description of job title]]>
        public string JobtitleDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[ID of employment ended]]>
        public Int32 ReasonEnd { get; set; }
        ///<![CDATA[Reason of end of employment]]>
        public string ReasonEndDescription { get; set; }
        ///<![CDATA[Reason of ended flexible employment]]>
        public Int32 ReasonEndFlex { get; set; }
        ///<![CDATA[Other reason for end of employment]]>
        public string ReasonEndFlexDescription { get; set; }
        ///<![CDATA[Employment salary]]>
        public Guid Salary { get; set; }
        ///<![CDATA[Work schedule]]>
        public Guid Schedule { get; set; }
        ///<![CDATA[Average hours per week in a schedule.]]>
        public double? ScheduleAverageHours { get; set; }
        ///<![CDATA[Work schedule code]]>
        public string ScheduleCode { get; set; }
        ///<![CDATA[Number of days of work per week]]>
        public double? ScheduleDays { get; set; }
        ///<![CDATA[Description of work schedule]]>
        public string ScheduleDescription { get; set; }
        ///<![CDATA[Number of work hours per week.]]>
        public double? ScheduleHours { get; set; }
        ///<![CDATA[Start date of employment]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
        public DateTime StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Address
    {
        ///<![CDATA[Account linked to the address]]>
        public Guid Account { get; set; }
        ///<![CDATA[Indicates if the account is a supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        ///<![CDATA[Name of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[First address line]]>
        public string AddressLine1 { get; set; }
        ///<![CDATA[Second address line]]>
        public string AddressLine2 { get; set; }
        ///<![CDATA[Third address line]]>
        public string AddressLine3 { get; set; }
        ///<![CDATA[City]]>
        public string City { get; set; }
        ///<![CDATA[Contact linked to Address]]>
        public Guid Contact { get; set; }
        ///<![CDATA[Contact name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactName { get; set; }
        ///<![CDATA[Country code]]>
        public string Country { get; set; }
        ///<![CDATA[Country name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Fax number]]>
        public string Fax { get; set; }
        ///<![CDATA[Free boolean field 1]]>
        public bool? FreeBoolField_01 { get; set; }
        ///<![CDATA[Free boolean field 2]]>
        public bool? FreeBoolField_02 { get; set; }
        ///<![CDATA[Free boolean field 3]]>
        public bool? FreeBoolField_03 { get; set; }
        ///<![CDATA[Free boolean field 4]]>
        public bool? FreeBoolField_04 { get; set; }
        ///<![CDATA[Free boolean field 5]]>
        public bool? FreeBoolField_05 { get; set; }
        ///<![CDATA[Free date field 1]]>
        public DateTime FreeDateField_01 { get; set; }
        ///<![CDATA[Free date field 2]]>
        public DateTime FreeDateField_02 { get; set; }
        ///<![CDATA[Free date field 3]]>
        public DateTime FreeDateField_03 { get; set; }
        ///<![CDATA[Free date field 4]]>
        public DateTime FreeDateField_04 { get; set; }
        ///<![CDATA[Free date field 5]]>
        public DateTime FreeDateField_05 { get; set; }
        ///<![CDATA[Free number field 1]]>
        public double? FreeNumberField_01 { get; set; }
        ///<![CDATA[Free number field 2]]>
        public double? FreeNumberField_02 { get; set; }
        ///<![CDATA[Free number field 3]]>
        public double? FreeNumberField_03 { get; set; }
        ///<![CDATA[Free number field 4]]>
        public double? FreeNumberField_04 { get; set; }
        ///<![CDATA[Free number field 5]]>
        public double? FreeNumberField_05 { get; set; }
        ///<![CDATA[Free text field 1]]>
        public string FreeTextField_01 { get; set; }
        ///<![CDATA[Free text field 2]]>
        public string FreeTextField_02 { get; set; }
        ///<![CDATA[Free text field 3]]>
        public string FreeTextField_03 { get; set; }
        ///<![CDATA[Free text field 4]]>
        public string FreeTextField_04 { get; set; }
        ///<![CDATA[Free text field 5]]>
        public string FreeTextField_05 { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Mailbox]]>
        public string Mailbox { get; set; }
        ///<![CDATA[Indicates if the address is the main address for this type]]>
        public bool? Main { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office]]>
        public string NicNumber { get; set; }
        ///<![CDATA[Notes for an address]]>
        public string Notes { get; set; }
        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone extension]]>
        public string PhoneExtension { get; set; }
        ///<![CDATA[Postcode]]>
        public string Postcode { get; set; }
        ///<![CDATA[State]]>
        public string State { get; set; }
        ///<![CDATA[Name of the State]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StateDescription { get; set; }
        ///<![CDATA[The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4]]>
        public Int16 Type { get; set; }
        ///<![CDATA[The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Code of the warehoude]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of the warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AddressState
    {
        ///<![CDATA[Country code]]>
        public string Country { get; set; }
        ///<![CDATA[Description of state prefixed with the code]]>
        public string DisplayValue { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Latitude]]>
        public double? Latitude { get; set; }
        ///<![CDATA[Longitude]]>
        public double? Longitude { get; set; }
        ///<![CDATA[State name]]>
        public string Name { get; set; }
        ///<![CDATA[State code]]>
        public string State { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingAmountsPayable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Age group 1]]>
        public Int32 AgeGroup1 { get; set; }
        ///<![CDATA[Amount of age group 1]]>
        public double AgeGroup1Amount { get; set; }
        ///<![CDATA[Description of AgeGroup1]]>
        public string AgeGroup1Description { get; set; }
        ///<![CDATA[Age group 2]]>
        public Int32 AgeGroup2 { get; set; }
        ///<![CDATA[Amount of age group 2]]>
        public double AgeGroup2Amount { get; set; }
        ///<![CDATA[Description of AgeGroup2]]>
        public string AgeGroup2Description { get; set; }
        ///<![CDATA[Age group 3]]>
        public Int32 AgeGroup3 { get; set; }
        ///<![CDATA[Amount of age group 3]]>
        public double AgeGroup3Amount { get; set; }
        ///<![CDATA[Description of AgeGroup3]]>
        public string AgeGroup3Description { get; set; }
        ///<![CDATA[Age group 4]]>
        public Int32 AgeGroup4 { get; set; }
        ///<![CDATA[Amount of age group 4]]>
        public double AgeGroup4Amount { get; set; }
        ///<![CDATA[Description of AgeGroup4]]>
        public string AgeGroup4Description { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Total amount of all age groups]]>
        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingAmountsReceivable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Age group 1]]>
        public Int32 AgeGroup1 { get; set; }
        ///<![CDATA[Amount of age group 1]]>
        public double AgeGroup1Amount { get; set; }
        ///<![CDATA[Description of AgeGroup1]]>
        public string AgeGroup1Description { get; set; }
        ///<![CDATA[Age group 2]]>
        public Int32 AgeGroup2 { get; set; }
        ///<![CDATA[Amount of age group 2]]>
        public double AgeGroup2Amount { get; set; }
        ///<![CDATA[Description of AgeGroup2]]>
        public string AgeGroup2Description { get; set; }
        ///<![CDATA[Age group 3]]>
        public Int32 AgeGroup3 { get; set; }
        ///<![CDATA[Amount of age group 3]]>
        public double AgeGroup3Amount { get; set; }
        ///<![CDATA[Description of AgeGroup3]]>
        public string AgeGroup3Description { get; set; }
        ///<![CDATA[Age group 4]]>
        public Int32 AgeGroup4 { get; set; }
        ///<![CDATA[Amount of age group 4]]>
        public double AgeGroup4Amount { get; set; }
        ///<![CDATA[Description of AgeGroup4]]>
        public string AgeGroup4Description { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Total amount of all age groups]]>
        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AgeGroup")]
    public class AgingOverview
    {
        ///<![CDATA[Primary key]]>
        public Int32 AgeGroup { get; set; }
        ///<![CDATA[Description of AgeGroup]]>
        public string AgeGroupDescription { get; set; }
        ///<![CDATA[Amount payable]]>
        public double AmountPayable { get; set; }
        ///<![CDATA[Amount receivable]]>
        public double AmountReceivable { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Asset
    {
        ///<![CDATA[Indicates if an asset was already depreciated before registering it in Exact Online]]>
        public byte AlreadyDepreciated { get; set; }
        ///<![CDATA[In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset]]>
        public Guid AssetFrom { get; set; }
        ///<![CDATA[Description of AssetFrom]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetFromDescription { get; set; }
        ///<![CDATA[Asset group identifies GLAccounts to be used for Asset transactions]]>
        public Guid AssetGroup { get; set; }
        ///<![CDATA[Description of AssetGroup]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetGroupDescription { get; set; }
        ///<![CDATA[The catalogue value of the asset]]>
        public double? CatalogueValue { get; set; }
        ///<![CDATA[This is the code of the asset]]>
        public string Code { get; set; }
        ///<![CDATA[Assets can be linked to a cost center]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Assets can be linked to a cost unit]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Used for Belgium legislation. Used to produce the official 'Investment deduction' report]]>
        public double? DeductionPercentage { get; set; }
        ///<![CDATA[Amount that is already depreciated when adding an existing asset. Can only be filled when 'Alreadydepreciated' is on]]>
        public double? DepreciatedAmount { get; set; }
        ///<![CDATA[Number of periods that already have been depreciated for the asset. Can only be filled when 'Alreadydepreciated' is on]]>
        public Int32 DepreciatedPeriods { get; set; }
        ///<![CDATA[StartDate of depreciating. Can only be filled when 'Alreadydepreciated' is on]]>
        public DateTime DepreciatedStartDate { get; set; }
        ///<![CDATA[This is the description of the Asset]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Asset EndDate is filled when asset is Sold or Inactive]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Engine emission of the asset, needed to calculate the co² report]]>
        public Int16 EngineEmission { get; set; }
        ///<![CDATA[Engine type of the asset, Needed to generate a co² report]]>
        public Int16 EngineType { get; set; }
        ///<![CDATA[Links to the gltransactions.id. GL transaction line based on which the asset is created]]>
        public Guid GLTransactionLine { get; set; }
        ///<![CDATA[Description of GLTransactionLine]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLTransactionLineDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Supplier of the asset]]>
        public Guid InvestmentAccount { get; set; }
        ///<![CDATA[Code of InvestmentAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountCode { get; set; }
        ///<![CDATA[Name of InvestmentAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountName { get; set; }
        ///<![CDATA[Investment amount in the default currency of the company]]>
        public double? InvestmentAmountDC { get; set; }
        ///<![CDATA[Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status 'Not used' after sources have been cleaned]]>
        public double? InvestmentAmountFC { get; set; }
        ///<![CDATA[Indicates the currency of the investment amount]]>
        public string InvestmentCurrency { get; set; }
        ///<![CDATA[Description of InvestmentCurrency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentCurrencyDescription { get; set; }
        ///<![CDATA[Refers to the original date when the asset was bought]]>
        public DateTime InvestmentDate { get; set; }
        ///<![CDATA[Belgian functionality, to determine how a local legal report regarding investment deduction must be created]]>
        public Int16 InvestmentDeduction { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks for the asset]]>
        public string Notes { get; set; }
        ///<![CDATA[Parent asset]]>
        public Guid Parent { get; set; }
        ///<![CDATA[Code of Parent]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentCode { get; set; }
        ///<![CDATA[Description of Parent]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentDescription { get; set; }
        ///<![CDATA[Image for an asset]]>
        public byte[] Picture { get; set; }
        ///<![CDATA[Filename of the image]]>
        public string PictureFileName { get; set; }
        ///<![CDATA[First method of depreciation. Currently, it is the only one used]]>
        public Guid PrimaryMethod { get; set; }
        ///<![CDATA[Code of PrimaryMethod]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodCode { get; set; }
        ///<![CDATA[Description of PrimaryMethod]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodDescription { get; set; }
        ///<![CDATA[Indicates the residual value of the asset at the end of the depreciation]]>
        public double? ResidualValue { get; set; }
        ///<![CDATA[Asset Depreciation StartDate]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Identifies the status of the Asset. (see AssetStatus table to see the possibilities)]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Reference to Transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid TransactionEntryID { get; set; }
        ///<![CDATA[Entry number of transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 TransactionEntryNo { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Bank
    {
        ///<![CDATA[The name of the bank]]>
        public string BankName { get; set; }
        ///<![CDATA[The bank identification code of the bank]]>
        public string BICCode { get; set; }
        ///<![CDATA[The country in which the bank is based]]>
        public string Country { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[The extended description of the bank]]>
        public string Description { get; set; }
        ///<![CDATA[The account format used by the bank]]>
        public string Format { get; set; }
        ///<![CDATA[The website of the bank]]>
        public string HomePageAddress { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[The status of the bank. A = Active, P = Passive]]>
        public string Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BankAccount
    {
        ///<![CDATA[Account (customer, supplier) to which the bank account belongs]]>
        public Guid Account { get; set; }
        ///<![CDATA[The name of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Bank { get; set; }
        ///<![CDATA[The bank account number]]>
        [JsonProperty(PropertyName = "BankAccount")]
        public string BankAccountProperty { get; set; }
        ///<![CDATA[Name of the holder of the bank account, as known by the bank]]>
        public string BankAccountHolderName { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankDescription { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }
        ///<![CDATA[BIC code of the bank where the bank account is held]]>
        public string BICCode { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the bank account]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Format that belongs to the bank account number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Format { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string IBAN { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if the bank account is the main bank account]]>
        public bool? Main { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[ID of the Payment service account. Used when Type is 'P' (Payment service)]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid PaymentServiceAccount { get; set; }
        ///<![CDATA[The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it's only possible to create 'Account' type bank accounts.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }
        ///<![CDATA[Description of the Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class BankEntry
    {
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<BankEntryLine> BankEntryLines { get; set; }
        ///<![CDATA[Reference to document with bank statement]]>
        public Guid BankStatementDocument { get; set; }
        ///<![CDATA[Document number of document with bank statement]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 BankStatementDocumentNumber { get; set; }
        ///<![CDATA[Subject of document with bank statement]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankStatementDocumentSubject { get; set; }
        ///<![CDATA[Closing balance in the currency of the transaction]]>
        public double? ClosingBalanceFC { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Fiancial period]]>
        public Int16 FinancialPeriod { get; set; }
        ///<![CDATA[Fiancial year]]>
        public Int16 FinancialYear { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Opening balance in the currency of the transaction]]>
        public double? OpeningBalanceFC { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class BankEntryLine
    {
        ///<![CDATA[Reference to Account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? AmountVATFC { get; set; }
        ///<![CDATA[Reference to an asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Code of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        ///<![CDATA[Description of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to a cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to a cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        public DateTime Date { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to a document]]>
        public Guid Document { get; set; }
        ///<![CDATA[Number of Document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of Document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Reference to the header]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number of the header]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }
        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Reference to offset line]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid OffsetID { get; set; }
        public Int32 OurRef { get; set; }
        ///<![CDATA[Reference to a project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Reference to vat code]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[Vat code percentage]]>
        public double? VATPercentage { get; set; }
        ///<![CDATA[Type of vat code]]>
        public string VATType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class BatchNumber
    {
        ///<![CDATA[Available quantity of this batch number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AvailableQuantity { get; set; }
        ///<![CDATA[Human readable batch number]]>
        [JsonProperty(PropertyName = "BatchNumber")]
        public string BatchNumberProperty { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Expiry date of effective period for batch number]]>
        public DateTime ExpiryDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Blocking state]]>
        public byte? IsBlocked { get; set; }
        ///<![CDATA[Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Budget
    {
        ///<![CDATA[Budget amount (always in the default currency of the company)]]>
        public double? AmountDC { get; set; }
        ///<![CDATA[Budget scenario]]>
        public Guid BudgetScenario { get; set; }
        ///<![CDATA[Code of BudgetScenario]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioCode { get; set; }
        ///<![CDATA[Description of BudgetScenario]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioDescription { get; set; }
        ///<![CDATA[Used for cost center-specific budgets - NULL otherwise]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Used for cost unit-specific budgets - NULL otherwise]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[G/L account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Numerical ID. Never displayed to the user, but it may have its use for performance reasons]]>
        public Int64 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Used for item-specific budgets - NULL otherwise]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Period (combined with financial year)]]>
        public Int16 ReportingPeriod { get; set; }
        ///<![CDATA[Financial year]]>
        public Int16 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class CashEntry
    {
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<CashEntryLine> CashEntryLines { get; set; }
        ///<![CDATA[Closing balance in the currency of the transaction]]>
        public double? ClosingBalanceFC { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Fiancial period]]>
        public Int16 FinancialPeriod { get; set; }
        ///<![CDATA[Fiancial year]]>
        public Int16 FinancialYear { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Opening balance in the currency of the transaction]]>
        public double? OpeningBalanceFC { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class CashEntryLine
    {
        ///<![CDATA[Reference to Account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? AmountVATFC { get; set; }
        ///<![CDATA[Reference to an asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Code of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        ///<![CDATA[Description of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to a cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to a cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        public DateTime Date { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to a document]]>
        public Guid Document { get; set; }
        ///<![CDATA[Number of Document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of Document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Reference to the header]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number of the header]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }
        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Reference to offset line]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid OffsetID { get; set; }
        public Int32 OurRef { get; set; }
        ///<![CDATA[Reference to a project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Reference to vat code]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[Vat code percentage]]>
        public double? VATPercentage { get; set; }
        ///<![CDATA[Type of vat code]]>
        public string VATType { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Contact
    {
        ///<![CDATA[The account to which the contact belongs]]>
        public Guid Account { get; set; }
        ///<![CDATA[Indicates if account is a customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }
        ///<![CDATA[Indicates if account is a supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        ///<![CDATA[Reference to the main contact of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid AccountMainContact { get; set; }
        ///<![CDATA[Name of the account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Second address line]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }
        ///<![CDATA[Street name of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }
        ///<![CDATA[Street number of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }
        ///<![CDATA[Street number suffix of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AllowMailing { get; set; }
        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }
        ///<![CDATA[Last birth name]]>
        public string BirthName { get; set; }
        ///<![CDATA[Middle birth name]]>
        public string BirthNamePrefix { get; set; }
        ///<![CDATA[Birth place]]>
        public string BirthPlace { get; set; }
        ///<![CDATA[Email address of the contact]]>
        public string BusinessEmail { get; set; }
        ///<![CDATA[Fax of the contact]]>
        public string BusinessFax { get; set; }
        ///<![CDATA[Mobile of the contact]]>
        public string BusinessMobile { get; set; }
        ///<![CDATA[Phone of the contact]]>
        public string BusinessPhone { get; set; }
        ///<![CDATA[Phone extension of the contact]]>
        public string BusinessPhoneExtension { get; set; }
        ///<![CDATA[City]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }
        ///<![CDATA[Code of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }
        ///<![CDATA[Country code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Email address of the contact]]>
        public string Email { get; set; }
        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
        public string FirstName { get; set; }
        ///<![CDATA[Full name (First name Middle name Last name)]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }
        ///<![CDATA[Gender]]>
        public string Gender { get; set; }
        ///<![CDATA[Contact ID]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Identification date]]>
        public DateTime IdentificationDate { get; set; }
        ///<![CDATA[Reference to the identification document of the contact]]>
        public Guid IdentificationDocument { get; set; }
        ///<![CDATA[Reference to the user responsible for identification]]>
        public Guid IdentificationUser { get; set; }
        ///<![CDATA[Initials]]>
        public string Initials { get; set; }
        ///<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
        public bool? IsMailingExcluded { get; set; }
        ///<![CDATA[Indicates if this is the main contact of the linked account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }
        ///<![CDATA[Jobtitle of the contact]]>
        public string JobTitleDescription { get; set; }
        ///<![CDATA[Language code]]>
        public string Language { get; set; }
        ///<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
        public string LastName { get; set; }
        ///<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
        public string MarketingNotes { get; set; }
        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }
        ///<![CDATA[Business phone of the contact]]>
        public string Mobile { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Last name of partner]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }
        ///<![CDATA[Middlename of partner]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }
        ///<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
        public Guid Person { get; set; }
        ///<![CDATA[Phone of the contact]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone extension of the contact]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }
        ///<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
        public byte[] Picture { get; set; }
        ///<![CDATA[Filename of the picture]]>
        public string PictureName { get; set; }
        ///<![CDATA[Url to retrieve the picture thumbnail]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        ///<![CDATA[Url to retrieve the picture]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        ///<![CDATA[Postcode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }
        ///<![CDATA[Social security number]]>
        public string SocialSecurityNumber { get; set; }
        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[State]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }
        ///<![CDATA[Title]]>
        public string Title { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costcenter
    {
        ///<![CDATA[Indicates if the cost center is active: 0 = inactive 1 = active]]>
        public bool? Active { get; set; }
        ///<![CDATA[Code (user-defined ID)]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description (text)]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class CostTransaction
    {
        ///<![CDATA[Account linked to the transaction]]>
        public Guid Account { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }
        ///<![CDATA[Amount of the transaction in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Attachment linked to the transaction (not mandatory)]]>
        public Guid Attachment { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency of the amount]]>
        public string Currency { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Description of Division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }
        ///<![CDATA[Employee linked to the transaction]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Entrynumber]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Errortext, used for the backgroundjobs]]>
        public string ErrorText { get; set; }
        public Guid Expense { get; set; }
        ///<![CDATA[Description of ProjectWBS]]>
        public string ExpenseDescription { get; set; }
        ///<![CDATA[Status of the transaction]]>
        public Int16 HourStatus { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactionsItems of other types are linked to costtransactions]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes linked to the transaction (not mandatory)]]>
        public string Notes { get; set; }
        ///<![CDATA[Price in the currency of the transaction]]>
        public double? Price { get; set; }
        ///<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
        public double? PriceFC { get; set; }
        ///<![CDATA[Project linked to the transaction]]>
        public Guid Project { get; set; }
        ///<![CDATA[Project account linked to the transaction (not mandatory)]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ProjectAccount { get; set; }
        ///<![CDATA[Project account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }
        ///<![CDATA[Project account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity of the transaction]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Subscription linked to the transaction]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Account linked to the subscription]]>
        public Guid SubscriptionAccount { get; set; }
        ///<![CDATA[Subscription account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }
        ///<![CDATA[Subscription account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }
        ///<![CDATA[Description of the subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Subscription number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
        ///<![CDATA[Type of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costunit
    {
        ///<![CDATA[Code (user-defined)]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description (text)]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Currency
    {
        ///<![CDATA[Amount precision]]>
        public double AmountPrecision { get; set; }
        ///<![CDATA[Primary key]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[Description of the currency]]>
        public string Description { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[Price precision]]>
        public double PricePrecision { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Department
    {
        ///<![CDATA[Department Code]]>
        public string Code { get; set; }
        ///<![CDATA[Cost center Code]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Cost center description]]>
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Department description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DepreciationMethod
    {
        ///<![CDATA[When the method is fixed amount, this is the periodic depreciation amount]]>
        public double? Amount { get; set; }
        ///<![CDATA[Code of the depreciation method]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Describes the periodic interval]]>
        public string DepreciationInterval { get; set; }
        ///<![CDATA[Description of the method]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates the maximum value when using depreciation type degressive to linear]]>
        public double? MaxPercentage { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Degressive percentage for methods: 10 - Degressive to linear, 11 - Degressive (fixed perc. of book value), 12 - Degressive to linear (Belgium & Luxembourg only). And interest percentage for method: 40 - Normal annuity method. On import: Can not be modified if depreciation method is already linked to an asset. For Belgium & Luxembourg the degressive percentage is calculated as double of the linear percentage]]>
        public double? Percentage { get; set; }
        ///<![CDATA[Linear percentage for methods: 10 - Degressive to linear, 3 - Linear depreciation (Belgium & Luxembourg only), 12 - Degressive to linear (Belgium & Luxembourg only). On import: Can not be modified if depreciation method is already linked to an asset]]>
        public double? Percentage2 { get; set; }
        ///<![CDATA[The total number of periods for the depreciation method. Used in combination with depreciation interval: only used when interval is periodic]]>
        public Int16 Periods { get; set; }
        ///<![CDATA[The actual type of deprecation, such as lineair or degressive. The periodic amounts are based on this type, in combination with other fields, such as the interval and the periods]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Determines the total number of years for the depreciation method. Used in combination with depreciation interval: only used when interval is yearly]]>
        public Int16 Years { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DirectDebitMandate
    {
        ///<![CDATA[Account the mandate belongs to]]>
        public Guid Account { get; set; }
        ///<![CDATA[Bank account the mandate applies to]]>
        public Guid BankAccount { get; set; }
        ///<![CDATA[Cancellation date]]>
        public DateTime CancellationDate { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Indicates the first collection hasn't been sent/confirmed with this mandate.]]>
        public byte? FirstSend { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Payment type. 0 = one-off payment, 1 = recurrent payment, 2 = AdHoc (UK only)]]>
        public Int16 PaymentType { get; set; }
        ///<![CDATA[Reference]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Reference { get; set; }
        ///<![CDATA[Signature date]]>
        public DateTime SignatureDate { get; set; }
        ///<![CDATA[Type. 0 = core, 1 = B2B and 2 = bottomline (UK only)]]>
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {
        ///<![CDATA[Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed]]>
        public Int32 BlockingStatus { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 Code { get; set; }
        ///<![CDATA[Country of the division. Is used for determination of legislation]]>
        public string Country { get; set; }
        ///<![CDATA[Description of Country]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Default currency of the division]]>
        public string Currency { get; set; }
        ///<![CDATA[Description of Currency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        ///<![CDATA[Owner account of the division]]>
        public Guid Customer { get; set; }
        ///<![CDATA[Owner account code of the division]]>
        public string CustomerCode { get; set; }
        ///<![CDATA[Owner account name of the division]]>
        public string CustomerName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Number that customers give to the division]]>
        public Int64 HID { get; set; }
        ///<![CDATA[True for the main (hosting) division]]>
        public bool? Main { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Siret Number of the division (France)]]>
        public string SiretNumber { get; set; }
        ///<![CDATA[Date on which the division becomes active]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Regular administrations will have status 0.  Currently, the only other possibility is 'archived' (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Number of your local tax authority (Germany)]]>
        public string TaxOfficeNumber { get; set; }
        ///<![CDATA[Local tax reference number (Germany)]]>
        public string TaxReferenceNumber { get; set; }
        ///<![CDATA[VAT number]]>
        public string VATNumber { get; set; }
        ///<![CDATA[Customer value, hyperlink to external website]]>
        public string Website { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Document
    {
        ///<![CDATA[ID of the related account of this document]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Body of this document]]>
        public string Body { get; set; }
        ///<![CDATA[ID of the category of this document]]>
        public Guid Category { get; set; }
        ///<![CDATA[Description of Category]]>
        public string CategoryDescription { get; set; }
        ///<![CDATA[ID of the related contact of this document]]>
        public Guid Contact { get; set; }
        ///<![CDATA[Contact full name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Entry date of the incoming document]]>
        public DateTime DocumentDate { get; set; }
        ///<![CDATA[The Id of document folder]]>
        public Guid DocumentFolder { get; set; }
        ///<![CDATA[The Code of document folder]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderCode { get; set; }
        ///<![CDATA[The Decsription of document folder]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderDescription { get; set; }
        ///<![CDATA[Url to view the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }
        ///<![CDATA[Reference to the financial transaction]]>
        public Guid FinancialTransactionEntryID { get; set; }
        ///<![CDATA[Indicates that the document body is empty]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasEmptyBody { get; set; }
        ///<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The language code of the document]]>
        public string Language { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The opportunity linked to the document]]>
        public Guid Opportunity { get; set; }
        ///<![CDATA[The project linked to the document]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA['Our reference' of the transaction that belongs to this document]]>
        public Int32 SalesInvoiceNumber { get; set; }
        ///<![CDATA[Number of the sales order]]>
        public Int32 SalesOrderNumber { get; set; }
        ///<![CDATA[Number of the shop order]]>
        public Int32 ShopOrderNumber { get; set; }
        ///<![CDATA[Subject of this document]]>
        public string Subject { get; set; }
        ///<![CDATA[ID of the type of this document]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentAttachment
    {
        ///<![CDATA[Contains the attachment]]>
        public byte[] Attachment { get; set; }
        ///<![CDATA[Reference to the Document]]>
        public Guid Document { get; set; }
        ///<![CDATA[Filename of the attachment]]>
        public string FileName { get; set; }
        ///<![CDATA[File size of the attachment]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double FileSize { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Url of the attachment]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentCategory
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[Document category description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentFolder
    {
        ///<![CDATA[Document folder code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Document folder description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Document folder parent folder ID]]>
        public Guid ParentFolder { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentType
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[Document type description]]>
        public string Description { get; set; }
        ///<![CDATA[Indicates if documents of this type can be created]]>
        public bool DocumentIsCreatable { get; set; }
        ///<![CDATA[Indicates if documents of this type can be deleted]]>
        public bool DocumentIsDeletable { get; set; }
        ///<![CDATA[Indicates if documents of this type can be updated]]>
        public bool DocumentIsUpdatable { get; set; }
        ///<![CDATA[Indicates if documents of this type can be retrieved]]>
        public bool DocumentIsViewable { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[ID of the document type category]]>
        public Int32 TypeCategory { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentTypeCategory
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[Document category type description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentTypeFolder
    {
        ///<![CDATA[Date created]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User id of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Folder to which document type is linked]]>
        public Guid DocumentFolder { get; set; }
        ///<![CDATA[Code of document type which is linked to folder]]>
        public Int32 DocumentType { get; set; }
        public Guid ID { get; set; }
        ///<![CDATA[Date Modified]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User id of modifier]]>
        public Guid Modifier { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employee
    {
        ///<![CDATA[Obsolete]]>
        public byte? ActiveEmployment { get; set; }
        ///<![CDATA[Second address line]]>
        public string AddressLine2 { get; set; }
        ///<![CDATA[Third address line]]>
        public string AddressLine3 { get; set; }
        ///<![CDATA[Street of address]]>
        public string AddressStreet { get; set; }
        ///<![CDATA[Street number of address]]>
        public string AddressStreetNumber { get; set; }
        ///<![CDATA[Street number suffix of address]]>
        public string AddressStreetNumberSuffix { get; set; }
        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }
        ///<![CDATA[Birth name]]>
        public string BirthName { get; set; }
        ///<![CDATA[Birth middle name]]>
        public string BirthNamePrefix { get; set; }
        ///<![CDATA[Birth place]]>
        public string BirthPlace { get; set; }
        ///<![CDATA[Email of the employee at the office]]>
        public string BusinessEmail { get; set; }
        ///<![CDATA[Fax number of the employee at the office]]>
        public string BusinessFax { get; set; }
        ///<![CDATA[Office mobile number of the employee]]>
        public string BusinessMobile { get; set; }
        ///<![CDATA[Phone number of the employee at the office]]>
        public string BusinessPhone { get; set; }
        ///<![CDATA[Phone extension of the employee at the office]]>
        public string BusinessPhoneExtension { get; set; }
        ///<![CDATA[Obsolete]]>
        public string CASONumber { get; set; }
        ///<![CDATA[City]]>
        public string City { get; set; }
        ///<![CDATA[Code of the employee]]>
        public string Code { get; set; }
        ///<![CDATA[Country code]]>
        public string Country { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Customer ID]]>
        public Guid Customer { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Email address]]>
        public string Email { get; set; }
        ///<![CDATA[Employee number]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[End date of the employee]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[First name of the employee]]>
        public string FirstName { get; set; }
        ///<![CDATA[Full name of the employee]]>
        public string FullName { get; set; }
        ///<![CDATA[Gender]]>
        public string Gender { get; set; }
        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Initials]]>
        public string Initials { get; set; }
        ///<![CDATA[IsActive]]>
        public bool IsActive { get; set; }
        ///<![CDATA[Language code]]>
        public string Language { get; set; }
        ///<![CDATA[Last name]]>
        public string LastName { get; set; }
        ///<![CDATA[Description of the location of the employee (where am I?)]]>
        public string LocationDescription { get; set; }
        ///<![CDATA[Direct manager of the employee]]>
        public Guid Manager { get; set; }
        ///<![CDATA[Date of marriage]]>
        public DateTime MaritalDate { get; set; }
        ///<![CDATA[Marital status]]>
        public Int16 MaritalStatus { get; set; }
        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }
        ///<![CDATA[Mobile phone]]>
        public string Mobile { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Municipality]]>
        public string Municipality { get; set; }
        public Int16 NameComposition { get; set; }
        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }
        ///<![CDATA[Nick name]]>
        public string NickName { get; set; }
        ///<![CDATA[Additional notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Name of partner]]>
        public string PartnerName { get; set; }
        ///<![CDATA[Middle name of partner]]>
        public string PartnerNamePrefix { get; set; }
        ///<![CDATA[Reference to the persons table in which the personal data of the employee is stored]]>
        public Guid Person { get; set; }
        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone number extension]]>
        public string PhoneExtension { get; set; }
        ///<![CDATA[Filename of picture]]>
        public string PictureFileName { get; set; }
        ///<![CDATA[Url of picture]]>
        public string PictureUrl { get; set; }
        ///<![CDATA[Postcode]]>
        public string Postcode { get; set; }
        ///<![CDATA[Private email address]]>
        public string PrivateEmail { get; set; }
        ///<![CDATA[Social security number]]>
        public string SocialSecurityNumber { get; set; }
        ///<![CDATA[Start date of the employee]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[State]]>
        public string State { get; set; }
        ///<![CDATA[Title]]>
        public string Title { get; set; }
        ///<![CDATA[User ID of employee]]>
        public Guid User { get; set; }
        ///<![CDATA[Name of user]]>
        public string UserFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employment
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Employee ID]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Numeric number of Employee]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[End date of employment]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[ID of employment ended]]>
        public Int32 ReasonEnd { get; set; }
        ///<![CDATA[Reason of end of employment]]>
        public string ReasonEndDescription { get; set; }
        ///<![CDATA[Reason of ended flexible employment]]>
        public Int32 ReasonEndFlex { get; set; }
        ///<![CDATA[Other reason for end of employment]]>
        public string ReasonEndFlexDescription { get; set; }
        ///<![CDATA[Start date of employment]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
        public DateTime StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContract
    {
        ///<![CDATA[Flexible employment contract phase]]>
        public Int32 ContractFlexPhase { get; set; }
        ///<![CDATA[Flexible employment contract phase description.]]>
        public string ContractFlexPhaseDescription { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Document ID of the employment contract]]>
        public Guid Document { get; set; }
        ///<![CDATA[ID of employee]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker]]>
        public Int32 EmployeeType { get; set; }
        ///<![CDATA[Employee type description]]>
        public string EmployeeTypeDescription { get; set; }
        ///<![CDATA[Employment ID]]>
        public Guid Employment { get; set; }
        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 EmploymentHID { get; set; }
        ///<![CDATA[End date of employment contract]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes of employment contract]]>
        public string Notes { get; set; }
        ///<![CDATA[Employment probation end date]]>
        public DateTime ProbationEndDate { get; set; }
        ///<![CDATA[Employment probation period]]>
        public Int32 ProbationPeriod { get; set; }
        ///<![CDATA[Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other]]>
        public Int32 ReasonContract { get; set; }
        ///<![CDATA[Employment contract reason description]]>
        public string ReasonContractDescription { get; set; }
        ///<![CDATA[Sequence number]]>
        public Int32 Sequence { get; set; }
        ///<![CDATA[Start date of employment contract]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of employment contract type]]>
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContractFlexPhase
    {
        ///<![CDATA[Flexible employment contract phase description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentEndReason
    {
        ///<![CDATA[Employment end reason description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentOrganization
    {
        ///<![CDATA[Cost center code]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of cost center]]>
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Cost unit code]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of cost unit]]>
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[ID of department]]>
        public Guid Department { get; set; }
        ///<![CDATA[Department code]]>
        public string DepartmentCode { get; set; }
        ///<![CDATA[Department description for organization]]>
        public string DepartmentDescription { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[ID of employee]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Employement ID]]>
        public Guid Employment { get; set; }
        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 EmploymentHID { get; set; }
        ///<![CDATA[Organization end date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[ID of job title]]>
        public Guid JobTitle { get; set; }
        ///<![CDATA[Job title code]]>
        public string JobTitleCode { get; set; }
        ///<![CDATA[Job title description]]>
        public string JobTitleDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Organization start date]]>
        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentSalary
    {
        ///<![CDATA[The average number of contract days that an employee works per week]]>
        public double? AverageDaysPerWeek { get; set; }
        ///<![CDATA[The average number of contract hours that an employee works per week]]>
        public double? AverageHoursPerWeek { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Employee ID]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Employee number]]>
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Employment]]>
        public Guid Employment { get; set; }
        ///<![CDATA[Employment number]]>
        public Int32 EmploymentHID { get; set; }
        ///<![CDATA[Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)]]>
        public Int32 EmploymentSalaryType { get; set; }
        ///<![CDATA[Salary type description]]>
        public string EmploymentSalaryTypeDescription { get; set; }
        ///<![CDATA[Salary record end date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Salary when working fulltime]]>
        public double? FulltimeAmount { get; set; }
        ///<![CDATA[Hourly wage]]>
        public double? HourlyWage { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Internal rate for time & billing or professional service user]]>
        public double? InternalRate { get; set; }
        ///<![CDATA[Employee job level in context of a wage scale]]>
        public Int32 JobLevel { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Salary when working parttime]]>
        public double? ParttimeAmount { get; set; }
        ///<![CDATA[Contract hours / Fulltime contract hours]]>
        public double? ParttimeFactor { get; set; }
        ///<![CDATA[Employee wage scale]]>
        public string Scale { get; set; }
        ///<![CDATA[Employment schedule]]>
        public Guid Schedule { get; set; }
        ///<![CDATA[Employment schedule code]]>
        public string ScheduleCode { get; set; }
        ///<![CDATA[Description of employment schedule]]>
        public string ScheduleDescription { get; set; }
        ///<![CDATA[Salary record start date]]>
        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ExchangeRate
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY]]>
        public double? Rate { get; set; }
        ///<![CDATA[The foreign currency]]>
        public string SourceCurrency { get; set; }
        ///<![CDATA[Description of SourceCurrency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SourceCurrencyDescription { get; set; }
        ///<![CDATA[The date as of which the rate is valid. The rate is valid until a next rate is defined]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[The default currency of the division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrency { get; set; }
        ///<![CDATA[Description of TargetCurrency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrencyDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class FinancialPeriod
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[The end date of the period]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[The financial period. Usually the period is a month or quarter with period 1 starting on the first of January.]]>
        public Int16 FinPeriod { get; set; }
        ///<![CDATA[The financial year. The financial year and calendar year are not always aligned.]]>
        public Int16 FinYear { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The start date of a period. A start date should always succeed a previous end date. Except for the first year/period combination]]>
        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class GeneralJournalEntry
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }
        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }
        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<GeneralJournalEntryLine> GeneralJournalEntryLines { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Indicates that amounts are reversed]]>
        public bool? Reversal { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Type: 10 = Opening balance, 90 = Other]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GeneralJournalEntryLine
    {
        ///<![CDATA[Reference to account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the default currency of the company, If an 'Including' VAT code is used this amount includes the VAT amount.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction. If an 'Including' VAT code is used this amount includes the VAT amount.]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Vat amount in the default currency of the company.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountVATDC { get; set; }
        ///<![CDATA[Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.]]>
        public double? AmountVATFC { get; set; }
        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Code of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        ///<![CDATA[Description of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Entry date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to document]]>
        public Guid Document { get; set; }
        ///<![CDATA[Document number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Document subject]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Reference to header of the entry]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number of the header]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        public Guid OffsetID { get; set; }
        ///<![CDATA[Our ref of general journal entry]]>
        public Int32 OurRef { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[VAT base amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }
        ///<![CDATA[VAT base amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountFC { get; set; }
        ///<![CDATA[VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[Vat percentage]]>
        public double? VATPercentage { get; set; }
        ///<![CDATA[The VAT type determines what the values are in relation to VAT returns. The following values are supported:<br>A Sales VAT to pay,<br>D Credit note extra duty to claim,<br>I Purchase basis,<br>M Credit note purchase non-deductible,<br>N Purchase non-deductible,<br>O Purchase VAT to claim,<br>P Purchase VAT to pay,<br>Q Credit note purchase VAT to claim,<br>R Extra duty to pay,<br>S No VAT,<br>V Sales basis,<br>W Credit note purchase basis,<br>X Credit note sales basis,<br>Y Credit note purchase VAT to pay,<br>Z Credit note sales VAT to claim]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATType { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class GLAccount
    {
        ///<![CDATA[AssimilatedVATBox (France)]]>
        public Int16 AssimilatedVATBox { get; set; }
        ///<![CDATA[The following values are supported: D (Debit) C (Credit)]]>
        public string BalanceSide { get; set; }
        ///<![CDATA[The following values are supported: B (Balance Sheet) W (Profit & Loss)]]>
        public string BalanceType { get; set; }
        ///<![CDATA[Indentify the kind of rewarding for the GL account. This is used in the official document for the fiscal fiches Belcotax]]>
        public Int32 BelcotaxType { get; set; }
        ///<![CDATA[Unique Code of the G/L Account]]>
        public string Code { get; set; }
        ///<![CDATA[Indicate if this GL account should be shown as compressed without the details in the CRW report of GL history]]>
        public bool? Compress { get; set; }
        ///<![CDATA[Cost Center linked to the G/L Account]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Cost Unit linked to the G/L Account]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Name of the G/L Account]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[GLTransactions on this GLAccount should not appear on the VAT listing]]>
        public byte ExcludeVATListing { get; set; }
        ///<![CDATA[Expenses on this GLAccount can not be used to reduce the incomes]]>
        public double? ExpenseNonDeductiblePercentage { get; set; }
        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }
        ///<![CDATA[When blocked you can't use this general ledger account anymore for new entries]]>
        public bool? IsBlocked { get; set; }
        ///<![CDATA[Allow entries on this general ledger account to be matched via the GL Account card]]>
        public bool? Matching { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[If a private use percentage is defined, you need to specify the GL used for the re-invoice of the private use to the owner of the company]]>
        public Guid PrivateGLAccount { get; set; }
        ///<![CDATA[Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs]]>
        public double? PrivatePercentage { get; set; }
        ///<![CDATA[Used in the export of yearly report]]>
        public string ReportingCode { get; set; }
        ///<![CDATA[Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done]]>
        public bool? RevalueCurrency { get; set; }
        ///<![CDATA[Search Code]]>
        public string SearchCode { get; set; }
        ///<![CDATA[Type of G/L Account (for example, 110 = Revenue)]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
        public byte? UseCostcenter { get; set; }
        ///<![CDATA[Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
        public byte? UseCostunit { get; set; }
        ///<![CDATA[VAT Code linked to the G/L Account (for example, 2 or 4)]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VAT]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        ///<![CDATA[Specify the kind of purchase this GL account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go]]>
        public string VATGLAccountType { get; set; }
        ///<![CDATA[If you use a percentage of non deductible VAT, you can specify another GL account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.]]>
        public Guid VATNonDeductibleGLAccount { get; set; }
        ///<![CDATA[If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices]]>
        public double? VATNonDeductiblePercentage { get; set; }
        ///<![CDATA[The following values are supported: I (Invoice) C (Cash) (France)]]>
        public string VATSystem { get; set; }
        ///<![CDATA[Indicates the costing account for year end calculations]]>
        public Guid YearEndCostGLAccount { get; set; }
        ///<![CDATA[Indicates the reflection account that is used by year end application]]>
        public Guid YearEndReflectionGLAccount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLClassification
    {
        ///<![CDATA[Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents]]>
        public bool? Abstract { get; set; }
        ///<![CDATA[Only used for amount concepts: in that case either 'debit' or 'credit']]>
        public string Balance { get; set; }
        ///<![CDATA[The Code is unique]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table]]>
        public string Description { get; set; }
        ///<![CDATA[Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Obsolete]]>
        public bool? IsTupleSubElement { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The Name is unique in the namespace]]>
        public string Name { get; set; }
        ///<![CDATA[Determines whether usage of the element is mandatory in an instance document]]>
        public bool? Nillable { get; set; }
        ///<![CDATA[Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.]]>
        public Guid Parent { get; set; }
        ///<![CDATA[Only used for item concepts: either 'instant' or 'duration'. 'instant' is used for balance types of concepts, 'duration' is used for P&L types of concepts]]>
        public string PeriodType { get; set; }
        ///<![CDATA[Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item]]>
        public string SubstitutionGroup { get; set; }
        ///<![CDATA[Namespace of the element]]>
        public Guid TaxonomyNamespace { get; set; }
        ///<![CDATA[Description of TaxonomyNamespace]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxonomyNamespaceDescription { get; set; }
        ///<![CDATA[Type of the element]]>
        public Guid Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLScheme
    {
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description text]]>
        public string Description { get; set; }
        ///<![CDATA[Division is optional for this table. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Only used for reporting schemes = division specific taxonomynamespaces. In this case, main = 1 denotes the main or default reporting scheme]]>
        public byte Main { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[URI, which is the unique identifier of the namespace]]>
        public string TargetNamespace { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLTransactionType
    {
        public string Description { get; set; }
        public string DescriptionSuffix { get; set; }
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("EntryID")]
    public class GoodsDelivery
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Reference to account for delivery]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAccount { get; set; }
        ///<![CDATA[Delivery account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        ///<![CDATA[Account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        ///<![CDATA[Reference to shipping address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAddress { get; set; }
        ///<![CDATA[Reference to contact for delivery]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid DeliveryContact { get; set; }
        ///<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        ///<![CDATA[Date of goods delivery]]>
        public DateTime DeliveryDate { get; set; }
        ///<![CDATA[Delivery number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DeliveryNumber { get; set; }
        ///<![CDATA[Header description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Document that is manually linked to the sales order delivery]]>
        public Guid Document { get; set; }
        ///<![CDATA[Document Subject]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<GoodsDeliveryLine> GoodsDeliveryLines { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[Reference to shipping method]]>
        public Guid ShippingMethod { get; set; }
        ///<![CDATA[Code of shipping method]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodCode { get; set; }
        ///<![CDATA[Description of shipping method]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        ///<![CDATA[Reference to header tracking number]]>
        public string TrackingNumber { get; set; }
        ///<![CDATA[Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Warehouse { get; set; }
        ///<![CDATA[Code of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("ID")]
    public class GoodsDeliveryLine
    {
        ///<![CDATA[Collection of batch numbers]]>
        public IEnumerable<StockBatchNumber> BatchNumbers { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Date of goods delivery]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime DeliveryDate { get; set; }
        ///<![CDATA[Description of sales order delivery]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Quantity delivered]]>
        public double? QuantityDelivered { get; set; }
        ///<![CDATA[Quantity ordered]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }
        ///<![CDATA[Reference to sales order]]>
        public Guid SalesOrderLineID { get; set; }
        ///<![CDATA[Sales order line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineNumber { get; set; }
        ///<![CDATA[Sales order number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }
        ///<![CDATA[Collection of serial numbers]]>
        public IEnumerable<StockSerialNumber> SerialNumbers { get; set; }
        ///<![CDATA[Reference to storage location for warehouse]]>
        public Guid StorageLocation { get; set; }
        ///<![CDATA[Reference to tracking number]]>
        public string TrackingNumber { get; set; }
        ///<![CDATA[Code of item unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unitcode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class HourCostType
    {
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class InvoiceSalesOrders
    {
        ///<![CDATA[Invoice creation mode- 0: Per customer 1: Per sales order]]>
        public Int32 CreateMode { get; set; }
        ///<![CDATA[Stock entries entry number.]]>
        public Int32 DeliveryNumber { get; set; }
        ///<![CDATA[Stock entries entry end date.]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Errors in the process.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Errors { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.]]>
        public Int32 InvoiceMode { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Number of invoices successfully created.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 NumberOfCreatedInvoices { get; set; }
        ///<![CDATA[Number of invoices failed to create.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 NumberOfFailedInvoices { get; set; }
        ///<![CDATA[Collection of Sales order IDs.]]>
        public IEnumerable<SalesOrderID> SalesOrderIDs { get; set; }
        ///<![CDATA[Stock entries entry start date.]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.]]>
        public DateTime UserInvoiceDate { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUser
    {
        ///<![CDATA[ID of the account the user is involved with]]>
        public Guid Account { get; set; }
        ///<![CDATA[City of the account]]>
        public string AccountCity { get; set; }
        ///<![CDATA[Code of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Supplier flag of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        ///<![CDATA[Logo thumbnail url of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountLogoThumbnailUrl { get; set; }
        ///<![CDATA[Name of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Status of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountStatus { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[ID of the user role]]>
        public Guid InvolvedUserRole { get; set; }
        ///<![CDATA[Description of the user role]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvolvedUserRoleDescription { get; set; }
        ///<![CDATA[Main contact flag of the involved user]]>
        public bool? IsMainContact { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Email of a person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonEmail { get; set; }
        ///<![CDATA[Phone of a person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhone { get; set; }
        ///<![CDATA[Phone extension of a person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhoneExtension { get; set; }
        ///<![CDATA[Picture thumbnail url of a person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPictureThumbnailUrl { get; set; }
        ///<![CDATA[ID of the involved user]]>
        public Guid User { get; set; }
        ///<![CDATA[User name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UserFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUserRole
    {
        ///<![CDATA[Code of the involved user role]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of role]]>
        public string Description { get; set; }
        ///<![CDATA[Description term code of role]]>
        public Int32 DescriptionTermID { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Item
    {
        ///<![CDATA[Barcode of the item (numeric string)]]>
        public string Barcode { get; set; }
        ///<![CDATA[Item class code referring to ItemClasses with ClassID 1]]>
        public string Class_01 { get; set; }
        ///<![CDATA[Item class code referring to ItemClasses with ClassID 2]]>
        public string Class_02 { get; set; }
        ///<![CDATA[Item class code referring to ItemClasses with ClassID 3]]>
        public string Class_03 { get; set; }
        ///<![CDATA[Item class code referring to ItemClasses with ClassID 4]]>
        public string Class_04 { get; set; }
        ///<![CDATA[Item class code referring to ItemClasses with ClassID 5]]>
        public string Class_05 { get; set; }
        ///<![CDATA[Item code]]>
        public string Code { get; set; }
        ///<![CDATA[Copy remarks to sales lines]]>
        public byte CopyRemarks { get; set; }
        ///<![CDATA[The currency of the current and proposed cost price]]>
        public string CostPriceCurrency { get; set; }
        ///<![CDATA[Proposed cost price]]>
        public double? CostPriceNew { get; set; }
        ///<![CDATA[The current standard cost price]]>
        public double? CostPriceStandard { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the item]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Together with StartDate this determines if the item is active]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Extra description text, slightly longer than the regular description (255 instead of 60)]]>
        public string ExtraDescription { get; set; }
        ///<![CDATA[Free boolean field 1]]>
        public bool? FreeBoolField_01 { get; set; }
        ///<![CDATA[Free boolean field 2]]>
        public bool? FreeBoolField_02 { get; set; }
        ///<![CDATA[Free boolean field 3]]>
        public bool? FreeBoolField_03 { get; set; }
        ///<![CDATA[Free boolean field 4]]>
        public bool? FreeBoolField_04 { get; set; }
        ///<![CDATA[Free boolean field 5]]>
        public bool? FreeBoolField_05 { get; set; }
        ///<![CDATA[Free date field 1]]>
        public DateTime FreeDateField_01 { get; set; }
        ///<![CDATA[Free date field 2]]>
        public DateTime FreeDateField_02 { get; set; }
        ///<![CDATA[Free date field 3]]>
        public DateTime FreeDateField_03 { get; set; }
        ///<![CDATA[Free date field 4]]>
        public DateTime FreeDateField_04 { get; set; }
        ///<![CDATA[Free date field 5]]>
        public DateTime FreeDateField_05 { get; set; }
        ///<![CDATA[Free numeric field 1]]>
        public double? FreeNumberField_01 { get; set; }
        ///<![CDATA[Free numeric field 2]]>
        public double? FreeNumberField_02 { get; set; }
        ///<![CDATA[Free numeric field 3]]>
        public double? FreeNumberField_03 { get; set; }
        ///<![CDATA[Free numeric field 4]]>
        public double? FreeNumberField_04 { get; set; }
        ///<![CDATA[Free numeric field 5]]>
        public double? FreeNumberField_05 { get; set; }
        ///<![CDATA[Free numeric field 6]]>
        public double? FreeNumberField_06 { get; set; }
        ///<![CDATA[Free numeric field 7]]>
        public double? FreeNumberField_07 { get; set; }
        ///<![CDATA[Free numeric field 8]]>
        public double? FreeNumberField_08 { get; set; }
        ///<![CDATA[Free text field 1]]>
        public string FreeTextField_01 { get; set; }
        ///<![CDATA[Free text field 2]]>
        public string FreeTextField_02 { get; set; }
        ///<![CDATA[Free text field 3]]>
        public string FreeTextField_03 { get; set; }
        ///<![CDATA[Free text field 4]]>
        public string FreeTextField_04 { get; set; }
        ///<![CDATA[Free text field 5]]>
        public string FreeTextField_05 { get; set; }
        ///<![CDATA[Free text field 6]]>
        public string FreeTextField_06 { get; set; }
        ///<![CDATA[Free text field 7]]>
        public string FreeTextField_07 { get; set; }
        ///<![CDATA[Free text field 8]]>
        public string FreeTextField_08 { get; set; }
        ///<![CDATA[Free text field 9]]>
        public string FreeTextField_09 { get; set; }
        ///<![CDATA[Free text field 10]]>
        public string FreeTextField_10 { get; set; }
        ///<![CDATA[GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLCosts { get; set; }
        ///<![CDATA[Code of GL account for costs]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }
        ///<![CDATA[Description of GLCosts]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }
        ///<![CDATA[GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLRevenue { get; set; }
        ///<![CDATA[Code of GLRevenue]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }
        ///<![CDATA[Description of GLRevenue]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }
        ///<![CDATA[GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLStock { get; set; }
        ///<![CDATA[Code of GL account for stock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }
        ///<![CDATA[Description of GLStock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }
        ///<![CDATA[Gross weight for international goods shipments]]>
        public double? GrossWeight { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if batches are used for this item]]>
        public byte IsBatchItem { get; set; }
        ///<![CDATA[Used with Batch number feature. Indicates if the item can have a batch number]]>
        public byte IsBatchNumberItem { get; set; }
        ///<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
        public bool? IsFractionAllowedItem { get; set; }
        ///<![CDATA[Indicates that an Item is produced to Inventory, not purchased]]>
        public byte IsMakeItem { get; set; }
        ///<![CDATA[Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package]]>
        public byte IsNewContract { get; set; }
        ///<![CDATA[Is On demand Item]]>
        public byte IsOnDemandItem { get; set; }
        ///<![CDATA[Indicates if the item is a package item. Can only be created in the hosting administration]]>
        public bool? IsPackageItem { get; set; }
        ///<![CDATA[Indicates if the item can be purchased]]>
        public bool? IsPurchaseItem { get; set; }
        ///<![CDATA[Indicated if the item is used in voucher functionality]]>
        public byte IsRegistrationCodeItem { get; set; }
        ///<![CDATA[Indicates if the item can be sold]]>
        public bool? IsSalesItem { get; set; }
        ///<![CDATA[Indicates that serial numbers are used for this item]]>
        public bool? IsSerialItem { get; set; }
        ///<![CDATA[Used with Serial number feature. Indicates if the item can have a serial number]]>
        public bool? IsSerialNumberItem { get; set; }
        ///<![CDATA[If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.]]>
        public bool? IsStockItem { get; set; }
        ///<![CDATA[Indicates if the item is provided by an outside supplier]]>
        public bool? IsSubcontractedItem { get; set; }
        ///<![CDATA[Indicates if tax needs to be calculated for this item]]>
        public byte? IsTaxableItem { get; set; }
        ///<![CDATA[Indicates if the item is a time unit item (for example a labor hour item)]]>
        public byte IsTime { get; set; }
        ///<![CDATA[Indicates if the item can be exported to a web shop]]>
        public byte IsWebshopItem { get; set; }
        ///<![CDATA[GUID of Item group of the item]]>
        public Guid ItemGroup { get; set; }
        ///<![CDATA[Code of ItemGroup]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupCode { get; set; }
        ///<![CDATA[Description of ItemGroup]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Net weight for international goods shipments]]>
        public double? NetWeight { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[File name of picture]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureName { get; set; }
        ///<![CDATA[Url where thumbnail picture can be retrieved]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        ///<![CDATA[Url where picture can be retrieved]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        ///<![CDATA[Code of SalesVat]]>
        public string SalesVatCode { get; set; }
        ///<![CDATA[Description of SalesVatCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVatCodeDescription { get; set; }
        ///<![CDATA[Search code of the item]]>
        public string SearchCode { get; set; }
        ///<![CDATA[Security level (0 - 100)]]>
        public Int32 SecurityLevel { get; set; }
        ///<![CDATA[Together with EndDate this determines if the item is active]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Quantity that is in stock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Stock { get; set; }
        ///<![CDATA[The standard unit of this item]]>
        public string Unit { get; set; }
        ///<![CDATA[Description of Unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemGroup
    {
        ///<![CDATA[Code of the item group]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the item group]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[GL account on which the costs of items of this group will be booked]]>
        public Guid GLCosts { get; set; }
        ///<![CDATA[Code of GLCosts]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }
        ///<![CDATA[Description of GLCosts]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }
        ///<![CDATA[GL Purchase account for purchase invoicing according to (non-) perpetual inventory method]]>
        public Guid GLPurchaseAccount { get; set; }
        ///<![CDATA[Code of GLPurchase]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountCode { get; set; }
        ///<![CDATA[Description of GLPurchaseAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountDescription { get; set; }
        ///<![CDATA[GL account that will be used for the 'Standard cost price' valuation method to balance the difference between purchase price and cost price]]>
        public Guid GLPurchasePriceDifference { get; set; }
        ///<![CDATA[Code of GLPurchasePriceDifference]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceCode { get; set; }
        ///<![CDATA[Description of GLPurchasePriceDifference]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceDescr { get; set; }
        ///<![CDATA[GL account on which the revenue for items of this group will be booked]]>
        public Guid GLRevenue { get; set; }
        ///<![CDATA[Code of GLRevenue]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }
        ///<![CDATA[Description of GLRevenue]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }
        ///<![CDATA[GL account on which stock entries will be booked for items of this group]]>
        public Guid GLStock { get; set; }
        ///<![CDATA[Code of GLStock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }
        ///<![CDATA[Description of GLStock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }
        ///<![CDATA[GL stock variance account for perpetual inventory]]>
        public Guid GLStockVariance { get; set; }
        ///<![CDATA[Code of GLStockVariance]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceCode { get; set; }
        ///<![CDATA[Description of GLStockVariance]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the default item group that will be assigned when a new item is created]]>
        public byte IsDefault { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemVersion
    {
        ///<![CDATA[Batch Quantity of Item Version]]>
        public double? BatchQuantity { get; set; }
        ///<![CDATA[Calculated Cost Price of Item Version]]>
        public double? CalculatedCostPrice { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the item version]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the default item version that will be assigned when a item is selected]]>
        public byte IsDefault { get; set; }
        ///<![CDATA[Reference to Items table]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Lead time of Item version]]>
        public Int32 LeadTime { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Line notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active & 40-Historic]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe]]>
        public Int16 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Version Number]]>
        public Int32 VersionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ItemWarehouse
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[This is a default storage location]]>
        public Guid DefaultStorageLocation { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item ID]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
        public bool? ItemIsFractionAllowedItem { get; set; }
        ///<![CDATA[The standard unit code of this item]]>
        public string ItemUnit { get; set; }
        ///<![CDATA[Description of item's unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnitDescription { get; set; }
        ///<![CDATA[Maximum number of stock could enter warehouse]]>
        public double? MaximumStock { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Reorder point when stock depletes]]>
        public double? ReorderPoint { get; set; }
        ///<![CDATA[Safety stock]]>
        public double? SafetyStock { get; set; }
        ///<![CDATA[Warehouse ID]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Description of warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobGroup
    {
        ///<![CDATA[Job group code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Job group description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobTitle
    {
        ///<![CDATA[Job title code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Job title description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference job code]]>
        public string JobCode { get; set; }
        ///<![CDATA[Group this job title belongs to]]>
        public Guid JobGroup { get; set; }
        ///<![CDATA[Job group code]]>
        public string JobGroupCode { get; set; }
        ///<![CDATA[Job group description]]>
        public string JobGroupDescription { get; set; }
        ///<![CDATA[Job title represents job level from]]>
        public Int32 JobLevelFrom { get; set; }
        ///<![CDATA[Job title represents job level to]]>
        public Int32 JobLevelTo { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Journal
    {
        ///<![CDATA[Indicates if the journal allows variable currency]]>
        public bool? AllowVariableCurrency { get; set; }
        ///<![CDATA[Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed]]>
        public bool? AllowVariableExchangeRate { get; set; }
        ///<![CDATA[Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals]]>
        public bool? AllowVAT { get; set; }
        ///<![CDATA[Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines]]>
        public bool? AutoSave { get; set; }
        ///<![CDATA[Reference to bank account]]>
        public Guid Bank { get; set; }
        ///<![CDATA[BIC code of the bank where the bank account is held]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountBICCode { get; set; }
        ///<![CDATA[Country of bank account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountCountry { get; set; }
        ///<![CDATA[Description of BankAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountDescription { get; set; }
        ///<![CDATA[IBAN of the bank account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountIBAN { get; set; }
        ///<![CDATA[Reference to the Bank Account linked to the Journal]]>
        public Guid BankAccountID { get; set; }
        ///<![CDATA[Bank account number. Is mandatory for Journals that have Type = Bank]]>
        public string BankAccountIncludingMask { get; set; }
        ///<![CDATA[Obsolete. Whether or not use SEPA for the bank account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSEPA { get; set; }
        ///<![CDATA[Obsolete. Whether or not use SEPA direct debit for the bank account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSepaDirectDebit { get; set; }
        ///<![CDATA[Name of bank account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }
        ///<![CDATA[Primary key]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used]]>
        public string Currency { get; set; }
        ///<![CDATA[Description of Currency]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        ///<![CDATA[Name of the Journal]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Suspense general ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Type of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 GLAccountType { get; set; }
        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[General ledger account for payment in transit]]>
        public Guid PaymentInTransitAccount { get; set; }
        ///<![CDATA[Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account]]>
        public string PaymentServiceAccountIdentifier { get; set; }
        ///<![CDATA[Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)]]>
        public Int32 PaymentServiceProvider { get; set; }
        ///<![CDATA[Name of the Payment service provider]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentServiceProviderName { get; set; }
        ///<![CDATA[Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)]]>
        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period,Journal")]
    public class JournalStatus
    {
        ///<![CDATA[Reference to Journal]]>
        public string Journal { get; set; }
        ///<![CDATA[Description of Journal]]>
        public string JournalDescription { get; set; }
        ///<![CDATA[Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal]]>
        public Int32 JournalType { get; set; }
        ///<![CDATA[Description of JournalType]]>
        public string JournalTypeDescription { get; set; }
        ///<![CDATA[Financial period]]>
        public Int32 Period { get; set; }
        ///<![CDATA[Journal status for this year and period 0=open, 1=closed]]>
        public Int32 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        public string StatusDescription { get; set; }
        ///<![CDATA[Financial year]]>
        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Layout
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Layout name]]>
        public string Subject { get; set; }
        ///<![CDATA[Type: 1=Layout, 2=E-mail text layout, 3=Word template]]>
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Mailbox
    {
        ///<![CDATA[The account this mailbox belongs to. Can be empty if the owner of the mailbox isn't an Exact Online customer yet]]>
        public Guid? Account { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Extra description of the mailbox]]>
        public string Description { get; set; }
        ///<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
        public Int32? ForDivision { get; set; }
        ///<![CDATA[Description of ForDivision]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ForDivisionDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
        [JsonProperty(PropertyName = "Mailbox")]
        public string MailboxProperty { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact]]>
        public byte Publish { get; set; }
        ///<![CDATA[Type of mailbox. Exact / Government / Manual]]>
        public Int16? Type { get; set; }
        ///<![CDATA[Date that this mailbox became valid]]>
        public DateTime? ValidFrom { get; set; }
        ///<![CDATA[Date that this mailbox will not be valid anymore]]>
        public DateTime? ValidTo { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessage
    {
        ///<![CDATA[Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public Guid? Bank { get; set; }
        ///<![CDATA[Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public string BankAccount { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public Int32? ForDivision { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Specifies the operation upon dealing with the mailmessage (Kirean scan service)]]>
        public Int16? Operation { get; set; }
        ///<![CDATA[Provides a link to another MailMessage (Kirean scan service)]]>
        public Guid? OriginalMessage { get; set; }
        ///<![CDATA[Subject of the OriginalMessage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OriginalMessageSubject { get; set; }
        ///<![CDATA[The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online]]>
        public Guid? PartnerKey { get; set; }
        ///<![CDATA[Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Reference to the account that is receiving this mailmessage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        ///<![CDATA[Indiciates if the recipient deleted this message. If this is the case the recipient can't see it anymore and the sender can actually delete it]]>
        public byte? RecipientDeleted { get; set; }
        ///<![CDATA[Mailbox of recipient]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailbox { get; set; }
        ///<![CDATA[Mailbox description of recipient]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailboxDescription { get; set; }
        ///<![CDATA[Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox]]>
        public Guid? RecipientMailboxID { get; set; }
        ///<![CDATA[Status of the mail message, only the recipient can update this]]>
        public Int16? RecipientStatus { get; set; }
        ///<![CDATA[Description of RecipientStatus]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientStatusDescription { get; set; }
        ///<![CDATA[Reference to Account of Sender]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        ///<![CDATA[Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)]]>
        public DateTime? SenderDateSent { get; set; }
        ///<![CDATA[Indicates if the sender deleted the message. This means the sender can't see it anymore and the recipient can actually delete it]]>
        public byte SenderDeleted { get; set; }
        ///<![CDATA[IP address of the sender]]>
        public string SenderIPAddress { get; set; }
        ///<![CDATA[Mailbox of sender]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailbox { get; set; }
        ///<![CDATA[Description of SenderMailbox]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailboxDescription { get; set; }
        ///<![CDATA[Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items]]>
        public Guid? SenderMailboxID { get; set; }
        ///<![CDATA[Subject of the mail message]]>
        public string Subject { get; set; }
        ///<![CDATA[Provides a link between Exact Online and the banks]]>
        public string SynchronizationCode { get; set; }
        ///<![CDATA[Type of the mail message]]>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessageAttachment
    {
        ///<![CDATA[For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url]]>
        public byte[] Attachment { get; set; }
        ///<![CDATA[File extension of attachment]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AttachmentFileExtension { get; set; }
        ///<![CDATA[File name of attachment]]>
        public string AttachmentFileName { get; set; }
        ///<![CDATA[File size]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int64? FileSize { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to Mail message]]>
        public Guid MailMessageID { get; set; }
        ///<![CDATA[Reference to recepient account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        ///<![CDATA[Reference to sender account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        ///<![CDATA[Type of mail message attachment]]>
        public Int32? Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[The blob can be downloaded through this url]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ManufacturingTimeTransaction
    {
        ///<![CDATA[Manufacturing time type: Setup = 10, Run = 20]]>
        public Int16 Activity { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Employee linked to the transaction]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Machine hours]]>
        public double? Hours { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Is the operation finished?]]>
        public byte? IsOperationFinished { get; set; }
        ///<![CDATA[Labor Hours on the operation]]>
        public double? LaborHours { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes linked to the time transaction]]>
        public string Notes { get; set; }
        ///<![CDATA[Percentage of the operation that is complete]]>
        public double? PercentComplete { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Routing step linked to the transaction]]>
        public Guid RoutingStepPlan { get; set; }
        ///<![CDATA[Shop order linked to the transaction]]>
        public Guid ShopOrder { get; set; }
        ///<![CDATA[Status of the transaction: Draft = 1, Submitted = 10]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Timed time transaction linked to the transaction]]>
        public Guid TimedTimeTransaction { get; set; }
        ///<![CDATA[Workcenter linked to the transaction]]>
        public Guid WorkCenter { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalanceAfterEntry
    {
        ///<![CDATA[The opening balance amount of the G/L account.]]>
        public double? Amount { get; set; }
        ///<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
        public string BalanceSide { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The balance sheet account.]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }
        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }
        ///<![CDATA[The reporting year of the opening balance.]]>
        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalancePreviousYearAfterEntry
    {
        ///<![CDATA[The opening balance amount of the G/L account.]]>
        public double? Amount { get; set; }
        ///<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
        public string BalanceSide { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The balance sheet account.]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }
        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }
        ///<![CDATA[The reporting year of the opening balance.]]>
        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalanceProcessed
    {
        ///<![CDATA[The opening balance amount of the G/L account.]]>
        public double? Amount { get; set; }
        ///<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
        public string BalanceSide { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The balance sheet account.]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }
        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }
        ///<![CDATA[The reporting year of the opening balance.]]>
        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalancePreviousYearProcessed
    {
        ///<![CDATA[The opening balance amount of the G/L account.]]>
        public double? Amount { get; set; }
        ///<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
        public string BalanceSide { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The balance sheet account.]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }
        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }
        ///<![CDATA[The reporting year of the opening balance.]]>
        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Operation
    {
        ///<![CDATA[Code of the operation]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the operation]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Indicates if the operation has suppliers associated with it]]>
        public byte? HasSuppliers { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to Items table]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Search code for the operation]]>
        public string Searchcode { get; set; }
        ///<![CDATA[Status of the operation]]>
        public Int16 Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class OperationResource
    {
        ///<![CDATA[Reference to Accounts]]>
        public Guid Account { get; set; }
        ///<![CDATA[Attended percentage]]>
        public double? AttendedPercentage { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Reference to Currencies]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Efficiency percentage]]>
        public double? EfficiencyPercentage { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the primary operation of the workcenter]]>
        public byte? IsPrimary { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Reference to Operations]]>
        public Guid Operation { get; set; }
        ///<![CDATA[Description of Operation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }
        ///<![CDATA[Lead days from purchase]]>
        public Int32 PurchaseLeadDays { get; set; }
        ///<![CDATA[Unit of purchased item from supplier]]>
        public string PurchaseUnit { get; set; }
        ///<![CDATA[VAT code used for purchased item from supplier]]>
        public string PurchaseVATCode { get; set; }
        ///<![CDATA[Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours]]>
        public double? Run { get; set; }
        ///<![CDATA[Reference to OperationRunMethods]]>
        public Int16 RunMethod { get; set; }
        ///<![CDATA[Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours]]>
        public double? Setup { get; set; }
        ///<![CDATA[Reference to TimeUnits]]>
        public string SetupUnit { get; set; }
        ///<![CDATA[Reference to RoutingStepTypes]]>
        public Int16 Type { get; set; }
        ///<![CDATA[Reference to Workcenter]]>
        public Guid Workcenter { get; set; }
        ///<![CDATA[Description of Workcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Opportunity
    {
        ///<![CDATA[Lead to which the opportunity applies]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Indicates the date before/on the NextAction is supposed to be done]]>
        public DateTime ActionDate { get; set; }
        ///<![CDATA[Amount in the default currency of the company. AmountDC = AmountFC * RateFC]]>
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to the campaign opportunity is related to]]>
        public Guid Campaign { get; set; }
        ///<![CDATA[Description of Campaign]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CampaignDescription { get; set; }
        ///<![CDATA[The date when the opportunity is expected to be closed]]>
        public DateTime CloseDate { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The source of the lead/opportunity]]>
        public Guid LeadSource { get; set; }
        ///<![CDATA[Description of LeadSource]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LeadSourceDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Name of the opportunity]]>
        public string Name { get; set; }
        ///<![CDATA[Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate]]>
        public string NextAction { get; set; }
        ///<![CDATA[Notes of the opportunity]]>
        public string Notes { get; set; }
        ///<![CDATA[The stage of the opportunity. This is a list defined by the user]]>
        public Guid OpportunityStage { get; set; }
        ///<![CDATA[Description of OpportunityStage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OpportunityStageDescription { get; set; }
        ///<![CDATA[Status: 1=Open, 2=Closed won, 3=Closed lost]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 OpportunityStatus { get; set; }
        ///<![CDATA[The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)]]>
        public Guid Owner { get; set; }
        ///<![CDATA[Name of Owner]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerFullName { get; set; }
        ///<![CDATA[The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage]]>
        public double? Probability { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Exchange rate from original to division currency]]>
        public double? RateFC { get; set; }
        ///<![CDATA[Indicates the reason why the opportunity was lost.]]>
        public Guid ReasonCode { get; set; }
        ///<![CDATA[Description of ReasonCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCodeDescription { get; set; }
        ///<![CDATA[Reference to Sales type]]>
        public Guid SalesType { get; set; }
        ///<![CDATA[Description of SalesType]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class OpportunityContact
    {
        ///<![CDATA[The account to which the contact belongs]]>
        public Guid Account { get; set; }
        ///<![CDATA[Indicates if account is a customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }
        ///<![CDATA[Indicates if account is a supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        ///<![CDATA[Reference to the main contact of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid AccountMainContact { get; set; }
        ///<![CDATA[Name of the account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Second address line]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }
        ///<![CDATA[Street name of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }
        ///<![CDATA[Street number of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }
        ///<![CDATA[Street number suffix of the address]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AllowMailing { get; set; }
        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }
        ///<![CDATA[Last birth name]]>
        public string BirthName { get; set; }
        ///<![CDATA[Middle birth name]]>
        public string BirthNamePrefix { get; set; }
        ///<![CDATA[Birth place]]>
        public string BirthPlace { get; set; }
        ///<![CDATA[Email address of the contact]]>
        public string BusinessEmail { get; set; }
        ///<![CDATA[Fax of the contact]]>
        public string BusinessFax { get; set; }
        ///<![CDATA[Mobile of the contact]]>
        public string BusinessMobile { get; set; }
        ///<![CDATA[Phone of the contact]]>
        public string BusinessPhone { get; set; }
        ///<![CDATA[Phone extension of the contact]]>
        public string BusinessPhoneExtension { get; set; }
        ///<![CDATA[City]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }
        ///<![CDATA[Code of the account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }
        ///<![CDATA[Contact person that is linked to the opportunity]]>
        public Guid Contact { get; set; }
        ///<![CDATA[Country code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Email address of the contact]]>
        public string Email { get; set; }
        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
        public string FirstName { get; set; }
        ///<![CDATA[Full name (First name Middle name Last name)]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }
        ///<![CDATA[Gender]]>
        public string Gender { get; set; }
        ///<![CDATA[Contact ID]]>
        public Int32 HID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Identification date]]>
        public DateTime IdentificationDate { get; set; }
        ///<![CDATA[Reference to the identification document of the contact]]>
        public Guid IdentificationDocument { get; set; }
        ///<![CDATA[Reference to the user responsible for identification]]>
        public Guid IdentificationUser { get; set; }
        ///<![CDATA[Initials]]>
        public string Initials { get; set; }
        ///<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
        public bool? IsMailingExcluded { get; set; }
        ///<![CDATA[Indicates if this is the main contact of the linked account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }
        ///<![CDATA[Jobtitle of the contact]]>
        public string JobTitleDescription { get; set; }
        ///<![CDATA[Language code]]>
        public string Language { get; set; }
        ///<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
        public string LastName { get; set; }
        ///<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
        public string MarketingNotes { get; set; }
        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }
        ///<![CDATA[Business phone of the contact]]>
        public string Mobile { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Opportunity that is linked to the contact person]]>
        public Guid Opportunity { get; set; }
        ///<![CDATA[Last name of partner]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }
        ///<![CDATA[Middlename of partner]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }
        ///<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
        public Guid Person { get; set; }
        ///<![CDATA[Phone of the contact]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone extension of the contact]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }
        ///<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
        public byte[] Picture { get; set; }
        ///<![CDATA[Filename of the picture]]>
        public string PictureName { get; set; }
        ///<![CDATA[Url to retrieve the picture thumbnail]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        ///<![CDATA[Url to retrieve the picture]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        ///<![CDATA[Postcode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }
        ///<![CDATA[Social security number]]>
        public string SocialSecurityNumber { get; set; }
        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[State]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }
        ///<![CDATA[Title]]>
        public string Title { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrencyCode")]
    public class OutstandingInvoiceOverview
    {
        ///<![CDATA[Primary key]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Total invoice amount to be paid]]>
        public double OutstandingPayableInvoiceAmount { get; set; }
        ///<![CDATA[Number of invoices to be paid]]>
        public double OutstandingPayableInvoiceCount { get; set; }
        ///<![CDATA[Total invoice amount to be received]]>
        public double OutstandingReceivableInvoiceAmount { get; set; }
        ///<![CDATA[Number of invoices to be received]]>
        public double OutstandingReceivableInvoiceCount { get; set; }
        ///<![CDATA[Total payable invoice amount that is overdue]]>
        public double OverduePayableInvoiceAmount { get; set; }
        ///<![CDATA[Number of payable invoices that are overdue]]>
        public double OverduePayableInvoiceCount { get; set; }
        ///<![CDATA[Total receivable invoice amount that is overdue]]>
        public double OverdueReceivableInvoiceAmount { get; set; }
        ///<![CDATA[Number of receivable invoices that are overdue]]>
        public double OverdueReceivableInvoiceCount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class Payable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Reference to the account]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Amount]]>
        public double Amount { get; set; }
        ///<![CDATA[Amount in transit]]>
        public double AmountInTransit { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Date the invoice should be paid]]>
        public DateTime DueDate { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Primary key, human readable ID]]>
        public Int64 HID { get; set; }
        ///<![CDATA[Obsolete]]>
        public Guid Id { get; set; }
        ///<![CDATA[Invoice date]]>
        public DateTime InvoiceDate { get; set; }
        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        public string JournalDescription { get; set; }
        ///<![CDATA[Your reference]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PaymentCondition
    {
        ///<![CDATA[Code of the payment condition]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Default credit management scenario to be used for new payment terms]]>
        public Guid CreditManagementScenario { get; set; }
        ///<![CDATA[Code of CreditManagementScenario]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioCode { get; set; }
        ///<![CDATA[Description of CreditManagementScenario]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioDescription { get; set; }
        ///<![CDATA[Description of the payment condition]]>
        public string Description { get; set; }
        ///<![CDATA[Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT]]>
        public string DiscountCalculation { get; set; }
        ///<![CDATA[Number of days to pay within, to have the right to take the discount]]>
        public Int32 DiscountPaymentDays { get; set; }
        ///<![CDATA[Discount percentage]]>
        public double? DiscountPercentage { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 => 31/03 PaymentDays = 15 => 15/04]]>
        public Int32 PaymentDays { get; set; }
        ///<![CDATA[Type of payment discount. Values: B = Settlement discount, K = Credit surcharge]]>
        public string PaymentDiscountType { get; set; }
        ///<![CDATA[Number of month endings to be included in the due date calculation]]>
        public Int32 PaymentEndOfMonths { get; set; }
        ///<![CDATA[Method of payment. Values: B = On credit, I = Collection, K = Cash]]>
        public string PaymentMethod { get; set; }
        ///<![CDATA[Percentage (stored as fraction) of total invoice amount]]>
        public double? Percentage { get; set; }
        ///<![CDATA[Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount]]>
        public string VATCalculation { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period")]
    public class PeriodRevenue
    {
        ///<![CDATA[Total amount in the default currency of the company]]>
        public double Amount { get; set; }
        ///<![CDATA[Reporting period]]>
        public Int32 Period { get; set; }
        ///<![CDATA[Reporting year]]>
        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PriceList
    {
        ///<![CDATA[Code to indicate the price list]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[All prices in the price list are stored in this currency]]>
        public string Currency { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Description of Division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }
        ///<![CDATA[Indicates the entity (Item, Item group, ..) on which this price list is based]]>
        public Int16 Entity { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class PrintedQuotation
    {
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the id of the document that was created]]>
        public Guid Document { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
        public string DocumentCreationError { get; set; }
        ///<![CDATA[Contains information if a document was successfully created]]>
        public string DocumentCreationSuccess { get; set; }
        ///<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.]]>
        public Guid DocumentLayout { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the Email]]>
        public string EmailCreationError { get; set; }
        ///<![CDATA[Based on this layout the email text is produced. In case it is not specified, the default layout is used.]]>
        public Guid EmailLayout { get; set; }
        ///<![CDATA[Extra text that can be added to the printed document and email]]>
        public string ExtraText { get; set; }
        ///<![CDATA[Date of the quotation printed]]>
        public DateTime QuotationDate { get; set; }
        ///<![CDATA[Identifier of the quotation]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Set to True if an email containing the quotation should be sent to the customer]]>
        public bool SendEmailToCustomer { get; set; }
        ///<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
        public string SenderEmailAddress { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("InvoiceID")]
    public class PrintedSalesInvoice
    {
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the id of the document that was created]]>
        public Guid Document { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
        public string DocumentCreationError { get; set; }
        ///<![CDATA[Contains information if a document was succesfully created]]>
        public string DocumentCreationSuccess { get; set; }
        ///<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
        public Guid DocumentLayout { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
        public string EmailCreationError { get; set; }
        ///<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
        public string EmailCreationSuccess { get; set; }
        ///<![CDATA[Based on this layout the email text is produced]]>
        public Guid EmailLayout { get; set; }
        ///<![CDATA[Extra text that can be added to the printed document and email]]>
        public string ExtraText { get; set; }
        ///<![CDATA[Date of the invoice]]>
        public DateTime InvoiceDate { get; set; }
        ///<![CDATA[Primary key, Reference to EntryID of SalesInvoice]]>
        public Guid InvoiceID { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the sending of a postbox message]]>
        public string PostboxMessageCreationError { get; set; }
        ///<![CDATA[Contains information if a postbox message was succesfully sent]]>
        public string PostboxMessageCreationSuccess { get; set; }
        ///<![CDATA[The postbox from where the message is sent]]>
        public Guid PostboxSender { get; set; }
        ///<![CDATA[Reporting period]]>
        public Int32 ReportingPeriod { get; set; }
        ///<![CDATA[Reporting year]]>
        public Int32 ReportingYear { get; set; }
        ///<![CDATA[Set to True if an email containing the invoice should be sent to the invoice customer]]>
        public bool? SendEmailToCustomer { get; set; }
        ///<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
        public string SenderEmailAddress { get; set; }
        ///<![CDATA[Set to True if a postbox message containing the invoice should be sent to the invoice customer]]>
        public bool? SendInvoiceToCustomerPostbox { get; set; }
        ///<![CDATA[Set to True if the output preference should be taken from the account. It will be either Paper, Email, Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.]]>
        public bool? SendOutputBasedOnAccount { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("OrderId")]
    public class PrintedSalesOrder
    {
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the id of the document that was created]]>
        public Guid Document { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
        public string DocumentCreationError { get; set; }
        ///<![CDATA[Contains information if a document was succesfully created]]>
        public string DocumentCreationSuccess { get; set; }
        ///<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
        public Guid DocumentLayout { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
        public string EmailCreationError { get; set; }
        ///<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
        public string EmailCreationSuccess { get; set; }
        ///<![CDATA[Based on this layout the email text is produced]]>
        public Guid EmailLayout { get; set; }
        ///<![CDATA[Extra text that can be added to the printed document and email]]>
        public string ExtraText { get; set; }
        ///<![CDATA[Primary key, Reference to OrderID of SalesOrder]]>
        public Guid OrderId { get; set; }
        ///<![CDATA[Set to True if an email containing the sales order should be sent to the customer]]>
        public bool? SendEmailToCustomer { get; set; }
        ///<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
        public string SenderEmailAddress { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProductionArea
    {
        ///<![CDATA[Code of the production area group]]>
        public string Code { get; set; }
        ///<![CDATA[Reference to Cost center]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Reference to Cost unit]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the production area]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the default production area. This will be used when creating a new production area]]>
        public byte IsDefault { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Production area notes]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrentYear")]
    public class ProfitLossOverview
    {
        ///<![CDATA[Costs in current period]]>
        public double CostsCurrentPeriod { get; set; }
        ///<![CDATA[Costs in current year]]>
        public double CostsCurrentYear { get; set; }
        ///<![CDATA[Costs in previous year]]>
        public double CostsPreviousYear { get; set; }
        ///<![CDATA[Costs in period of previous year]]>
        public double CostsPreviousYearPeriod { get; set; }
        ///<![CDATA[Currency code]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Current period]]>
        public Int32 CurrentPeriod { get; set; }
        ///<![CDATA[Primary key, Current year]]>
        public Int32 CurrentYear { get; set; }
        ///<![CDATA[Previous year]]>
        public Int32 PreviousYear { get; set; }
        ///<![CDATA[Period in previous year]]>
        public Int32 PreviousYearPeriod { get; set; }
        ///<![CDATA[Results of current period]]>
        public double ResultCurrentPeriod { get; set; }
        public double ResultCurrentYear { get; set; }
        public double ResultPreviousYear { get; set; }
        ///<![CDATA[Results of period in previous year]]>
        public double ResultPreviousYearPeriod { get; set; }
        ///<![CDATA[Revenue in current period]]>
        public double RevenueCurrentPeriod { get; set; }
        ///<![CDATA[Revenue in current year]]>
        public double RevenueCurrentYear { get; set; }
        ///<![CDATA[Revenue in previous year]]>
        public double RevenuePreviousYear { get; set; }
        ///<![CDATA[Revenue in period of previous year]]>
        public double RevenuePreviousYearPeriod { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Project
    {
        ///<![CDATA[The account for this project]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Contact person of Account]]>
        public Guid AccountContact { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Is additional invoice is allowed for project]]>
        public bool? AllowAdditionalInvoicing { get; set; }
        ///<![CDATA[Block time and cost entries]]>
        public bool? BlockEntry { get; set; }
        ///<![CDATA[Block rebilling]]>
        public bool? BlockRebilling { get; set; }
        ///<![CDATA[Budgeted amount of sales in the default currency of the company]]>
        public double? BudgetedAmount { get; set; }
        ///<![CDATA[Budgeted amount of costs in the default currency of the company]]>
        public double? BudgetedCosts { get; set; }
        ///<![CDATA[Collection of budgeted hours]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectHourBudget> BudgetedHoursPerHourType { get; set; }
        ///<![CDATA[Budgeted amount of revenue in the default currency of the company]]>
        public double? BudgetedRevenue { get; set; }
        ///<![CDATA[Budget type]]>
        public Int16 BudgetType { get; set; }
        ///<![CDATA[Budget type description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetTypeDescription { get; set; }
        ///<![CDATA[Used only for PSA to link a project classification to the project]]>
        public Guid Classification { get; set; }
        ///<![CDATA[Description of Classification]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        ///<![CDATA[Code]]>
        public string Code { get; set; }
        ///<![CDATA[Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostsAmountFC { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Used only for PSA to store the customer's PO number]]>
        public string CustomerPOnumber { get; set; }
        ///<![CDATA[Description of the project]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Name of Division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionName { get; set; }
        ///<![CDATA[End date of the project. In combination with the start date the status is determined]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting]]>
        public Guid FixedPriceItem { get; set; }
        ///<![CDATA[Description of FixedPriceItem]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FixedPriceItemDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Is invoice as quoted]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool InvoiceAsQuoted { get; set; }
        ///<![CDATA[Collection of invoice terms]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectTerm> InvoiceTerms { get; set; }
        ///<![CDATA[Responsible person for this project]]>
        public Guid Manager { get; set; }
        ///<![CDATA[Name of Manager]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ManagerFullname { get; set; }
        ///<![CDATA[Purchase markup percentage]]>
        public double? MarkupPercentage { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[For additional information about projects]]>
        public string Notes { get; set; }
        ///<![CDATA[Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting]]>
        public Guid PrepaidItem { get; set; }
        ///<![CDATA[Description of PrepaidItem]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidItemDescription { get; set; }
        ///<![CDATA[Reference to ProjectPrepaidTypes]]>
        public Int16 PrepaidType { get; set; }
        ///<![CDATA[Description of PrepaidType]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidTypeDescription { get; set; }
        ///<![CDATA[Collection of employee restrictions]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionEmployee> ProjectRestrictionEmployees { get; set; }
        ///<![CDATA[Collection of item restrictions]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionItem> ProjectRestrictionItems { get; set; }
        ///<![CDATA[Collection of rebilling restrictions]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionRebilling> ProjectRestrictionRebillings { get; set; }
        ///<![CDATA[Budgeted time. Total number of hours estimated for the fixed price project]]>
        public double? SalesTimeQuantity { get; set; }
        ///<![CDATA[Source quotation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SourceQuotation { get; set; }
        ///<![CDATA[Start date of a project. In combination with the end date the status is determined]]>
        public DateTime StartDate { get; set; }
        public double? TimeQuantityToAlert { get; set; }
        ///<![CDATA[Reference to ProjectTypes]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Using billing milestones]]>
        public bool? UseBillingMilestones { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ProjectBudgetType
    {
        ///<![CDATA[Description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectHourBudget
    {
        ///<![CDATA[Number of hours]]>
        public double? Budget { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Hour type of budget]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of hour type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of hour type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionEmployee
    {
        ///<![CDATA[Date created]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Creator user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Creator name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Employee linked to the restriction]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Readable ID of the employee]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Date modified]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Modifier user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Modifier name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Project linked to the restriction]]>
        public Guid Project { get; set; }
        ///<![CDATA[Project code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Project description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionItem
    {
        ///<![CDATA[Date created]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Creator user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Creator name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item linked to the restriction]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of the item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates if the item is a time unit item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? ItemIsTime { get; set; }
        ///<![CDATA[Date modified]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Modifier user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Modifier name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Project linked to the restriction]]>
        public Guid Project { get; set; }
        ///<![CDATA[Project code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Project description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionRebilling
    {
        ///<![CDATA[Cost type reference]]>
        public Guid CostTypeRebill { get; set; }
        ///<![CDATA[Cost type code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillCode { get; set; }
        ///<![CDATA[Cost type description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillDescription { get; set; }
        ///<![CDATA[Date created]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Creator user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Creator name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Date modified]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Modifier user ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Modifier name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Project linked to the restriction]]>
        public Guid Project { get; set; }
        ///<![CDATA[Project code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Project description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectTerm
    {
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[WBS's deliverable linked to invoice term]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Deliverable { get; set; }
        ///<![CDATA[Description of invoice term]]>
        public string Description { get; set; }
        ///<![CDATA[Division number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Invoice date]]>
        public DateTime InvoiceDate { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Percentage of amount per project's budgeted amount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Reference to VATCode]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[VATCode percentage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class PurchaseEntry
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        ///<![CDATA[Batch number]]>
        public Int32 BatchNumber { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to document]]>
        public Guid? Document { get; set; }
        ///<![CDATA[Document number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Document subject]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Date when payment should be done]]>
        public DateTime? DueDate { get; set; }
        ///<![CDATA[Entry date]]>
        public DateTime? EntryDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Description of ExternalLink]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }
        public string ExternalLinkReference { get; set; }
        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Journal]]>
        public string Journal { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Order number]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[Payment condition]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        public Int32 ProcessNumber { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<PurchaseEntryLine> PurchaseEntryLines { get; set; }
        ///<![CDATA[Currency exchange rate]]>
        public double? Rate { get; set; }
        ///<![CDATA[Reporting period]]>
        public Int16 ReportingPeriod { get; set; }
        ///<![CDATA[Reporting year]]>
        public Int16 ReportingYear { get; set; }
        ///<![CDATA[Indicates that amounts are reversed]]>
        public bool? Reversal { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Reference to supplier (account)]]>
        public Guid? Supplier { get; set; }
        ///<![CDATA[Name of supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        ///<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Vat Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        ///<![CDATA[Vat Amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[Your reference]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseEntryLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Asset description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to header of the purchase entry]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Serial number]]>
        public string SerialNumber { get; set; }
        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of Subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Reference to tracking number]]>
        public Guid TrackingNumber { get; set; }
        ///<![CDATA[Description of TrackingNumber]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }
        ///<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        ///<![CDATA[VAT amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        ///<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[VAT base amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }
        ///<![CDATA[VAT base amount in the currency of the transaction]]>
        public double? VATBaseAmountFC { get; set; }
        ///<![CDATA[VAT code]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[VAT percentage]]>
        public double? VATPercentage { get; set; }
        ///<![CDATA[Withholding tax amount for spanish legislation]]>
        public double? WithholdingAmountDC { get; set; }
        ///<![CDATA[Withholding tax key for spanish legislation]]>
        public string WithholdingTax { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("PurchaseOrderID")]
    public class PurchaseOrder
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Reference to account for delivery]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAccount { get; set; }
        ///<![CDATA[Delivery account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        ///<![CDATA[Account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        ///<![CDATA[Reference to shipping address]]>
        public Guid DeliveryAddress { get; set; }
        ///<![CDATA[Reference to contact for delivery]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid DeliveryContact { get; set; }
        ///<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        ///<![CDATA[Description of the purchase order]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Document that is manually linked to the purchase order]]>
        public Guid Document { get; set; }
        ///<![CDATA[Subject of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Shows if it is a drop shipment purchase order]]>
        public bool? DropShipment { get; set; }
        ///<![CDATA[Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.]]>
        public double? ExchangeRate { get; set; }
        ///<![CDATA[Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 InvoiceStatus { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Order date]]>
        public DateTime OrderDate { get; set; }
        ///<![CDATA[Human readable id of the purchase order]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 OrderStatus { get; set; }
        ///<![CDATA[The payment condition code used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of payment condition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid PurchaseOrderID { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        ///<![CDATA[This field shows the date the goods are expected to be received.]]>
        public DateTime ReceiptDate { get; set; }
        ///<![CDATA[Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ReceiptStatus { get; set; }
        ///<![CDATA[Include any relevant remarks regarding the purchase order.]]>
        public string Remarks { get; set; }
        ///<![CDATA[Reference to sales order when purchase order generated via back to back sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }
        ///<![CDATA[Number of sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }
        ///<![CDATA[This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier's items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }
        ///<![CDATA[Reference to supplier account]]>
        public Guid Supplier { get; set; }
        ///<![CDATA[Code of supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        ///<![CDATA[Contact of supplier]]>
        public Guid SupplierContact { get; set; }
        ///<![CDATA[Contact person full name of supplier]]>
        public string SupplierContactPersonFullName { get; set; }
        ///<![CDATA[Name of supplier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        ///<![CDATA[Warehouse]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Code of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        ///<![CDATA[Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PurchaseOrderLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of sales order delivery]]>
        public string Description { get; set; }
        ///<![CDATA[Discount in percentage for item]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InStock { get; set; }
        ///<![CDATA[Quantity of item that has been invoiced]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InvoicedQuantity { get; set; }
        ///<![CDATA[Reference to the item for purchase order]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The net price is the unit price (VAT code taken into account) with any discount applied]]>
        public double? NetPrice { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ProjectedStock { get; set; }
        ///<![CDATA[Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID]]>
        public Guid PurchaseOrderID { get; set; }
        ///<![CDATA[Quantity for the item that needs to be invoiced]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Date the goods are expected to be received]]>
        public DateTime ReceiptDate { get; set; }
        ///<![CDATA[Quantity of goods received]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ReceivedQuantity { get; set; }
        ///<![CDATA[Sales order that is linked to a back to back sales order in purchase order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }
        ///<![CDATA[Number of sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }
        ///<![CDATA[Code the supplier uses for this item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }
        ///<![CDATA[Code of item unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        ///<![CDATA[Description of unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Item price per unit]]>
        public double? UnitPrice { get; set; }
        ///<![CDATA[Amount of VAT charges calculated from total amount and vat percentage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        ///<![CDATA[The VAT code used when the invoice was registered]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of vat code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        ///<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("QuotationID")]
    public class Quotation
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        ///<![CDATA[Date on which the customer accepted or rejected the quotation version]]>
        public DateTime CloseDate { get; set; }
        ///<![CDATA[Date and time on which the quotation was created]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[The currency of the quotation]]>
        public string Currency { get; set; }
        ///<![CDATA[The account where the items should delivered]]>
        public Guid DeliveryAccount { get; set; }
        ///<![CDATA[The code of the delivery account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        ///<![CDATA[The contact person of the delivery account]]>
        public Guid DeliveryAccountContact { get; set; }
        ///<![CDATA[Full name of the delivery account contact person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountContactFullName { get; set; }
        ///<![CDATA[The name of the delivery account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        ///<![CDATA[The id of the delivery address]]>
        public Guid DeliveryAddress { get; set; }
        ///<![CDATA[The description of the quotation]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[The account to which the invoice is sent]]>
        public Guid InvoiceAccount { get; set; }
        ///<![CDATA[The code of the invoice account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }
        ///<![CDATA[The contact person of the invoice account]]>
        public Guid InvoiceAccountContact { get; set; }
        ///<![CDATA[Full name of the invoice account contact person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountContactFullName { get; set; }
        ///<![CDATA[The name of the invoice account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }
        ///<![CDATA[Date and time on which the quotation was last modified]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The account that requested the quotation]]>
        public Guid OrderAccount { get; set; }
        ///<![CDATA[The code of the order account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountCode { get; set; }
        ///<![CDATA[The contact person of the order account]]>
        public Guid OrderAccountContact { get; set; }
        ///<![CDATA[Full name of the order account contact person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountContactFullName { get; set; }
        ///<![CDATA[The name of the order account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountName { get; set; }
        ///<![CDATA[Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted]]>
        public DateTime QuotationDate { get; set; }
        ///<![CDATA[Identifier of the quotation]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[The collection of quotation lines]]>
        public IEnumerable<QuotationLine> QuotationLines { get; set; }
        ///<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
        public Int32 QuotationNumber { get; set; }
        ///<![CDATA[Extra text that can be added to the quotation]]>
        public string Remarks { get; set; }
        ///<![CDATA[The user that is responsible for the quotation version]]>
        public Guid SalesPerson { get; set; }
        ///<![CDATA[Full name of the sales person]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesPersonFullName { get; set; }
        ///<![CDATA[The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[The description of the status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Total VAT amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        ///<![CDATA[Number indicating the different reviews which are made for the quotation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }
        ///<![CDATA[The number by which this quotation is identified by the order account]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class QuotationLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        ///<![CDATA[By default this contains the item description]]>
        public string Description { get; set; }
        ///<![CDATA[Discount given on the default price]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to the item that is sold in this quotation line]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of the item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates the sequence of the lines within one quotation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Net price of the quotation line]]>
        public double? NetPrice { get; set; }
        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }
        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Identifies the quotation. All the lines of a quotation have the same QuotationID]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 QuotationNumber { get; set; }
        ///<![CDATA[Code of the item unit]]>
        public string UnitCode { get; set; }
        ///<![CDATA[Description of the item unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Price per item unit]]>
        public double? UnitPrice { get; set; }
        ///<![CDATA[VAT amount of the line in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        ///<![CDATA[The VAT code that is used when the quotation is invoiced]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of the VAT code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        ///<![CDATA[The VAT percentage of the VAT code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
        ///<![CDATA[Number indicating the different reviews which are made for the quotation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReasonCode
    {
        ///<![CDATA[Indicates if the reason code is active.]]>
        public byte? Active { get; set; }
        ///<![CDATA[Code of the reason.]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date.]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator.]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the reason code.]]>
        public string Description { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key.]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date.]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier.]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier.]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra notes.]]>
        public string Notes { get; set; }
        ///<![CDATA[Type of the reason code.]]>
        public Int16 Type { get; set; }
        ///<![CDATA[Description of the type of the reason code.]]>
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class Receivable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Reference to the account]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Amount]]>
        public double Amount { get; set; }
        ///<![CDATA[Amount in transit]]>
        public double AmountInTransit { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Date the invoice should be paid]]>
        public DateTime DueDate { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Primary key, human readable ID]]>
        public Int64 HID { get; set; }
        ///<![CDATA[Obsolete]]>
        public Guid Id { get; set; }
        ///<![CDATA[Invoice date]]>
        public DateTime InvoiceDate { get; set; }
        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        public string JournalDescription { get; set; }
        ///<![CDATA[Your reference]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentCosts
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Reference to Account]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Amount approved]]>
        public double AmountApproved { get; set; }
        ///<![CDATA[Amount draft]]>
        public double AmountDraft { get; set; }
        ///<![CDATA[Amount rejected]]>
        public double AmountRejected { get; set; }
        ///<![CDATA[Amount submitted]]>
        public double AmountSubmitted { get; set; }
        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Entry ID]]>
        public Guid EntryId { get; set; }
        ///<![CDATA[Reference to Expense]]>
        public Guid Expense { get; set; }
        ///<![CDATA[Description of Expense]]>
        public string ExpenseDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 Id { get; set; }
        ///<![CDATA[Code of Item]]>
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        public string ItemDescription { get; set; }
        ///<![CDATA[Reference to Item]]>
        public Guid ItemId { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Code of Project]]>
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        public string ProjectDescription { get; set; }
        ///<![CDATA[Reference to Project]]>
        public Guid ProjectId { get; set; }
        ///<![CDATA[Quantity approved]]>
        public double QuantityApproved { get; set; }
        ///<![CDATA[Quantity draft]]>
        public double QuantityDraft { get; set; }
        ///<![CDATA[Quantity rejected]]>
        public double QuantityRejected { get; set; }
        ///<![CDATA[Quantity submitted]]>
        public double QuantitySubmitted { get; set; }
        ///<![CDATA[Week number]]>
        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentHours
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }
        ///<![CDATA[Reference to Account]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Reference to Activity]]>
        public Guid Activity { get; set; }
        ///<![CDATA[Description of Activity]]>
        public string ActivityDescription { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Entry ID]]>
        public Guid EntryId { get; set; }
        ///<![CDATA[Hours approved]]>
        public double HoursApproved { get; set; }
        ///<![CDATA[Billable hours approved]]>
        public double HoursApprovedBillable { get; set; }
        ///<![CDATA[Hours draft]]>
        public double HoursDraft { get; set; }
        ///<![CDATA[Billable hours draft]]>
        public double HoursDraftBillable { get; set; }
        ///<![CDATA[Hours rejected]]>
        public double HoursRejected { get; set; }
        ///<![CDATA[Billable hours rejected]]>
        public double HoursRejectedBillable { get; set; }
        ///<![CDATA[Hours submitted]]>
        public double HoursSubmitted { get; set; }
        ///<![CDATA[Billable hours submitted]]>
        public double HoursSubmittedBillable { get; set; }
        ///<![CDATA[Primary key]]>
        public Int32 Id { get; set; }
        ///<![CDATA[Code of Item]]>
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        public string ItemDescription { get; set; }
        ///<![CDATA[Reference to Item]]>
        public Guid ItemId { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Code of Project]]>
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        public string ProjectDescription { get; set; }
        ///<![CDATA[Reference to Project]]>
        public Guid ProjectId { get; set; }
        ///<![CDATA[Week number]]>
        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class RejectedQuotation
    {
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the rejection of the quotation.]]>
        public string ErrorMessage { get; set; }
        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Reason why the quotation was rejected.]]>
        public Guid ReasonCode { get; set; }
        ///<![CDATA[Contains information if the quotation was successfully rejected.]]>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReopenedQuotation
    {
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the reopening of the quotation.]]>
        public string ErrorMessage { get; set; }
        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Contains information if the quotation was successfully reopened.]]>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReportingBalance
    {
        ///<![CDATA[The sum of the amounts of all transactions in the grouping.]]>
        public double? Amount { get; set; }
        ///<![CDATA[The sum of the amounts of all credit transactions in the grouping.]]>
        public double? AmountCredit { get; set; }
        ///<![CDATA[The sum of the amounts of all debit transactions in the grouping.]]>
        public double? AmountDebit { get; set; }
        ///<![CDATA[Balance type of the G/L account: B = Balance Sheet, W = Profit & Loss.]]>
        public string BalanceType { get; set; }
        ///<![CDATA[The code of the cost center.]]>
        public string CostCenterCode { get; set; }
        ///<![CDATA[The description of the cost center.]]>
        public string CostCenterDescription { get; set; }
        ///<![CDATA[The code of the cost unit.]]>
        public string CostUnitCode { get; set; }
        ///<![CDATA[The description of the cost unit.]]>
        public string CostUnitDescription { get; set; }
        ///<![CDATA[The number of transactions in the grouping.]]>
        public Int32 Count { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[G/L account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }
        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Record ID]]>
        public Int64 ID { get; set; }
        ///<![CDATA[The reporting period of the transactions in the grouping.]]>
        public Int32 ReportingPeriod { get; set; }
        ///<![CDATA[The reporting year of the transactions in the grouping.]]>
        public Int32 ReportingYear { get; set; }
        ///<![CDATA[Status: 20 = Open, 50 = Processed. To get 'after entry' results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.]]>
        public Int32 Status { get; set; }
        ///<![CDATA[The type of the transactions in the grouping.]]>
        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReviewedQuotation
    {
        ///<![CDATA[Indicates if the item prices should be copied from the original quotation or the default item prices should be used.]]>
        public bool? CopyItemPrices { get; set; }
        ///<![CDATA[The description of the new quotation.]]>
        public string Description { get; set; }
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The document linked to the new quotation.]]>
        public Guid Document { get; set; }
        ///<![CDATA[Contains the error message if an error occurred during the reviewing of the quotation.]]>
        public string ErrorMessage { get; set; }
        ///<![CDATA[Identifier of the newly created quotation.]]>
        public Guid NewQuotationID { get; set; }
        ///<![CDATA[The account who made the order.]]>
        public Guid OrderAccount { get; set; }
        ///<![CDATA[The contact person of the account who made the order.]]>
        public Guid OrderAccountContact { get; set; }
        ///<![CDATA[The paymentcondition linked to the new quotation.]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[The date of the new quotation.]]>
        public DateTime QuotationDate { get; set; }
        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }
        ///<![CDATA[Contains information if the quotation was successfully reviewed.]]>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class SalesEntry
    {
        ///<![CDATA[Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        ///<![CDATA[The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)]]>
        public Int32 BatchNumber { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency for the invoice. By default this is the currency of the administration]]>
        public string Currency { get; set; }
        ///<![CDATA[Reference to customer (account)]]>
        public Guid? Customer { get; set; }
        ///<![CDATA[Name of customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }
        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Document that is manually linked to the invoice]]>
        public Guid? Document { get; set; }
        ///<![CDATA[Number of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
        public DateTime? DueDate { get; set; }
        ///<![CDATA[The date when the invoice is entered]]>
        public DateTime? EntryDate { get; set; }
        ///<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Description of ExternalLink]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }
        ///<![CDATA[Reference of ExternalLink]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkReference { get; set; }
        ///<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Indicates whether the invoice has extra duty]]>
        public bool? IsExtraDuty { get; set; }
        ///<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
        public string Journal { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
        public string PaymentReference { get; set; }
        public Int32 ProcessNumber { get; set; }
        ///<![CDATA[Foreign currency rate]]>
        public double? Rate { get; set; }
        ///<![CDATA[The period of the transaction lines. The period should exist in the period date table]]>
        public Int16 ReportingPeriod { get; set; }
        ///<![CDATA[The financial year to which the entry belongs. The financial year should exist in the period date table]]>
        public Int16 ReportingYear { get; set; }
        ///<![CDATA[Indicates if amounts are reversed]]>
        public bool? Reversal { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesEntryLine> SalesEntryLines { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        ///<![CDATA[Description of Type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Vat amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[The invoice number of the customer]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesEntryLine
    {
        ///<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[For normal lines it's the amount excluding VAT]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to Asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Description of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
        public double? ExtraDutyAmountFC { get; set; }
        ///<![CDATA[Extra duty percentage for the item]]>
        public double? ExtraDutyPercentage { get; set; }
        ///<![CDATA[The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates the sequence of the lines within one entry]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }
        ///<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Serial number]]>
        public string SerialNumber { get; set; }
        ///<![CDATA[When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of Subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Reference to TrackingNumber]]>
        public Guid TrackingNumber { get; set; }
        ///<![CDATA[Description of TrackingNumber]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }
        ///<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        ///<![CDATA[VAT amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        ///<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. ]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC]]>
        public double? VATBaseAmountDC { get; set; }
        ///<![CDATA[The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It's an internal value]]>
        public double? VATBaseAmountFC { get; set; }
        ///<![CDATA[The VAT code used when the invoice was registered]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("InvoiceID")]
    public class SalesInvoice
    {
        ///<![CDATA[For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[For the header this is the sum of all lines, including VAT]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency for the invoice. Default this is the currency of the administration]]>
        public string Currency { get; set; }
        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Document that is manually linked to the invoice]]>
        public Guid Document { get; set; }
        ///<![CDATA[Number of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
        public DateTime DueDate { get; set; }
        ///<![CDATA[Official date for the invoice. When the invoice is entered it's equal to the field 'EntryDate'. During the printing process the invoice date can be entered]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime InvoiceDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid InvoiceID { get; set; }
        ///<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Reference to the Customer who will receive the invoice]]>
        public Guid InvoiceTo { get; set; }
        ///<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
        public Guid InvoiceToContactPerson { get; set; }
        ///<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        ///<![CDATA[Name of the customer who will receive the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        ///<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
        public string Journal { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Order date]]>
        public DateTime OrderDate { get; set; }
        ///<![CDATA[Customer who ordered the invoice]]>
        public Guid OrderedBy { get; set; }
        ///<![CDATA[Contact person of customer who ordered the invoice]]>
        public Guid OrderedByContactPerson { get; set; }
        ///<![CDATA[Name of contact person of customer who ordered the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        ///<![CDATA[Name of customer who ordered the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        ///<![CDATA[Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[Payment reference for sales invoice]]>
        public string PaymentReference { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        ///<![CDATA[Sales representative]]>
        public Guid Salesperson { get; set; }
        ///<![CDATA[Name of sales representative]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }
        ///<![CDATA[Starter Sales invoice status (for starter functionality)]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 StarterSalesInvoiceStatus { get; set; }
        ///<![CDATA[Description of StarterSalesInvoiceStatus]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StarterSalesInvoiceStatusDescription { get; set; }
        ///<![CDATA[The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can't be changed anymore. Processing is done via printing. Processed invoices can't be reopened]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }
        ///<![CDATA[Code of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        ///<![CDATA[Description of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        ///<![CDATA[Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Description of the type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        ///<![CDATA[Total VAT amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        ///<![CDATA[Total VAT amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        ///<![CDATA[The invoice number of the customer]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesInvoiceLine
    {
        ///<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[For normal lines it's the amount excluding VAT]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.]]>
        public DateTime DeliveryDate { get; set; }
        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }
        ///<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Link to Employee originating from time and cost transactions]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        ///<![CDATA[EndTime is used to store the last date of a period. EndTime is used in combination with StartTime]]>
        public DateTime EndTime { get; set; }
        ///<![CDATA[The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID]]>
        public Guid InvoiceID { get; set; }
        ///<![CDATA[Reference to the item that is sold in this sales invoice line]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates the sequence of the lines within one invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Net price of the sales invoice line]]>
        public double? NetPrice { get; set; }
        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Price list]]>
        public Guid Pricelist { get; set; }
        ///<![CDATA[Description of Pricelist]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }
        ///<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Identifies the sales order this invoice line is based on]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }
        ///<![CDATA[Identifies the sales order line this sales invoice line is based on]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrderLine { get; set; }
        ///<![CDATA[Then line number of the sales order line on which this invoice line is based on]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineNumber { get; set; }
        ///<![CDATA[The order number of the sales order on which this invoice line is based on]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }
        ///<![CDATA[StartTime is used to store the first date of a period. StartTime is used in combination with EndTime]]>
        public DateTime StartTime { get; set; }
        ///<![CDATA[Obsolete. When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of Subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }
        ///<![CDATA[Code of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        ///<![CDATA[Description of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        ///<![CDATA[Code of Unit]]>
        public string UnitCode { get; set; }
        ///<![CDATA[Description of Unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Price per unit]]>
        public double? UnitPrice { get; set; }
        ///<![CDATA[VAT amount in the default currency of the company]]>
        public double? VATAmountDC { get; set; }
        ///<![CDATA[VAT amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[The VAT code that is used when the invoice is registered]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesItemPrice
    {
        ///<![CDATA[ID of the customer]]>
        public Guid Account { get; set; }
        ///<![CDATA[Name of the customer account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[The currency of the price]]>
        public string Currency { get; set; }
        ///<![CDATA[The default unit of the item]]>
        public string DefaultItemUnit { get; set; }
        ///<![CDATA[The description of the default item unit]]>
        public string DefaultItemUnitDescription { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Together with StartDate this determines whether the price is active]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item ID]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of Item]]>
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is 'gram' and the price unit is 'kilogram' then the value of this property is 1000.]]>
        public double? NumberOfItemsPerUnit { get; set; }
        ///<![CDATA[The actual price of this sales item]]>
        public double? Price { get; set; }
        ///<![CDATA[Minimum quantity to which the price is applicable]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Together with EndDate this determines whether the price is active]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[The unit code of the price]]>
        public string Unit { get; set; }
        ///<![CDATA[Description of the price unit]]>
        public string UnitDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("OrderID")]
    public class SalesOrder
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        ///<![CDATA[Shows if this sales order is approved]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 ApprovalStatus { get; set; }
        ///<![CDATA[Description of ApprovalStatus]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApprovalStatusDescription { get; set; }
        ///<![CDATA[Approval datetime]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Approved { get; set; }
        ///<![CDATA[User who approved the sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Approver { get; set; }
        ///<![CDATA[Name of approver]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApproverFullName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Reference to delivery customer]]>
        public Guid DeliverTo { get; set; }
        ///<![CDATA[Reference to contact person of delivery customer]]>
        public Guid DeliverToContactPerson { get; set; }
        ///<![CDATA[Name of contact person of delivery customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }
        ///<![CDATA[Name of delivery customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }
        ///<![CDATA[Delivery address]]>
        public Guid DeliveryAddress { get; set; }
        ///<![CDATA[Delivery date]]>
        public DateTime DeliveryDate { get; set; }
        ///<![CDATA[Shipping status]]>
        public Int16 DeliveryStatus { get; set; }
        ///<![CDATA[Description of DeliveryStatus]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryStatusDescription { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Document that is manually linked to the sales order]]>
        public Guid Document { get; set; }
        ///<![CDATA[Number of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Invoice status]]>
        public Int16 InvoiceStatus { get; set; }
        ///<![CDATA[Description of InvoiceStatus]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceStatusDescription { get; set; }
        ///<![CDATA[Reference to the Customer who will receive the invoice]]>
        public Guid InvoiceTo { get; set; }
        ///<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
        public Guid InvoiceToContactPerson { get; set; }
        ///<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        ///<![CDATA[Name of the customer who will receive the invoice]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Order date]]>
        public DateTime OrderDate { get; set; }
        ///<![CDATA[Customer who ordered the sales order]]>
        public Guid OrderedBy { get; set; }
        ///<![CDATA[Contact person of the customer who ordered the sales order]]>
        public Guid OrderedByContactPerson { get; set; }
        ///<![CDATA[Name of contact person of the customer who ordered the sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        ///<![CDATA[Name of the customer who ordered the sales order]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid OrderID { get; set; }
        ///<![CDATA[Number of sales order]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[Payment reference for sales order]]>
        public string PaymentReference { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }
        ///<![CDATA[Sales representative]]>
        public Guid Salesperson { get; set; }
        ///<![CDATA[Name of sales representative]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }
        ///<![CDATA[ShippingMethod]]>
        public Guid ShippingMethod { get; set; }
        ///<![CDATA[Description of ShippingMethod]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        ///<![CDATA[The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }
        ///<![CDATA[Code of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        ///<![CDATA[Description of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        ///<![CDATA[Code of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        ///<![CDATA[Warehouse]]>
        public Guid WarehouseID { get; set; }
        ///<![CDATA[The reference number of the customer]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class SalesOrderID
    {
        public Guid ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesOrderLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Item cost price]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostPriceFC { get; set; }
        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Delivery date of this line]]>
        public DateTime DeliveryDate { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to the item that is sold in this sales order line]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Item Version]]>
        public Guid ItemVersion { get; set; }
        ///<![CDATA[Description of Item Version]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Sales margin of the sales order line]]>
        public double? Margin { get; set; }
        ///<![CDATA[Net price of the sales order line]]>
        public double? NetPrice { get; set; }
        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }
        ///<![CDATA[The OrderID identifies the sales order. All the lines of a sales order have the same OrderID]]>
        public Guid OrderID { get; set; }
        ///<![CDATA[Number of sales order]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[Price list]]>
        public Guid Pricelist { get; set; }
        ///<![CDATA[Description of Pricelist]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }
        ///<![CDATA[The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }
        ///<![CDATA[The number of items delivered]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityDelivered { get; set; }
        ///<![CDATA[The number of items invoiced]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInvoiced { get; set; }
        ///<![CDATA[Reference to ShopOrder]]>
        public Guid ShopOrder { get; set; }
        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }
        ///<![CDATA[Code of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        ///<![CDATA[Description of the tax schedule]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        ///<![CDATA[Code of item unit]]>
        public string UnitCode { get; set; }
        ///<![CDATA[Description of Unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Price per unit in the currency of the transaction]]>
        public double? UnitPrice { get; set; }
        ///<![CDATA[Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)]]>
        public byte UseDropShipment { get; set; }
        ///<![CDATA[VAT amount in the currency of the transaction]]>
        public double? VATAmount { get; set; }
        ///<![CDATA[VAT code]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListDetail
    {
        ///<![CDATA[Customer account Id]]>
        public Guid Account { get; set; }
        ///<![CDATA[Customer account name]]>
        public string AccountName { get; set; }
        ///<![CDATA[Standard price]]>
        public Guid BasePrice { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency]]>
        public string Currency { get; set; }
        ///<![CDATA[Discount]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of the item]]>
        public string ItemDescription { get; set; }
        ///<![CDATA[ItemGroup]]>
        public Guid ItemGroup { get; set; }
        ///<![CDATA[Default sales unit of the item]]>
        public string ItemUnit { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[New price after discount]]>
        public double? NewPrice { get; set; }
        ///<![CDATA[Number of the item per unit]]>
        public double? NumberOfItemsPerUnit { get; set; }
        ///<![CDATA[Code of the PriceList]]>
        public string PriceListCode { get; set; }
        ///<![CDATA[Id of the PriceList]]>
        public Guid PriceListId { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Unit]]>
        public string Unit { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Schedule
    {
        ///<![CDATA[Indicates if the schedule is active. 0 = Inactive, 1 = Active]]>
        public byte? Active { get; set; }
        ///<![CDATA[Average hours per week in a schedule]]>
        public double? AverageHours { get; set; }
        ///<![CDATA[Schedule code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Average days per week in the schedule]]>
        public double? Days { get; set; }
        ///<![CDATA[Description of the schedule]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Employment ID for schedule]]>
        public Guid Employment { get; set; }
        ///<![CDATA[Employment number]]>
        public Int32 EmploymentHID { get; set; }
        ///<![CDATA[End date of the schedule]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Number of hours per week in a CLA for which the schedule is built]]>
        public double? Hours { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Number of hours which are built up each week for later leave]]>
        public double? LeaveHoursCompensation { get; set; }
        ///<![CDATA[Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No]]>
        public byte? Main { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Part-time factor for payroll calculation. Value between 0 and 1]]>
        public double? PaymentParttimeFactor { get; set; }
        ///<![CDATA[Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day]]>
        public Int32 ScheduleType { get; set; }
        ///<![CDATA[Description of the schedule type]]>
        public string ScheduleTypeDescription { get; set; }
        ///<![CDATA[Week in the schedule which is used to start with. By default the number will be 1.]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Week to start the schedule from for an employee]]>
        public Int32 StartWeek { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SerialNumber
    {
        ///<![CDATA[Availability of this serial number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? Available { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date of effective period for serial number]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Blocking state]]>
        public byte? IsBlocked { get; set; }
        ///<![CDATA[Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[Human readable serial number]]>
        [JsonProperty(PropertyName = "SerialNumber")]
        public string SerialNumberProperty { get; set; }
        ///<![CDATA[Start date of effective period for serial number]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Storage Location Code]]>
        public string StorageLocationCode { get; set; }
        ///<![CDATA[Warehouse Code]]>
        public string WarehouseCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ShippingMethod
    {
        ///<![CDATA[Active]]>
        public bool? Active { get; set; }
        ///<![CDATA[Code of the shipping method]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of shipping method]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Shipping method rates URL]]>
        public string ShippingRatesURL { get; set; }
        ///<![CDATA[Tracking URL]]>
        public string TrackingURL { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrder
    {
        ///<![CDATA[The cost center linked to the shop order]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[The cost unit linked to the shop order]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Date on which the shop order was placed]]>
        public DateTime EntryDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicator that Shop order is in planning]]>
        public byte IsInPlanning { get; set; }
        ///<![CDATA[Indicator if the Shop order is on hold]]>
        public byte IsOnHold { get; set; }
        ///<![CDATA[Indicator that the Shop order has been released to production]]>
        public byte IsReleased { get; set; }
        ///<![CDATA[Reference to the item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Reference to ItemVersion]]>
        public Guid ItemVersion { get; set; }
        ///<![CDATA[Description of Item Version]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes - only viewed internally]]>
        public string Notes { get; set; }
        ///<![CDATA[Planned date]]>
        public DateTime PlannedDate { get; set; }
        ///<![CDATA[Planned quantity]]>
        public double? PlannedQuantity { get; set; }
        ///<![CDATA[Planned end date]]>
        public DateTime PlannedStartDate { get; set; }
        ///<![CDATA[Produced quantity]]>
        public double? ProducedQuantity { get; set; }
        ///<![CDATA[Reference to Project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity ready to ship]]>
        public double? ReadyToShipQuantity { get; set; }
        ///<![CDATA[Collection of Sales order lines]]>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }
        ///<![CDATA[Shop order main]]>
        public Guid ShopOrderMain { get; set; }
        ///<![CDATA[Shop order main number]]>
        public Int32 ShopOrderMainNumber { get; set; }
        ///<![CDATA[Collection of Shop order Material plans]]>
        public IEnumerable<ShopOrderMaterialPlan> ShopOrderMaterialPlans { get; set; }
        ///<![CDATA[Unique number to indentify the shop order]]>
        public Int32 ShopOrderNumber { get; set; }
        ///<![CDATA[Shop order parent]]>
        public Guid ShopOrderParent { get; set; }
        ///<![CDATA[Shop order parent number]]>
        public Int32 ShopOrderParentNumber { get; set; }
        ///<![CDATA[Collection of Shop order Routing step plans]]>
        public IEnumerable<ShopOrderRoutingStepPlan> ShopOrderRoutingStepPlans { get; set; }
        ///<![CDATA[Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Overall status of the line: 9040 Regular]]>
        public Int16 Type { get; set; }
        ///<![CDATA[Reference to the Warehouse associated with the Shop order]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Your reference (of the customer)]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlan
    {
        ///<![CDATA[Indicates if this is a backflush step]]>
        public byte? Backflush { get; set; }
        ///<![CDATA[Calculator type]]>
        public Int16 CalculatorType { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the material]]>
        public string Description { get; set; }
        ///<![CDATA[Detail drawing reference]]>
        public string DetailDrawing { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to Items table]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item Code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Line number]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Line notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Planned amount in the currency of the transaction]]>
        public double? PlannedAmountFC { get; set; }
        ///<![CDATA[Date that the material is required.]]>
        public DateTime PlannedDate { get; set; }
        ///<![CDATA[Planned price of the material]]>
        public double? PlannedPriceFC { get; set; }
        ///<![CDATA[Intended quantity]]>
        public double? PlannedQuantity { get; set; }
        ///<![CDATA[Intended quantity unit factor]]>
        public double? PlannedQuantityFactor { get; set; }
        ///<![CDATA[Reference to ShopOrders table]]>
        public Guid ShopOrder { get; set; }
        ///<![CDATA[Line status]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Type]]>
        public Int16 Type { get; set; }
        ///<![CDATA[Unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        ///<![CDATA[Unit description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderRoutingStepPlan
    {
        ///<![CDATA[Reference to Account providing the Outsourced item]]>
        public Guid Account { get; set; }
        ///<![CDATA[Account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Account number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountNumber { get; set; }
        ///<![CDATA[Attended Percentage]]>
        public double? AttendedPercentage { get; set; }
        ///<![CDATA[Indicates if this is a backflush step]]>
        public byte? Backflush { get; set; }
        ///<![CDATA[Total cost / Shop order planned quantity]]>
        public double? CostPerItem { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the operation]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Efficiency Percentage]]>
        public double? EfficiencyPercentage { get; set; }
        ///<![CDATA[Conversion factor type between Shop order Item and Subcontract purchase Unit]]>
        public Int16 FactorType { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Sequential order of the operation]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Reference to Operations]]>
        public Guid Operation { get; set; }
        ///<![CDATA[Code of the routing step operation]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationCode { get; set; }
        ///<![CDATA[Description of the operation step]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }
        ///<![CDATA[Reference to OperationResources]]>
        public Guid OperationResource { get; set; }
        ///<![CDATA[Planned end date]]>
        public DateTime PlannedEndDate { get; set; }
        ///<![CDATA[Planned run hours]]>
        public double? PlannedRunHours { get; set; }
        ///<![CDATA[Planned setup hours]]>
        public double? PlannedSetupHours { get; set; }
        ///<![CDATA[Planned start date]]>
        public DateTime PlannedStartDate { get; set; }
        ///<![CDATA[Setup hours + Run hours]]>
        public double? PlannedTotalHours { get; set; }
        ///<![CDATA[Reference to Units]]>
        public string PurchaseUnit { get; set; }
        ///<![CDATA[Purchase Unit Factor]]>
        public double? PurchaseUnitFactor { get; set; }
        ///<![CDATA[Purchase Unit Price in the currency of the transaction]]>
        public double? PurchaseUnitPriceFC { get; set; }
        ///<![CDATA[Purchase unit quantity of the plan]]>
        public double? PurchaseUnitQuantity { get; set; }
        ///<![CDATA[Reference to RoutingStepTypes]]>
        public Int16 RoutingStepType { get; set; }
        ///<![CDATA[Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours]]>
        public double? Run { get; set; }
        ///<![CDATA[Reference to OperationMethod]]>
        public Int16 RunMethod { get; set; }
        ///<![CDATA[Description of RunMethod]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RunMethodDescription { get; set; }
        ///<![CDATA[Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours]]>
        public double? Setup { get; set; }
        ///<![CDATA[Reference to TimeUnits]]>
        public string SetupUnit { get; set; }
        ///<![CDATA[Reference to Shop orders]]>
        public Guid ShopOrder { get; set; }
        ///<![CDATA[Reference to OperationStatus]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Subcontracted lead days]]>
        public Int32 SubcontractedLeadDays { get; set; }
        ///<![CDATA[Collection of TimeTransactions]]>
        public IEnumerable<ManufacturingTimeTransaction> TimeTransactions { get; set; }
        ///<![CDATA[Total cost of the routing line]]>
        public double? TotalCostDC { get; set; }
        ///<![CDATA[Reference to Workcenters]]>
        public Guid Workcenter { get; set; }
        ///<![CDATA[Workcenter code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterCode { get; set; }
        ///<![CDATA[Workcenter description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SolutionLink
    {
        ///<![CDATA[ID of account to which solution is linked]]>
        public Guid Account { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Accountant main division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)]]>
        public Int32 ExternalSolutionCode { get; set; }
        ///<![CDATA[Name of the external solution]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalSolutionName { get; set; }
        ///<![CDATA[Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)]]>
        public string ExternalSolutionUrl { get; set; }
        ///<![CDATA[Primary key]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        ///<![CDATA[Division code of linked internal solution (mandatory for Internal solution)]]>
        public Int32 InternalSolutionDivision { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the solution link]]>
        public string Name { get; set; }
        ///<![CDATA[Name of the custom external solution (mandatory for ExternalOther solution)]]>
        public string OtherExternalSolutionName { get; set; }
        ///<![CDATA[Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther]]>
        public Int32 SolutionType { get; set; }
        ///<![CDATA[Link status: 0 - Active, 1 - Inactive, 2 -Archived]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Status { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StockBatchNumber
    {
        ///<![CDATA[Human readable batch number]]>
        public string BatchNumber { get; set; }
        ///<![CDATA[Batch number ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid BatchNumberID { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date of effective period for batch number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Blocking state]]>
        public byte? IsBlocked { get; set; }
        ///<![CDATA[Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Quantity of batch number]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[ID of stock count entry]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockCountLine { get; set; }
        public Guid StockTransactionID { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockCountID")]
    public class StockCount
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the stock count]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Entry number of the stock transactions]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Offset GL account of inventory]]>
        public Guid OffsetGLInventory { get; set; }
        ///<![CDATA[GLAccount code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryCode { get; set; }
        ///<![CDATA[GLAccount description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryDescription { get; set; }
        ///<![CDATA[Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }
        ///<![CDATA[Stock count status: 12-Draft, 21-Processed]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Stock count date]]>
        public DateTime StockCountDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid StockCountID { get; set; }
        ///<![CDATA[Collection of stock count lines]]>
        public IEnumerable<StockCountLine> StockCountLines { get; set; }
        ///<![CDATA[Human readable id of the stock count]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 StockCountNumber { get; set; }
        ///<![CDATA[Warehouse]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Code of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of Warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class StockCountLine
    {
        ///<![CDATA[The collection of batch numbers that belong to the items included in this stock count]]>
        public IEnumerable<StockBatchNumber> BatchNumbers { get; set; }
        ///<![CDATA[Cost price of the item that is used to create the stock count]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostPrice { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to the item for which the stock is counted]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Current standard/actual item cost price]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ItemCostPrice { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Shows quantity difference between current and new stock]]>
        public double? QuantityDifference { get; set; }
        ///<![CDATA[Shows current quantity available in stock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInStock { get; set; }
        ///<![CDATA[Shows new amended quantity in stock]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityNew { get; set; }
        ///<![CDATA[The collection of serial numbers that belong to the items included in this stock count]]>
        public IEnumerable<StockSerialNumber> SerialNumbers { get; set; }
        ///<![CDATA[Identifies the stock count. All the lines of a stock count have the same StockCountID]]>
        public Guid StockCountID { get; set; }
        ///<![CDATA[Stock item's unit description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StockKeepingUnit { get; set; }
        ///<![CDATA[Storage location]]>
        public Guid StorageLocation { get; set; }
        ///<![CDATA[Storage location code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        ///<![CDATA[Storage location description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StockSerialNumber
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date of effective period for serial number]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Blocking state]]>
        public byte? IsBlocked { get; set; }
        ///<![CDATA[Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Item code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
        ///<![CDATA[Human readable serial number]]>
        public string SerialNumber { get; set; }
        ///<![CDATA[Serial number ID]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SerialNumberID { get; set; }
        ///<![CDATA[Start date of effective period for serial number]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[ID of stock count entry]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockCountLine { get; set; }
        public Guid StockTransactionID { get; set; }
        ///<![CDATA[Storage Location Code]]>
        public string StorageLocationCode { get; set; }
        ///<![CDATA[Warehouse Code]]>
        public string WarehouseCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StorageLocation
    {
        ///<![CDATA[Code of the storage location]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the storage location]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the main storage location. There's always exactly one main storage location per warehouse]]>
        public byte? Main { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Warehouse ID]]>
        public Guid Warehouse { get; set; }
        ///<![CDATA[Warehouse Code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        ///<![CDATA[Description of warehouse]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class Subscription
    {
        ///<![CDATA[Indicates if subscription is blocked for time cost entry]]>
        public bool? BlockEntry { get; set; }
        ///<![CDATA[Date of cancellation]]>
        public DateTime CancellationDate { get; set; }
        ///<![CDATA[Reference to Classification]]>
        public Guid Classification { get; set; }
        ///<![CDATA[Code of Classification]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationCode { get; set; }
        ///<![CDATA[Description of Classification]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }
        ///<![CDATA[Purchase order number of customer]]>
        public string CustomerPONumber { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Invoice Day]]>
        public byte? InvoiceDay { get; set; }
        ///<![CDATA[Invoice date]]>
        public DateTime InvoicedTo { get; set; }
        ///<![CDATA[Reference to invoice account]]>
        public Guid InvoiceTo { get; set; }
        ///<![CDATA[Reference to contact person of invoice account]]>
        public Guid InvoiceToContactPerson { get; set; }
        ///<![CDATA[Name of contact person of invoice account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        ///<![CDATA[Name of invoice account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        ///<![CDATA[Invoicing start date]]>
        public DateTime InvoicingStartDate { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Number]]>
        public Int32 Number { get; set; }
        ///<![CDATA[Reference to order account]]>
        public Guid OrderedBy { get; set; }
        ///<![CDATA[Reference of contact person of order account]]>
        public Guid OrderedByContactPerson { get; set; }
        ///<![CDATA[Name of contact person of order account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        ///<![CDATA[Name of order account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        ///<![CDATA[Payment condition]]>
        public string PaymentCondition { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[Indicates if subscription is printed]]>
        public bool Printed { get; set; }
        ///<![CDATA[Reference to reason cancelled]]>
        public Guid ReasonCancelled { get; set; }
        ///<![CDATA[Code of ReasonCancelled]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledCode { get; set; }
        ///<![CDATA[Description of ReasonCancelled]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledDescription { get; set; }
        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Collection of subscription lines]]>
        public IEnumerable<SubscriptionLine> SubscriptionLines { get; set; }
        ///<![CDATA[Collection of restriction employees]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionEmployee> SubscriptionRestrictionEmployees { get; set; }
        ///<![CDATA[Collection of restriction items]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionItem> SubscriptionRestrictionItems { get; set; }
        ///<![CDATA[Reference to subscription type]]>
        public Guid SubscriptionType { get; set; }
        ///<![CDATA[Code of SubscriptionType]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeCode { get; set; }
        ///<![CDATA[Description of SubscriptionType]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionChargeType
    {
        ///<![CDATA[Description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SubscriptionLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        public double AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double AmountFC { get; set; }
        ///<![CDATA[Cost center]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Cost unit]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Discount percentage]]>
        public double? Discount { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Entry ID]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[From date]]>
        public DateTime FromDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to Item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Line number]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Reference to LineType]]>
        public Int16 LineType { get; set; }
        ///<![CDATA[Description of LineType]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LineTypeDescription { get; set; }
        ///<![CDATA[Net price in the currency of the transaction]]>
        public double NetPrice { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Quantity]]>
        public double Quantity { get; set; }
        ///<![CDATA[To date]]>
        public DateTime ToDate { get; set; }
        ///<![CDATA[Unit code]]>
        public string UnitCode { get; set; }
        ///<![CDATA[Description of Unit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        ///<![CDATA[Unit price in the currency of the transaction (price * unit factor)]]>
        public double UnitPrice { get; set; }
        ///<![CDATA[Vat Amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }
        ///<![CDATA[VATCode]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionReasonCode
    {
        ///<![CDATA[Indicates if the reason code is active]]>
        public bool Active { get; set; }
        ///<![CDATA[Subscription reason code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionEmployee
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Employee linked to the restriction]]>
        public Guid Employee { get; set; }
        ///<![CDATA[Name of employee]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        ///<![CDATA[Readable ID of employee]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EmployeeHID { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Number of subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionItem
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item linked to the restriction]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Number of subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionType
    {
        ///<![CDATA[Code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxComponentRate
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division]]>
        public Int32 Division { get; set; }
        ///<![CDATA[The date untill the rate for this component is valid]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The sequence in which the tax rates are ordered]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Rate]]>
        public double Rate { get; set; }
        ///<![CDATA[The date from which the rate is active]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Tax component to which this tax rate is linked]]>
        public Guid TaxComponent { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("DocumentID")]
    public class TaxDocument
    {
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Currency]]>
        public string Currency { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key, document ID]]>
        public Guid DocumentID { get; set; }
        ///<![CDATA[Url to view the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }
        ///<![CDATA[Due date]]>
        public DateTime DueDate { get; set; }
        ///<![CDATA[Frequency]]>
        public string Frequency { get; set; }
        ///<![CDATA[Payroll declaration type]]>
        public string PayrollDeclarationType { get; set; }
        ///<![CDATA[Period]]>
        public Int32 Period { get; set; }
        ///<![CDATA[Description of Period]]>
        public string PeriodDescription { get; set; }
        ///<![CDATA[Reference to request]]>
        public Guid Request { get; set; }
        ///<![CDATA[Status]]>
        public Int32 Status { get; set; }
        ///<![CDATA[Type]]>
        public Int32 Type { get; set; }
        ///<![CDATA[Year]]>
        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxEmploymentEndFlexCode
    {
        ///<![CDATA[Code of flexible employment contract phase]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of flexible employment contract phase]]>
        public string Description { get; set; }
        ///<![CDATA[End date of flexible employment contract]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }
        ///<![CDATA[Start date of flexible employment contract phase]]>
        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxSchedule
    {
        ///<![CDATA[Tax schedule code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Tax schedule description]]>
        public string Description { get; set; }
        ///<![CDATA[Division]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if the tax schedule is blocked, 0 = not blocked, 1 = blocked]]>
        public byte IsBlocked { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes for the tax schedule]]>
        public string Notes { get; set; }
        ///<![CDATA[The type of tax schedule, 10=Single, 20=Combined]]>
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxScheduleComponent
    {
        ///<![CDATA[Account linked to the tax schedule]]>
        public Guid Account { get; set; }
        ///<![CDATA[Tax schedule code]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }
        ///<![CDATA[Tax schedule description]]>
        public string Description { get; set; }
        ///<![CDATA[Division]]>
        public Int32 Division { get; set; }
        ///<![CDATA[GLAccount linked to the tax component]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }
        ///<![CDATA[The sequence in which the tax components are ordered]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Id of the tax component]]>
        public Guid TaxComponent { get; set; }
        ///<![CDATA[Collection of Rates for this tax component]]>
        public IEnumerable<TaxComponentRate> TaxComponentRates { get; set; }
        ///<![CDATA[Tax schedule to which the tax component is linked]]>
        public Guid TaxSchedule { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingAccount
    {
        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of account]]>
        public string AccountName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingAccountDetails
    {
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Name]]>
        public string Name { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingActivitiesAndExpenses
    {
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Description of Parent]]>
        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingItemDetails
    {
        ///<![CDATA[Item code]]>
        public string Code { get; set; }
        ///<![CDATA[Description of the item code]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if fractions are allowed for quantities of this item]]>
        public bool IsFractionAllowedItem { get; set; }
        ///<![CDATA[Indicates if the item can be sold]]>
        public bool IsSalesItem { get; set; }
        ///<![CDATA[Sales currency code]]>
        public string SalesCurrency { get; set; }
        ///<![CDATA[Sales price]]>
        public double SalesPrice { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingProject
    {
        ///<![CDATA[Code]]>
        public string ProjectCode { get; set; }
        ///<![CDATA[Description]]>
        public string ProjectDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingProjectDetails
    {
        ///<![CDATA[The account for this project]]>
        public Guid Account { get; set; }
        public string AccountName { get; set; }
        ///<![CDATA[Code of project]]>
        public string Code { get; set; }
        ///<![CDATA[Description of the project]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Reference to ProjectTypes]]>
        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingRecentAccount
    {
        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }
        ///<![CDATA[Name of account]]>
        public string AccountName { get; set; }
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingRecentActivitiesAndExpenses
    {
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Description of Parent]]>
        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class TimeAndBillingRecentHourCostType
    {
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }
        ///<![CDATA[Description of item]]>
        public string ItemDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingRecentProject
    {
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }
        ///<![CDATA[Code of project]]>
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of project]]>
        public string ProjectDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeCorrection
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Id]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes]]>
        public string Notes { get; set; }
        ///<![CDATA[Reference to the time entry that this corrects for]]>
        public Guid OriginalEntryId { get; set; }
        ///<![CDATA[Quantity has to be negative value. E.g.: If original quantity is 10 and the correct quantity is 4, this quantity is -6]]>
        public double? Quantity { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        ///<![CDATA[Account linked to the transaction]]>
        public Guid Account { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Reference to ProjectWBS (work breakdown structure)]]>
        public Guid Activity { get; set; }
        ///<![CDATA[Description of ProjectWBS]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ActivityDescription { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }
        ///<![CDATA[Amount in the currency of the transaction of the transaction]]>
        public double? AmountFC { get; set; }
        ///<![CDATA[Attachment linked to the transaction]]>
        public Guid Attachment { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency of the amount]]>
        public string Currency { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Description of Division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }
        ///<![CDATA[Employee linked to the transaction]]>
        public Guid Employee { get; set; }
        ///<![CDATA[End time of the transaction]]>
        public DateTime EndTime { get; set; }
        ///<![CDATA[Entrynumber]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Errortext, used for the backgroundjobs]]>
        public string ErrorText { get; set; }
        ///<![CDATA[Status of the transaction]]>
        public Int16 HourStatus { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactions. Items of other types are linked to cost transactions]]>
        public Guid Item { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[True if you can use decimals for item quantity]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Notes linked to the transaction]]>
        public string Notes { get; set; }
        ///<![CDATA[Price in the currency of the transaction]]>
        public double? Price { get; set; }
        ///<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
        public double? PriceFC { get; set; }
        ///<![CDATA[Project linked to the transaction]]>
        public Guid Project { get; set; }
        ///<![CDATA[Reference to project account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ProjectAccount { get; set; }
        ///<![CDATA[Project account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }
        ///<![CDATA[Project account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity of the transaction]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Start time of the transaction]]>
        public DateTime StartTime { get; set; }
        ///<![CDATA[Subscription linked to the transaction]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Account linked to the subscription]]>
        public Guid SubscriptionAccount { get; set; }
        ///<![CDATA[Subscription account code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }
        ///<![CDATA[Subscription account name]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }
        ///<![CDATA[Description of the subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Subscription number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
        ///<![CDATA[Type of the transaction]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("EntryID")]
    public class Transaction
    {
        ///<![CDATA[Closing balance in the currency of the transaction]]>
        public double? ClosingBalanceFC { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }
        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }
        ///<![CDATA[0 =  Financial entry without extra duty, 1 = Financial entry with extra duty]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsExtraDuty { get; set; }
        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }
        ///<![CDATA[Description of Journal]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[Opening balance in the currency of the transaction]]>
        public double? OpeningBalanceFC { get; set; }
        ///<![CDATA[Code of PaymentCondition]]>
        public string PaymentConditionCode { get; set; }
        ///<![CDATA[Description of PaymentCondition]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Description of Status]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<TransactionLine> TransactionLines { get; set; }
        ///<![CDATA[The transaction type. 10 = Opening balance, 20 = Sales entry, 21 = Sales credit note, 22 = Return invoice sent, 30 = Purchase entry, 31 = Purchase credit note, 32 = Return invoice received, 40 = Cash flow, 50 = VAT return, 70 = Asset depreciation, 71 = Asset investment, 72 = Asset revaluation, 73 = Asset transfer, 74 = Asset split, 75 = Asset discontinue, 76 = Asset sales, 80 = Revaluation, 82 = Exchange rate difference, 83 = Payment difference, 84 = Deferred revenue, 85 = Tracking number:Revaluation, 86 = Deferred cost, 90 = Other, 120 = Delivery, 121 = Sales return, 130 = Receipt, 131 = Purchase return, 140 = Shop order stock receipt, 141 = Shop order stock reversal, 142 = Issue to parent, 145 = Shop order time entry, 146 = Shop order time entry reversal, 150 = Requirement issue, 151 = Requirement reversal, 152 = Returned from parent, 155 = Subcontract Issue, 156 = Subcontract reversal, 158 = Shop order completed, 162 = Finish assembly, 170 = Payroll, 180 = Stock revaluation, 195 = Stock count, 290 = Correction entry, 310 = Period closing, 320 = Year end reflection, 321 = Year end costing, 322 = Year end profits to gross profit, 323 = Year end costs to gross profit, 324 = Year end tax, 325 = Year end gross profit to net p/l, 326 = Year end net p/l to balance sheet, 327 = Year end closing balance, 328 = Year start opening balance, 3000 = Budget]]>
        public Int32 Type { get; set; }
        ///<![CDATA[The description of the transaction type]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TransactionLine
    {
        ///<![CDATA[Reference to account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of the Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of the Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Amount in the default currency of the company]]>
        public double AmountDC { get; set; }
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double AmountFC { get; set; }
        ///<![CDATA[Vat base amount in the currency of the transaction]]>
        public double? AmountVATBaseFC { get; set; }
        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? AmountVATFC { get; set; }
        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }
        ///<![CDATA[Code of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        ///<![CDATA[Description of Asset]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        ///<![CDATA[Reference to cost center]]>
        public string CostCenter { get; set; }
        ///<![CDATA[Description of CostCenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        ///<![CDATA[Reference to cost unit]]>
        public string CostUnit { get; set; }
        ///<![CDATA[Description of CostUnit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Currency]]>
        public string Currency { get; set; }
        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Reference to document]]>
        public Guid Document { get; set; }
        ///<![CDATA[Number of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }
        ///<![CDATA[Subject of the document]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        ///<![CDATA[Date that payment should be done]]>
        public DateTime DueDate { get; set; }
        ///<![CDATA[Reference to header of the entry]]>
        public Guid EntryID { get; set; }
        ///<![CDATA[Entry number of the header]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }
        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }
        ///<![CDATA[Extra duty amount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyAmountFC { get; set; }
        ///<![CDATA[Extra duty percentage]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyPercentage { get; set; }
        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }
        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }
        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }
        ///<![CDATA[Code of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        ///<![CDATA[Description of GLAccount]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }
        ///<![CDATA[Reference to item]]>
        public Guid Item { get; set; }
        ///<![CDATA[Code of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        ///<![CDATA[Description of Item]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        ///<![CDATA[The journal code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalCode { get; set; }
        ///<![CDATA[The journal description]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        ///<![CDATA[Line number]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Line type]]>
        public Int16 LineType { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[OffsetID]]>
        public Guid OffsetID { get; set; }
        ///<![CDATA[Order number]]>
        public Int32 OrderNumber { get; set; }
        ///<![CDATA[Discount amount when paid in time]]>
        public double? PaymentDiscountAmount { get; set; }
        ///<![CDATA[Payment reference]]>
        public string PaymentReference { get; set; }
        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }
        ///<![CDATA[Code of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        ///<![CDATA[Description of Project]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }
        ///<![CDATA[Serial number of item]]>
        public string SerialNumber { get; set; }
        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }
        ///<![CDATA[Description of Subscription]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        ///<![CDATA[Tracking number of item]]>
        public string TrackingNumber { get; set; }
        ///<![CDATA[Tracking number description]]>
        public string TrackingNumberDescription { get; set; }
        ///<![CDATA[Vat code]]>
        public string VATCode { get; set; }
        ///<![CDATA[Description of VATCode]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        ///<![CDATA[Vat percentage]]>
        public double? VATPercentage { get; set; }
        ///<![CDATA[Vat type]]>
        public string VATType { get; set; }
        ///<![CDATA[Your reference (of customer)]]>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Unit
    {
        ///<![CDATA[Indicates whether a unit is in use]]>
        public bool? Active { get; set; }
        ///<![CDATA[Unique code for the unit]]>
        public string Code { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates the main unit per division. Will be used when creating new item]]>
        public byte? Main { get; set; }
        ///<![CDATA[If Type = 'T' (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second]]>
        public string TimeUnit { get; set; }
        ///<![CDATA[Type of unit. Type 'Time' is especially important for contracts.]]>
        public string Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("UserID")]
    public class User
    {
        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }
        ///<![CDATA[Birth name]]>
        public string BirthName { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Customer the user belongs to]]>
        public Guid Customer { get; set; }
        ///<![CDATA[Name of Customer]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }
        ///<![CDATA[Email address of the user]]>
        public string Email { get; set; }
        ///<![CDATA[Date after which the user login is disabled. NULL means no enddate]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[First name]]>
        public string FirstName { get; set; }
        ///<![CDATA[Full name of the user]]>
        public string FullName { get; set; }
        ///<![CDATA[Gender: M=Male, V=Female, O=Unknown]]>
        public string Gender { get; set; }
        ///<![CDATA[Initials]]>
        public string Initials { get; set; }
        ///<![CDATA[Language (culture) that is used in Exact Online]]>
        public string Language { get; set; }
        ///<![CDATA[The last time this user logged in]]>
        public DateTime LastLogin { get; set; }
        ///<![CDATA[Last name]]>
        public string LastName { get; set; }
        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }
        ///<![CDATA[Mobile phone]]>
        public string Mobile { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }
        ///<![CDATA[Phone number extension]]>
        public string PhoneExtension { get; set; }
        ///<![CDATA[Profile code]]>
        public string ProfileCode { get; set; }
        ///<![CDATA[Startdate after which the login is allowed. If the start date is NULL the login is allowed as well]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[Start Division]]>
        public Int32 StartDivision { get; set; }
        ///<![CDATA[Title]]>
        public string Title { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid UserID { get; set; }
        ///<![CDATA[Login name of the user]]>
        public string UserName { get; set; }
        ///<![CDATA[Collection of user roles]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<UserRole> UserRoles { get; set; }
        ///<![CDATA[Collection of user roles per division]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<UserRolePerDivision> UserRolesPerDivision { get; set; }
        ///<![CDATA[Obsolete]]>
        public string UserTypesList { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class UserRole
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The role that the user is linked to]]>
        public Int32 Role { get; set; }
        ///<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
        public Int32 RoleLevel { get; set; }
        ///<![CDATA[Indicates the date when the role becomes active for the user]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[The user that is linked to the role]]>
        public Guid UserID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class UserRolePerDivision
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of the creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }
        ///<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of the last modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[The role that the user is linked to]]>
        public Int32 Role { get; set; }
        ///<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
        public Int32 RoleLevel { get; set; }
        ///<![CDATA[Indicates the date when the role becomes active for the user]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[The user that is linked to the role]]>
        public Guid UserID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class VATCode
    {
        ///<![CDATA[Tax account]]>
        public Guid Account { get; set; }
        ///<![CDATA[Code of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        ///<![CDATA[Name of Account]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        ///<![CDATA[Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax]]>
        public byte? CalculationBasis { get; set; }
        ///<![CDATA[Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created]]>
        public bool? Charged { get; set; }
        ///<![CDATA[VAT code]]>
        public string Code { get; set; }
        ///<![CDATA[Obsolete]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the VAT code]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation]]>
        public string EUSalesListing { get; set; }
        ///<![CDATA[Indicates the purchase discount GL account linked to the VAT codes for German legislation]]>
        public Guid GLDiscountPurchase { get; set; }
        ///<![CDATA[Code of GLDiscountPurchase]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseCode { get; set; }
        ///<![CDATA[Description of GLDiscountPurchase]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseDescription { get; set; }
        ///<![CDATA[Indicates the sales discount GL account linked to the VAT codes for German legislation]]>
        public Guid GLDiscountSales { get; set; }
        ///<![CDATA[Code of GLDiscountSales]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesCode { get; set; }
        ///<![CDATA[Description of GLDiscountSales]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesDescription { get; set; }
        ///<![CDATA[G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT]]>
        public Guid GLToClaim { get; set; }
        ///<![CDATA[Code of GLToClaim]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimCode { get; set; }
        ///<![CDATA[Description of GLToClaim]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimDescription { get; set; }
        ///<![CDATA[G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT]]>
        public Guid GLToPay { get; set; }
        ///<![CDATA[Code of GLToPay]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayCode { get; set; }
        ///<![CDATA[Description of GLToPay]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayDescription { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if intrastat is used]]>
        public bool? IntraStat { get; set; }
        ///<![CDATA[Indicates if the VAT code may still be used]]>
        public bool? IsBlocked { get; set; }
        ///<![CDATA[Legal description for VAT code to print in the total block of the invoice]]>
        public string LegalText { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[User name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Percentage of the VAT code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }
        ///<![CDATA[Indicates what type of Taxcode it is: can be VAT, IncomeTax]]>
        public Int16 TaxReturnType { get; set; }
        ///<![CDATA[Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT]]>
        public string Type { get; set; }
        ///<![CDATA[Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type]]>
        public string VatDocType { get; set; }
        ///<![CDATA[The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)]]>
        public byte VatMargin { get; set; }
        ///<![CDATA[Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability]]>
        public Int16 VATPartialRatio { get; set; }
        ///<![CDATA[VAT percentages. You can have several VAT percentages, with start and end dates]]>
        public IEnumerable<VatPercentage> VATPercentages { get; set; }
        ///<![CDATA[Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales]]>
        public string VATTransactionType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class VatPercentage
    {
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[End date of the date range during which this percentage is valid]]>
        public DateTime EndDate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Line number]]>
        public Int32 LineNumber { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Percentage]]>
        public double? Percentage { get; set; }
        ///<![CDATA[Start date of the date range during which this percentage is valid]]>
        public DateTime StartDate { get; set; }
        ///<![CDATA[0 = Normal, 1 = Extra duty]]>
        public Int16 Type { get; set; }
        ///<![CDATA[VAT code]]>
        public Guid VATCodeID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Warehouse
    {
        ///<![CDATA[Code of the warehouse]]>
        public string Code { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[The description of the warehouse]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[Email address]]>
        public string EMail { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if this is the main warehouse. There's always exactly one main warehouse per administration]]>
        public byte Main { get; set; }
        ///<![CDATA[User reponsible for the warehouse]]>
        public Guid ManagerUser { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Indicates if this warehouse is using storage locations. The storage locations will not be removed when when this is deactivated]]>
        public byte UseStorageLocations { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Workcenter
    {
        ///<![CDATA[Code of the work center]]>
        public string Code { get; set; }
        ///<![CDATA[Reference to CostCenters]]>
        public string Costcenter { get; set; }
        ///<![CDATA[Description of Costcenter]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        ///<![CDATA[Reference to CostUnits]]>
        public string Costunit { get; set; }
        ///<![CDATA[Description of Costunit]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        ///<![CDATA[Creation date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        ///<![CDATA[User ID of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        ///<![CDATA[Name of creator]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        ///<![CDATA[Description of the work center]]>
        public string Description { get; set; }
        ///<![CDATA[Division code]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        ///<![CDATA[General burden rate]]>
        public double? GeneralBurdenRate { get; set; }
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }
        ///<![CDATA[Indicates if labor burden is calculated as a percentage or amount]]>
        public byte IsLaborBurdenPercent { get; set; }
        ///<![CDATA[Labor burden rate]]>
        public double? LaborBurdenRate { get; set; }
        ///<![CDATA[Machine burden rate]]>
        public double? MachineBurdenRate { get; set; }
        ///<![CDATA[Last modified date]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        ///<![CDATA[User ID of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        ///<![CDATA[Name of modifier]]>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }
        ///<![CDATA[Area to which the work center belongs.]]>
        public Guid ProductionArea { get; set; }
        ///<![CDATA[Run labor rate]]>
        public double? RunLaborRate { get; set; }
        ///<![CDATA[Search code of the work center]]>
        public string SearchCode { get; set; }
        ///<![CDATA[Setup labor rate]]>
        public double? SetupLaborRate { get; set; }
        ///<![CDATA[Reference to WorkcenterStatus]]>
        public Int16 Status { get; set; }
        ///<![CDATA[Reference to WorkcenterTypes]]>
        public Int16 Type { get; set; }
    }
}