using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    // Last generated on 2015-11-10 09:58:01 +01:00

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Account
    {

        public Guid Accountant { get; set; }

        public Guid AccountManager { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountManagerFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AccountManagerHID { get; set; }

        public Guid ActivitySector { get; set; }

        public Guid ActivitySubSector { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<BankAccount> BankAccounts { get; set; }

        public bool? Blocked { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid BRIN { get; set; }

        public Guid BusinessType { get; set; }

        public bool? CanDropShip { get; set; }

        public string ChamberOfCommerce { get; set; }

        public string City { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Classification { get; set; }

        public Guid Classification1 { get; set; }

        public Guid Classification2 { get; set; }

        public Guid Classification3 { get; set; }

        public Guid Classification4 { get; set; }

        public Guid Classification5 { get; set; }

        public Guid Classification6 { get; set; }

        public Guid Classification7 { get; set; }

        public Guid Classification8 { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        public string Code { get; set; }

        public string CodeAtSupplier { get; set; }

        public Guid CompanySize { get; set; }

        public byte? ConsolidationScenario { get; set; }

        public DateTime ControlledDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        public byte CostPaid { get; set; }

        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public double? CreditLinePurchase { get; set; }

        public double? CreditLineSales { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime CustomerSince { get; set; }

        public double? DiscountPurchase { get; set; }

        public double? DiscountSales { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DunsNumber { get; set; }

        public string Email { get; set; }

        public DateTime EndDate { get; set; }

        public string Fax { get; set; }

        public Guid GLAccountPurchase { get; set; }

        public Guid GLAccountSales { get; set; }

        public Guid GLAP { get; set; }

        public Guid GLAR { get; set; }

        public Guid ID { get; set; }

        public string IntraStatArea { get; set; }

        public string IntraStatDeliveryTerm { get; set; }

        public string IntraStatSystem { get; set; }

        public string IntraStatTransactionA { get; set; }

        public string IntraStatTransactionB { get; set; }

        public string IntraStatTransportMethod { get; set; }

        public Guid InvoiceAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }

        public Int32 InvoiceAttachmentType { get; set; }

        public Int32 InvoicingMethod { get; set; }

        public byte IsAccountant { get; set; }

        public byte IsAgency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsBank { get; set; }

        public byte IsCompetitor { get; set; }

        public byte IsMailing { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMember { get; set; }

        public bool? IsPilot { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsPurchase { get; set; }

        public bool? IsReseller { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsSales { get; set; }

        public bool? IsSupplier { get; set; }

        public string Language { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string LanguageDescription { get; set; }

        public double? Latitude { get; set; }

        public Guid LeadSource { get; set; }

        public byte[] Logo { get; set; }

        public string LogoFileName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoThumbnailUrl { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoUrl { get; set; }

        public double? Longitude { get; set; }

        public Guid MainContact { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Name { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Parent { get; set; }

        public string PaymentConditionPurchase { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionPurchaseDescription { get; set; }

        public string PaymentConditionSales { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionSalesDescription { get; set; }

        public string Phone { get; set; }

        public string PhoneExtension { get; set; }

        public string Postcode { get; set; }

        public Guid PriceList { get; set; }

        public string PurchaseCurrency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseCurrencyDescription { get; set; }

        public Int32 PurchaseLeadDays { get; set; }

        public string PurchaseVATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseVATCodeDescription { get; set; }

        public bool? RecepientOfCommissions { get; set; }

        public string Remarks { get; set; }

        public Guid Reseller { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerName { get; set; }

        public string SalesCurrency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesCurrencyDescription { get; set; }

        public Guid SalesTaxSchedule { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleDescription { get; set; }

        public string SalesVATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVATCodeDescription { get; set; }

        public string SearchCode { get; set; }

        public Int32 SecurityLevel { get; set; }

        public byte SeparateInvPerProject { get; set; }

        public byte SeparateInvPerSubscription { get; set; }

        public Int32 ShippingLeadDays { get; set; }

        public Guid ShippingMethod { get; set; }

        public DateTime StartDate { get; set; }

        public string State { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StateName { get; set; }

        public string Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime StatusSince { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }

        public string VATLiability { get; set; }

        public string VATNumber { get; set; }

        public string Website { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClass
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public Guid CreditManagementScenario { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassification
    {

        public Guid AccountClassificationName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountClassificationNameDescription { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassificationName
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int32 SequenceNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ActiveEmployment
    {

        public double? AverageDaysPerWeek { get; set; }

        public double? AverageHoursPerWeek { get; set; }

        public Guid Contract { get; set; }

        public Guid ContractDocument { get; set; }

        public DateTime ContractEndDate { get; set; }

        public DateTime ContractProbationEndDate { get; set; }

        public Int32 ContractProbationPeriod { get; set; }

        public DateTime ContractStartDate { get; set; }

        public Int32 ContractType { get; set; }

        public string ContractTypeDescription { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Guid Department { get; set; }

        public string DepartmentCode { get; set; }

        public string DepartmentDescription { get; set; }

        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        public string EmployeeFullName { get; set; }

        public Int32 EmployeeHID { get; set; }

        public Guid EmploymentOrganization { get; set; }

        public DateTime EndDate { get; set; }

        public Int32 HID { get; set; }

        public double? HourlyWage { get; set; }

        public Guid ID { get; set; }

        public double? InternalRate { get; set; }

        public Guid Jobtitle { get; set; }

        public string JobtitleDescription { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public Int32 ReasonEnd { get; set; }

        public string ReasonEndDescription { get; set; }

        public Int32 ReasonEndFlex { get; set; }

        public string ReasonEndFlexDescription { get; set; }

        public Guid Salary { get; set; }

        public Guid Schedule { get; set; }

        public double? ScheduleAverageHours { get; set; }

        public string ScheduleCode { get; set; }

        public double? ScheduleDays { get; set; }

        public string ScheduleDescription { get; set; }

        public double? ScheduleHours { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Address
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string City { get; set; }

        public Guid Contact { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactName { get; set; }

        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public string Fax { get; set; }

        public bool? FreeBoolField_01 { get; set; }

        public bool? FreeBoolField_02 { get; set; }

        public bool? FreeBoolField_03 { get; set; }

        public bool? FreeBoolField_04 { get; set; }

        public bool? FreeBoolField_05 { get; set; }

        public DateTime FreeDateField_01 { get; set; }

        public DateTime FreeDateField_02 { get; set; }

        public DateTime FreeDateField_03 { get; set; }

        public DateTime FreeDateField_04 { get; set; }

        public DateTime FreeDateField_05 { get; set; }

        public double? FreeNumberField_01 { get; set; }

        public double? FreeNumberField_02 { get; set; }

        public double? FreeNumberField_03 { get; set; }

        public double? FreeNumberField_04 { get; set; }

        public double? FreeNumberField_05 { get; set; }

        public string FreeTextField_01 { get; set; }

        public string FreeTextField_02 { get; set; }

        public string FreeTextField_03 { get; set; }

        public string FreeTextField_04 { get; set; }

        public string FreeTextField_05 { get; set; }

        public Guid ID { get; set; }

        public string Mailbox { get; set; }

        public bool? Main { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string NicNumber { get; set; }

        public string Notes { get; set; }

        public string Phone { get; set; }

        public string PhoneExtension { get; set; }

        public string Postcode { get; set; }

        public string State { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StateDescription { get; set; }

        public Int16 Type { get; set; }

        public Guid Warehouse { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AddressState
    {

        public string Country { get; set; }

        public string DisplayValue { get; set; }

        public Guid ID { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string Name { get; set; }

        public string State { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingAmountsPayable
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public Int32 AgeGroup1 { get; set; }

        public double AgeGroup1Amount { get; set; }

        public string AgeGroup1Description { get; set; }

        public Int32 AgeGroup2 { get; set; }

        public double AgeGroup2Amount { get; set; }

        public string AgeGroup2Description { get; set; }

        public Int32 AgeGroup3 { get; set; }

        public double AgeGroup3Amount { get; set; }

        public string AgeGroup3Description { get; set; }

        public Int32 AgeGroup4 { get; set; }

        public double AgeGroup4Amount { get; set; }

        public string AgeGroup4Description { get; set; }

        public string CurrencyCode { get; set; }

        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingAmountsReceivable
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public Int32 AgeGroup1 { get; set; }

        public double AgeGroup1Amount { get; set; }

        public string AgeGroup1Description { get; set; }

        public Int32 AgeGroup2 { get; set; }

        public double AgeGroup2Amount { get; set; }

        public string AgeGroup2Description { get; set; }

        public Int32 AgeGroup3 { get; set; }

        public double AgeGroup3Amount { get; set; }

        public string AgeGroup3Description { get; set; }

        public Int32 AgeGroup4 { get; set; }

        public double AgeGroup4Amount { get; set; }

        public string AgeGroup4Description { get; set; }

        public string CurrencyCode { get; set; }

        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AgeGroup")]
    public class AgingOverview
    {

        public Int32 AgeGroup { get; set; }

        public string AgeGroupDescription { get; set; }

        public double AmountPayable { get; set; }

        public double AmountReceivable { get; set; }

        public string CurrencyCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Asset
    {

        public byte AlreadyDepreciated { get; set; }

        public Guid AssetFrom { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetFromDescription { get; set; }

        public Guid AssetGroup { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetGroupDescription { get; set; }

        public double? CatalogueValue { get; set; }

        public string Code { get; set; }

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public double? DeductionPercentage { get; set; }

        public double? DepreciatedAmount { get; set; }

        public Int32 DepreciatedPeriods { get; set; }

        public DateTime DepreciatedStartDate { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EndDate { get; set; }

        public Int16 EngineEmission { get; set; }

        public Int16 EngineType { get; set; }

        public Guid GLTransactionLine { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLTransactionLineDescription { get; set; }

        public Guid ID { get; set; }

        public Guid InvestmentAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountName { get; set; }

        public double? InvestmentAmountDC { get; set; }

        public double? InvestmentAmountFC { get; set; }

        public string InvestmentCurrency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentCurrencyDescription { get; set; }

        public DateTime InvestmentDate { get; set; }

        public Int16 InvestmentDeduction { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Guid Parent { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentDescription { get; set; }

        public byte[] Picture { get; set; }

        public string PictureFileName { get; set; }

        public Guid PrimaryMethod { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodDescription { get; set; }

        public double? ResidualValue { get; set; }

        public DateTime StartDate { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid TransactionEntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 TransactionEntryNo { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Bank
    {

        public string BankName { get; set; }

        public string BICCode { get; set; }

        public string Country { get; set; }

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public string Format { get; set; }

        public string HomePageAddress { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        public string Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BankAccount
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Bank { get; set; }

        [JsonProperty(PropertyName = "BankAccount")]
        public string BankAccountProperty { get; set; }

        public string BankAccountHolderName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }

        public string BICCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Format { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string IBAN { get; set; }

        public Guid ID { get; set; }

        public bool? Main { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class BankEntry
    {

        public IEnumerable<BankEntryLine> BankEntryLines { get; set; }

        public Guid BankStatementDocument { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 BankStatementDocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankStatementDocumentSubject { get; set; }

        public double? ClosingBalanceFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        public Int16 FinancialPeriod { get; set; }

        public Int16 FinancialYear { get; set; }

        public string JournalCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        public double? OpeningBalanceFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class BankEntryLine
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public double? AmountVATFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public Guid EntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        public double? ExchangeRate { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid OffsetID { get; set; }
        public Int32 OurRef { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }

        public string VATType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Budget
    {

        public double? AmountDC { get; set; }

        public Guid BudgetScenario { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioDescription { get; set; }

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Int64 HID { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int16 ReportingPeriod { get; set; }

        public Int16 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class CashEntry
    {

        public IEnumerable<CashEntryLine> CashEntryLines { get; set; }

        public double? ClosingBalanceFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        public Int16 FinancialPeriod { get; set; }

        public Int16 FinancialYear { get; set; }

        public string JournalCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        public double? OpeningBalanceFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class CashEntryLine
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public double? AmountVATFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public Guid EntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        public double? ExchangeRate { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid OffsetID { get; set; }
        public Int32 OurRef { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }

        public string VATType { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Contact
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid AccountMainContact { get; set; }

        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AllowMailing { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthName { get; set; }

        public string BirthNamePrefix { get; set; }

        public string BirthPlace { get; set; }

        public string BusinessEmail { get; set; }

        public string BusinessFax { get; set; }

        public string BusinessMobile { get; set; }

        public string BusinessPhone { get; set; }

        public string BusinessPhoneExtension { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public string Email { get; set; }

        public DateTime EndDate { get; set; }

        public string FirstName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }

        public string Gender { get; set; }

        public Int32 HID { get; set; }

        public Guid ID { get; set; }

        public string Initials { get; set; }

        public bool? IsMailingExcluded { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }

        public string JobTitleDescription { get; set; }

        public string Language { get; set; }

        public string LastName { get; set; }

        public string MarketingNotes { get; set; }

        public string MiddleName { get; set; }

        public string Mobile { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Nationality { get; set; }

        public string Notes { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }

        public Guid Person { get; set; }

        public string Phone { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }

        public byte[] Picture { get; set; }

        public string PictureName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime StartDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }

        public string Title { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costcenter
    {

        public bool? Active { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class CostTransaction
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public double? Amount { get; set; }

        public double? AmountFC { get; set; }

        public Guid Attachment { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public DateTime Date { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }

        public Guid Employee { get; set; }

        public Int32 EntryNumber { get; set; }

        public string ErrorText { get; set; }
        public Guid Expense { get; set; }

        public string ExpenseDescription { get; set; }

        public Int16 HourStatus { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public double? Price { get; set; }

        public double? PriceFC { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ProjectAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public Guid Subscription { get; set; }

        public Guid SubscriptionAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costunit
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Currency
    {

        public double AmountPrecision { get; set; }

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public DateTime Modified { get; set; }

        public double PricePrecision { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Department
    {

        public string Code { get; set; }

        public string Costcenter { get; set; }

        public string CostcenterDescription { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DepreciationMethod
    {

        public double? Amount { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string DepreciationInterval { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public double? MaxPercentage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public double? Percentage { get; set; }

        public double? Percentage2 { get; set; }

        public Int16 Periods { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        public Int16 Years { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DirectDebitMandate
    {

        public Guid Account { get; set; }

        public Guid BankAccount { get; set; }

        public DateTime CancellationDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public byte? FirstSend { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int16 PaymentType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Reference { get; set; }

        public DateTime SignatureDate { get; set; }

        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {

        public Int32 BlockingStatus { get; set; }

        public Int32 Code { get; set; }

        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }

        public Guid Customer { get; set; }

        public string Description { get; set; }

        public Int64 HID { get; set; }

        public bool? Main { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string SiretNumber { get; set; }

        public DateTime StartDate { get; set; }

        public Int16 Status { get; set; }

        public string TaxOfficeNumber { get; set; }

        public string TaxReferenceNumber { get; set; }

        public string VATNumber { get; set; }

        public string Website { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Document
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public double? AmountFC { get; set; }

        public string Body { get; set; }

        public Guid Category { get; set; }

        public string CategoryDescription { get; set; }

        public Guid Contact { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime DocumentDate { get; set; }

        public Guid DocumentFolder { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }

        public Guid FinancialTransactionEntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasEmptyBody { get; set; }

        public Int32 HID { get; set; }

        public Guid ID { get; set; }

        public string Language { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Opportunity { get; set; }

        public Int32 SalesInvoiceNumber { get; set; }

        public Int32 SalesOrderNumber { get; set; }

        public Int32 ShopOrderNumber { get; set; }

        public string Subject { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentAttachment
    {

        public byte[] Attachment { get; set; }

        public Guid Document { get; set; }

        public string FileName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double FileSize { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentCategory
    {

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentFolder
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid ParentFolder { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentType
    {

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public bool DocumentIsCreatable { get; set; }

        public bool DocumentIsDeletable { get; set; }

        public bool DocumentIsUpdatable { get; set; }

        public bool DocumentIsViewable { get; set; }

        public Int32 ID { get; set; }

        public DateTime Modified { get; set; }

        public Int32 TypeCategory { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentTypeCategory
    {

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public Int32 ID { get; set; }

        public DateTime Modified { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employee
    {

        public byte? ActiveEmployment { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressStreet { get; set; }

        public string AddressStreetNumber { get; set; }

        public string AddressStreetNumberSuffix { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthName { get; set; }

        public string BirthNamePrefix { get; set; }

        public string BirthPlace { get; set; }

        public string BusinessEmail { get; set; }

        public string BusinessFax { get; set; }

        public string BusinessMobile { get; set; }

        public string BusinessPhone { get; set; }

        public string BusinessPhoneExtension { get; set; }

        public string CASONumber { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        public string Country { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Guid Customer { get; set; }

        public Int32 Division { get; set; }

        public string Email { get; set; }

        public Int32 EmployeeHID { get; set; }

        public DateTime EndDate { get; set; }

        public string FirstName { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public Int32 HID { get; set; }

        public Guid ID { get; set; }

        public string Initials { get; set; }

        public bool IsActive { get; set; }

        public string Language { get; set; }

        public string LastName { get; set; }

        public string LocationDescription { get; set; }

        public Guid Manager { get; set; }

        public DateTime MaritalDate { get; set; }

        public Int16 MaritalStatus { get; set; }

        public string MiddleName { get; set; }

        public string Mobile { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Municipality { get; set; }
        public Int16 NameComposition { get; set; }

        public string Nationality { get; set; }

        public string NickName { get; set; }

        public string Notes { get; set; }

        public string PartnerName { get; set; }

        public string PartnerNamePrefix { get; set; }

        public Guid Person { get; set; }

        public string Phone { get; set; }

        public string PhoneExtension { get; set; }

        public string PictureFileName { get; set; }

        public string PictureUrl { get; set; }

        public string Postcode { get; set; }

        public string PrivateEmail { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime StartDate { get; set; }

        public string State { get; set; }

        public string Title { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employment
    {

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        public string EmployeeFullName { get; set; }

        public Int32 EmployeeHID { get; set; }

        public DateTime EndDate { get; set; }

        public Int32 HID { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public Int32 ReasonEnd { get; set; }

        public string ReasonEndDescription { get; set; }

        public Int32 ReasonEndFlex { get; set; }

        public string ReasonEndFlexDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContract
    {

        public Int32 ContractFlexPhase { get; set; }

        public string ContractFlexPhaseDescription { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        public Guid Employee { get; set; }

        public string EmployeeFullName { get; set; }

        public Int32 EmployeeHID { get; set; }

        public Int32 EmployeeType { get; set; }

        public string EmployeeTypeDescription { get; set; }

        public Guid Employment { get; set; }

        public Int32 EmploymentHID { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public DateTime ProbationEndDate { get; set; }

        public Int32 ProbationPeriod { get; set; }

        public Int32 ReasonContract { get; set; }

        public string ReasonContractDescription { get; set; }

        public Int32 Sequence { get; set; }

        public DateTime StartDate { get; set; }

        public Int32 Type { get; set; }

        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContractFlexPhase
    {

        public string Description { get; set; }

        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentEndReason
    {

        public string Description { get; set; }

        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentOrganization
    {

        public string CostCenter { get; set; }

        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        public string CostUnitDescription { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Guid Department { get; set; }

        public string DepartmentCode { get; set; }

        public string DepartmentDescription { get; set; }

        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        public string EmployeeFullName { get; set; }

        public Int32 EmployeeHID { get; set; }

        public Guid Employment { get; set; }

        public Int32 EmploymentHID { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        public Guid JobTitle { get; set; }

        public string JobTitleCode { get; set; }

        public string JobTitleDescription { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentSalary
    {

        public double? AverageDaysPerWeek { get; set; }

        public double? AverageHoursPerWeek { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        public string EmployeeFullName { get; set; }

        public Int32 EmployeeHID { get; set; }

        public Guid Employment { get; set; }

        public Int32 EmploymentHID { get; set; }

        public Int32 EmploymentSalaryType { get; set; }

        public string EmploymentSalaryTypeDescription { get; set; }

        public DateTime EndDate { get; set; }

        public double? FulltimeAmount { get; set; }

        public double? HourlyWage { get; set; }

        public Guid ID { get; set; }

        public double? InternalRate { get; set; }

        public Int32 JobLevel { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public double? ParttimeAmount { get; set; }

        public double? ParttimeFactor { get; set; }

        public string Scale { get; set; }

        public Guid Schedule { get; set; }

        public string ScheduleCode { get; set; }

        public string ScheduleDescription { get; set; }

        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ExchangeRate
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public double? Rate { get; set; }

        public string SourceCurrency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SourceCurrencyDescription { get; set; }

        public DateTime StartDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrencyDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class FinancialPeriod
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EndDate { get; set; }

        public Int16 FinPeriod { get; set; }

        public Int16 FinYear { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class GeneralJournalEntry
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        public double? ExchangeRate { get; set; }

        public Int16 FinancialPeriod { get; set; }

        public Int16 FinancialYear { get; set; }

        public IEnumerable<GeneralJournalEntryLine> GeneralJournalEntryLines { get; set; }

        public string JournalCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        public bool? Reversal { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GeneralJournalEntryLine
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountVATDC { get; set; }

        public double? AmountVATFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public Guid EntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
        public Guid OffsetID { get; set; }

        public Int32 OurRef { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountFC { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATType { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class GLAccount
    {

        public Int16 AssimilatedVATBox { get; set; }

        public string BalanceSide { get; set; }

        public string BalanceType { get; set; }

        public Int32 BelcotaxType { get; set; }

        public string Code { get; set; }

        public bool? Compress { get; set; }

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public byte ExcludeVATListing { get; set; }

        public double? ExpenseNonDeductiblePercentage { get; set; }

        public Guid ID { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? Matching { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid PrivateGLAccount { get; set; }

        public double? PrivatePercentage { get; set; }

        public string ReportingCode { get; set; }

        public bool? RevalueCurrency { get; set; }

        public string SearchCode { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        public byte? UseCostcenter { get; set; }

        public byte? UseCostunit { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }

        public string VATGLAccountType { get; set; }

        public Guid VATNonDeductibleGLAccount { get; set; }

        public double? VATNonDeductiblePercentage { get; set; }

        public string VATSystem { get; set; }

        public Guid YearEndCostGLAccount { get; set; }

        public Guid YearEndReflectionGLAccount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLClassification
    {

        public bool? Abstract { get; set; }

        public string Balance { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public bool? IsTupleSubElement { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Name { get; set; }

        public bool? Nillable { get; set; }

        public Guid Parent { get; set; }

        public string PeriodType { get; set; }

        public string SubstitutionGroup { get; set; }

        public Guid TaxonomyNamespace { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxonomyNamespaceDescription { get; set; }

        public Guid Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLScheme
    {
        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte Main { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

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

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class HourCostType
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUser
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid InvolvedUserRole { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvolvedUserRoleDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid User { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string UserFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUserRole
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 DescriptionTermID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Item
    {

        public string Class_01 { get; set; }

        public string Class_02 { get; set; }

        public string Class_03 { get; set; }

        public string Class_04 { get; set; }

        public string Class_05 { get; set; }

        public string Code { get; set; }

        public byte CopyRemarks { get; set; }

        public string CostPriceCurrency { get; set; }

        public double? CostPriceNew { get; set; }

        public double? CostPriceStandard { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EndDate { get; set; }

        public string ExtraDescription { get; set; }

        public bool? FreeBoolField_01 { get; set; }

        public bool? FreeBoolField_02 { get; set; }

        public bool? FreeBoolField_03 { get; set; }

        public bool? FreeBoolField_04 { get; set; }

        public bool? FreeBoolField_05 { get; set; }

        public DateTime FreeDateField_01 { get; set; }

        public DateTime FreeDateField_02 { get; set; }

        public DateTime FreeDateField_03 { get; set; }

        public DateTime FreeDateField_04 { get; set; }

        public DateTime FreeDateField_05 { get; set; }

        public double? FreeNumberField_01 { get; set; }

        public double? FreeNumberField_02 { get; set; }

        public double? FreeNumberField_03 { get; set; }

        public double? FreeNumberField_04 { get; set; }

        public double? FreeNumberField_05 { get; set; }

        public double? FreeNumberField_06 { get; set; }

        public double? FreeNumberField_07 { get; set; }

        public double? FreeNumberField_08 { get; set; }

        public string FreeTextField_01 { get; set; }

        public string FreeTextField_02 { get; set; }

        public string FreeTextField_03 { get; set; }

        public string FreeTextField_04 { get; set; }

        public string FreeTextField_05 { get; set; }

        public string FreeTextField_06 { get; set; }

        public string FreeTextField_07 { get; set; }

        public string FreeTextField_08 { get; set; }

        public string FreeTextField_09 { get; set; }

        public string FreeTextField_10 { get; set; }

        public Guid GLCosts { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }

        public Guid GLRevenue { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }

        public Guid GLStock { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }

        public Guid ID { get; set; }

        public byte IsBatchItem { get; set; }

        public byte IsBatchNumberItem { get; set; }

        public bool? IsFractionAllowedItem { get; set; }

        public byte IsMakeItem { get; set; }

        public byte IsNewContract { get; set; }

        public byte IsOnDemandItem { get; set; }

        public bool? IsPackageItem { get; set; }

        public bool? IsPurchaseItem { get; set; }

        public byte IsRegistrationCodeItem { get; set; }

        public bool? IsSalesItem { get; set; }

        public bool? IsSerialItem { get; set; }

        public bool? IsSerialNumberItem { get; set; }

        public bool? IsStockItem { get; set; }

        public bool? IsSubcontractedItem { get; set; }

        public byte IsTime { get; set; }

        public byte IsWebshopItem { get; set; }

        public Guid ItemGroup { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public string SalesVatCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVatCodeDescription { get; set; }

        public string SearchCode { get; set; }

        public Int32 SecurityLevel { get; set; }

        public DateTime StartDate { get; set; }

        public string Unit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemGroup
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid GLCosts { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }

        public Guid GLPurchaseAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountDescription { get; set; }

        public Guid GLPurchasePriceDifference { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceDescr { get; set; }

        public Guid GLRevenue { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }

        public Guid GLStock { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }

        public Guid GLStockVariance { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceDescription { get; set; }

        public Guid ID { get; set; }

        public byte IsDefault { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemVersion
    {

        public double? BatchQuantity { get; set; }

        public double? CalculatedCostPrice { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte IsDefault { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public Int32 LeadTime { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public Int16 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        public Int32 VersionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ItemWarehouse
    {

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Guid DefaultStorageLocation { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public bool? ItemIsFractionAllowedItem { get; set; }

        public string ItemUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnitDescription { get; set; }

        public double? MaximumStock { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public double? ReorderPoint { get; set; }

        public double? SafetyStock { get; set; }

        public Guid Warehouse { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobGroup
    {

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobTitle
    {

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public string JobCode { get; set; }

        public Guid JobGroup { get; set; }

        public string JobGroupCode { get; set; }

        public string JobGroupDescription { get; set; }

        public Int32 JobLevelFrom { get; set; }

        public Int32 JobLevelTo { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Journal
    {

        public bool? AllowVariableCurrency { get; set; }

        public bool? AllowVariableExchangeRate { get; set; }

        public bool? AllowVAT { get; set; }

        public bool? AutoSave { get; set; }

        public Guid Bank { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountBICCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountCountry { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountIBAN { get; set; }

        public Guid BankAccountID { get; set; }

        public string BankAccountIncludingMask { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSEPA { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSepaDirectDebit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 GLAccountType { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid PaymentInTransitAccount { get; set; }

        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period,Journal")]
    public class JournalStatus
    {

        public string Journal { get; set; }

        public string JournalDescription { get; set; }

        public Int32 JournalType { get; set; }

        public string JournalTypeDescription { get; set; }

        public Int32 Period { get; set; }

        public Int32 Status { get; set; }

        public string StatusDescription { get; set; }

        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Layout
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Subject { get; set; }

        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Mailbox
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 ForDivision { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ForDivisionDescription { get; set; }

        public Guid ID { get; set; }

        [JsonProperty(PropertyName = "Mailbox")]
        public string MailboxProperty { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public byte Publish { get; set; }

        public Int16 Type { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessage
    {

        public Guid Bank { get; set; }

        public string BankAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public Int32 ForDivision { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int16 Operation { get; set; }

        public Guid OriginalMessage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OriginalMessageSubject { get; set; }

        public Guid PartnerKey { get; set; }

        public double? Quantity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid RecipientAccount { get; set; }

        public byte RecipientDeleted { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailbox { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailboxDescription { get; set; }

        public Guid RecipientMailboxID { get; set; }

        public Int16 RecipientStatus { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientStatusDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SenderAccount { get; set; }

        public DateTime SenderDateSent { get; set; }

        public byte SenderDeleted { get; set; }

        public string SenderIPAddress { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailbox { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailboxDescription { get; set; }

        public Guid SenderMailboxID { get; set; }

        public string Subject { get; set; }

        public string SynchronizationCode { get; set; }

        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessageAttachment
    {

        public byte[] Attachment { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AttachmentFileExtension { get; set; }

        public string AttachmentFileName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int64 FileSize { get; set; }

        public Guid ID { get; set; }

        public Guid MailMessageID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid RecipientAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SenderAccount { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ManufacturingTimeTransaction
    {

        public Int16 Activity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public DateTime Date { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        public double? Hours { get; set; }

        public Guid ID { get; set; }

        public byte? IsOperationFinished { get; set; }

        public double? LaborHours { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public double? PercentComplete { get; set; }

        public double? Quantity { get; set; }

        public Guid RoutingStepPlan { get; set; }

        public Guid ShopOrder { get; set; }

        public Int16 Status { get; set; }

        public Guid TimedTimeTransaction { get; set; }

        public Guid WorkCenter { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalanceAfterEntry
    {

        public double? Amount { get; set; }

        public string BalanceSide { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public string GLAccountCode { get; set; }

        public string GLAccountDescription { get; set; }

        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalancePreviousYearAfterEntry
    {

        public double? Amount { get; set; }

        public string BalanceSide { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public string GLAccountCode { get; set; }

        public string GLAccountDescription { get; set; }

        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalanceProcessed
    {

        public double? Amount { get; set; }

        public string BalanceSide { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public string GLAccountCode { get; set; }

        public string GLAccountDescription { get; set; }

        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalancePreviousYearProcessed
    {

        public double? Amount { get; set; }

        public string BalanceSide { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public string GLAccountCode { get; set; }

        public string GLAccountDescription { get; set; }

        public Int32 ReportingYear { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Operation
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public byte HasSuppliers { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public string Searchcode { get; set; }

        public Int16 Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class OperationResource
    {

        public Guid Account { get; set; }

        public double? AttendedPercentage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public double? EfficiencyPercentage { get; set; }

        public Guid ID { get; set; }

        public byte? IsPrimary { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Operation { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }

        public Int32 PurchaseLeadDays { get; set; }

        public string PurchaseUnit { get; set; }

        public string PurchaseVATCode { get; set; }

        public double? Run { get; set; }

        public Int16 RunMethod { get; set; }

        public double? Setup { get; set; }

        public string SetupUnit { get; set; }

        public Int16 Type { get; set; }

        public Guid Workcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Opportunity
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public DateTime ActionDate { get; set; }

        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public Guid Campaign { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CampaignDescription { get; set; }

        public DateTime CloseDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid LeadSource { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string LeadSourceDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Name { get; set; }

        public string NextAction { get; set; }

        public string Notes { get; set; }

        public Guid OpportunityStage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OpportunityStageDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 OpportunityStatus { get; set; }

        public Guid Owner { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerFullName { get; set; }

        public double? Probability { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? RateFC { get; set; }

        public Guid ReasonCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCodeDescription { get; set; }

        public Guid SalesType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class OpportunityContact
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid AccountMainContact { get; set; }

        public string AccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 AllowMailing { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthName { get; set; }

        public string BirthNamePrefix { get; set; }

        public string BirthPlace { get; set; }

        public string BusinessEmail { get; set; }

        public string BusinessFax { get; set; }

        public string BusinessMobile { get; set; }

        public string BusinessPhone { get; set; }

        public string BusinessPhoneExtension { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }

        public Guid Contact { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public string Email { get; set; }

        public DateTime EndDate { get; set; }

        public string FirstName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }

        public string Gender { get; set; }

        public Int32 HID { get; set; }

        public Guid ID { get; set; }

        public string Initials { get; set; }

        public bool? IsMailingExcluded { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }

        public string JobTitleDescription { get; set; }

        public string Language { get; set; }

        public string LastName { get; set; }

        public string MarketingNotes { get; set; }

        public string MiddleName { get; set; }

        public string Mobile { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Nationality { get; set; }

        public string Notes { get; set; }

        public Guid Opportunity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }

        public Guid Person { get; set; }

        public string Phone { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }

        public byte[] Picture { get; set; }

        public string PictureName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime StartDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }

        public string Title { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrencyCode")]
    public class OutstandingInvoiceOverview
    {

        public string CurrencyCode { get; set; }

        public double OutstandingPayableInvoiceAmount { get; set; }

        public double OutstandingPayableInvoiceCount { get; set; }

        public double OutstandingReceivableInvoiceAmount { get; set; }

        public double OutstandingReceivableInvoiceCount { get; set; }

        public double OverduePayableInvoiceAmount { get; set; }

        public double OverduePayableInvoiceCount { get; set; }

        public double OverdueReceivableInvoiceAmount { get; set; }

        public double OverdueReceivableInvoiceCount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class Payable
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public double Amount { get; set; }

        public double AmountInTransit { get; set; }

        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public Int32 EntryNumber { get; set; }

        public Int64 HID { get; set; }

        public Guid Id { get; set; }

        public DateTime InvoiceDate { get; set; }

        public Int32 InvoiceNumber { get; set; }

        public string JournalCode { get; set; }

        public string JournalDescription { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PaymentCondition
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public Guid CreditManagementScenario { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioDescription { get; set; }

        public string Description { get; set; }

        public string DiscountCalculation { get; set; }

        public Int32 DiscountPaymentDays { get; set; }

        public double? DiscountPercentage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int32 PaymentDays { get; set; }

        public string PaymentDiscountType { get; set; }

        public Int32 PaymentEndOfMonths { get; set; }

        public string PaymentMethod { get; set; }

        public double? Percentage { get; set; }

        public string VATCalculation { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period")]
    public class PeriodRevenue
    {

        public double Amount { get; set; }

        public Int32 Period { get; set; }

        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PriceList
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }

        public Int16 Entity { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("InvoiceID")]
    public class PrintedSalesInvoice
    {

        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        public string DocumentCreationError { get; set; }

        public string DocumentCreationSuccess { get; set; }

        public Guid DocumentLayout { get; set; }

        public string EmailCreationError { get; set; }

        public string EmailCreationSuccess { get; set; }

        public Guid EmailLayout { get; set; }

        public string ExtraText { get; set; }

        public DateTime InvoiceDate { get; set; }

        public Guid InvoiceID { get; set; }

        public string PostboxMessageCreationError { get; set; }

        public string PostboxMessageCreationSuccess { get; set; }

        public Guid PostboxSender { get; set; }

        public Int32 ReportingPeriod { get; set; }

        public Int32 ReportingYear { get; set; }

        public bool? SendEmailToCustomer { get; set; }

        public bool? SendInvoiceToCustomerPostbox { get; set; }

        public bool? SendOutputBasedOnAccount { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("OrderId")]
    public class PrintedSalesOrder
    {

        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        public string DocumentCreationError { get; set; }

        public string DocumentCreationSuccess { get; set; }

        public Guid DocumentLayout { get; set; }

        public string EmailCreationError { get; set; }

        public string EmailCreationSuccess { get; set; }

        public Guid EmailLayout { get; set; }

        public string ExtraText { get; set; }

        public Guid OrderId { get; set; }

        public bool? SendEmailToCustomer { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProductionArea
    {

        public string Code { get; set; }

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte IsDefault { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrentYear")]
    public class ProfitLossOverview
    {

        public double CostsCurrentPeriod { get; set; }

        public double CostsCurrentYear { get; set; }

        public double CostsPreviousYear { get; set; }

        public double CostsPreviousYearPeriod { get; set; }

        public string CurrencyCode { get; set; }

        public Int32 CurrentPeriod { get; set; }

        public Int32 CurrentYear { get; set; }

        public Int32 PreviousYear { get; set; }

        public Int32 PreviousYearPeriod { get; set; }

        public double ResultCurrentPeriod { get; set; }
        public double ResultCurrentYear { get; set; }
        public double ResultPreviousYear { get; set; }

        public double ResultPreviousYearPeriod { get; set; }

        public double RevenueCurrentPeriod { get; set; }

        public double RevenueCurrentYear { get; set; }

        public double RevenuePreviousYear { get; set; }

        public double RevenuePreviousYearPeriod { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Project
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        public Guid AccountContact { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public bool? AllowAdditionalInvoicing { get; set; }

        public bool? BlockEntry { get; set; }

        public bool? BlockRebilling { get; set; }

        public double? BudgetedAmount { get; set; }

        public double? BudgetedCosts { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectHourBudget> BudgetedHoursPerHourType { get; set; }

        public double? BudgetedRevenue { get; set; }

        public Int16 BudgetType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetTypeDescription { get; set; }

        public Guid Classification { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostsAmountFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string CustomerPOnumber { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionName { get; set; }

        public DateTime EndDate { get; set; }

        public Guid FixedPriceItem { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string FixedPriceItemDescription { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool InvoiceAsQuoted { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectTerm> InvoiceTerms { get; set; }

        public Guid Manager { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ManagerFullname { get; set; }

        public double? MarkupPercentage { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Guid PrepaidItem { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidItemDescription { get; set; }

        public Int16 PrepaidType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidTypeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionEmployee> ProjectRestrictionEmployees { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionItem> ProjectRestrictionItems { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionRebilling> ProjectRestrictionRebillings { get; set; }

        public double? SalesTimeQuantity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SourceQuotation { get; set; }

        public DateTime StartDate { get; set; }
        public double? TimeQuantityToAlert { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        public bool? UseBillingMilestones { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ProjectBudgetType
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }

        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectHourBudget
    {

        public double? Budget { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionEmployee
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EmployeeHID { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionItem
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public byte? ItemIsTime { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionRebilling
    {

        public Guid CostTypeRebill { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectTerm
    {

        public double? Amount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Deliverable { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public DateTime InvoiceDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class PurchaseEntry
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        public Int32 BatchNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime EntryDate { get; set; }

        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }
        public string ExternalLinkReference { get; set; }

        public Int32 InvoiceNumber { get; set; }

        public string Journal { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int32 OrderNumber { get; set; }

        public string PaymentCondition { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        public Int32 ProcessNumber { get; set; }

        public IEnumerable<PurchaseEntryLine> PurchaseEntryLines { get; set; }

        public double? Rate { get; set; }

        public Int16 ReportingPeriod { get; set; }

        public Int16 ReportingYear { get; set; }

        public bool? Reversal { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public Guid Supplier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        public double? VATAmountFC { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseEntryLine
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid EntryID { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        public string Notes { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public string SerialNumber { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        public Guid TrackingNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        public double? VATAmountFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }

        public double? VATBaseAmountFC { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class Receivable
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public double Amount { get; set; }

        public double AmountInTransit { get; set; }

        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public Int32 EntryNumber { get; set; }

        public Int64 HID { get; set; }

        public Guid Id { get; set; }

        public DateTime InvoiceDate { get; set; }

        public Int32 InvoiceNumber { get; set; }

        public string JournalCode { get; set; }

        public string JournalDescription { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentCosts
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public double AmountApproved { get; set; }

        public double AmountDraft { get; set; }

        public double AmountRejected { get; set; }

        public double AmountSubmitted { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime Date { get; set; }

        public Guid EntryId { get; set; }

        public Guid Expense { get; set; }

        public string ExpenseDescription { get; set; }

        public Int32 Id { get; set; }

        public string ItemCode { get; set; }

        public string ItemDescription { get; set; }

        public Guid ItemId { get; set; }

        public string Notes { get; set; }

        public string ProjectCode { get; set; }

        public string ProjectDescription { get; set; }

        public Guid ProjectId { get; set; }

        public double QuantityApproved { get; set; }

        public double QuantityDraft { get; set; }

        public double QuantityRejected { get; set; }

        public double QuantitySubmitted { get; set; }

        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentHours
    {

        public string AccountCode { get; set; }

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public Guid Activity { get; set; }

        public string ActivityDescription { get; set; }

        public DateTime Date { get; set; }

        public Guid EntryId { get; set; }

        public double HoursApproved { get; set; }

        public double HoursApprovedBillable { get; set; }

        public double HoursDraft { get; set; }

        public double HoursDraftBillable { get; set; }

        public double HoursRejected { get; set; }

        public double HoursRejectedBillable { get; set; }

        public double HoursSubmitted { get; set; }

        public double HoursSubmittedBillable { get; set; }

        public Int32 Id { get; set; }

        public string ItemCode { get; set; }

        public string ItemDescription { get; set; }

        public Guid ItemId { get; set; }

        public string Notes { get; set; }

        public string ProjectCode { get; set; }

        public string ProjectDescription { get; set; }

        public Guid ProjectId { get; set; }

        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReportingBalance
    {

        public double? Amount { get; set; }

        public double? AmountCredit { get; set; }

        public double? AmountDebit { get; set; }

        public string BalanceType { get; set; }

        public string CostCenterCode { get; set; }

        public string CostCenterDescription { get; set; }

        public string CostUnitCode { get; set; }

        public string CostUnitDescription { get; set; }

        public Int32 Count { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public string GLAccountCode { get; set; }

        public string GLAccountDescription { get; set; }

        public Int64 ID { get; set; }

        public Int32 ReportingPeriod { get; set; }

        public Int32 ReportingYear { get; set; }

        public Int32 Status { get; set; }

        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class SalesEntry
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        public Int32 BatchNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public Guid Customer { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime EntryDate { get; set; }

        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkReference { get; set; }

        public Int32 InvoiceNumber { get; set; }

        public string Journal { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int32 OrderNumber { get; set; }

        public string PaymentCondition { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public string PaymentReference { get; set; }
        public Int32 ProcessNumber { get; set; }

        public double? Rate { get; set; }

        public Int16 ReportingPeriod { get; set; }

        public Int16 ReportingYear { get; set; }

        public bool? Reversal { get; set; }

        public IEnumerable<SalesEntryLine> SalesEntryLines { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        public double? VATAmountFC { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesEntryLine
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid EntryID { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        public string Notes { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public string SerialNumber { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        public Guid TrackingNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        public double? VATAmountFC { get; set; }

        public double? VATBaseAmountDC { get; set; }

        public double? VATBaseAmountFC { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("InvoiceID")]
    public class SalesInvoice
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime InvoiceDate { get; set; }

        public Guid InvoiceID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 InvoiceNumber { get; set; }

        public Guid InvoiceTo { get; set; }

        public Guid InvoiceToContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

        public string Journal { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid OrderedBy { get; set; }

        public Guid OrderedByContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        public Int32 OrderNumber { get; set; }

        public string PaymentCondition { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public string PaymentReference { get; set; }

        public string Remarks { get; set; }

        public IEnumerable<SalesInvoiceLine> SalesInvoiceLines { get; set; }

        public Guid Salesperson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }

        public Int16 StarterSalesInvoiceStatus { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StarterSalesInvoiceStatusDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public Guid TaxSchedule { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesInvoiceLine
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        public string Description { get; set; }

        public double? Discount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }

        public DateTime EndTime { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Guid ID { get; set; }

        public Guid InvoiceID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        public double? NetPrice { get; set; }

        public string Notes { get; set; }

        public Guid Pricelist { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid SalesOrderLine { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }

        public DateTime StartTime { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        public Guid TaxSchedule { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        public string UnitCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        public double? UnitPrice { get; set; }

        public double? VATAmountDC { get; set; }

        public double? VATAmountFC { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("OrderID")]
    public class SalesOrder
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 ApprovalStatus { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ApprovalStatusDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Approved { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Approver { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ApproverFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public Guid DeliverTo { get; set; }

        public Guid DeliverToContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }

        public DateTime DeliveryDate { get; set; }

        public Int16 DeliveryStatus { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryStatusDescription { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public Int16 InvoiceStatus { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceStatusDescription { get; set; }

        public Guid InvoiceTo { get; set; }

        public Guid InvoiceToContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid OrderedBy { get; set; }

        public Guid OrderedByContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        public Guid OrderID { get; set; }

        public Int32 OrderNumber { get; set; }

        public string PaymentCondition { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public string PaymentReference { get; set; }

        public string Remarks { get; set; }

        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }

        public Guid Salesperson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }

        public Guid ShippingMethod { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public Guid TaxSchedule { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }

        public Guid WarehouseID { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesOrderLine
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Description { get; set; }

        public double? Discount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public Guid ItemVersion { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        public double? NetPrice { get; set; }

        public string Notes { get; set; }

        public Guid OrderID { get; set; }

        public Int32 OrderNumber { get; set; }

        public Guid Pricelist { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityDelivered { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInvoiced { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ShopOrder { get; set; }

        public Guid TaxSchedule { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        public string UnitCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        public double? UnitPrice { get; set; }

        public byte UseDropShipment { get; set; }

        public double? VATAmount { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Schedule
    {

        public byte? Active { get; set; }

        public double? AverageHours { get; set; }

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public double? Days { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid Employment { get; set; }

        public Int32 EmploymentHID { get; set; }

        public DateTime EndDate { get; set; }

        public double? Hours { get; set; }

        public Guid ID { get; set; }

        public double? LeaveHoursCompensation { get; set; }

        public byte? Main { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public double? PaymentParttimeFactor { get; set; }

        public Int32 ScheduleType { get; set; }

        public string ScheduleTypeDescription { get; set; }

        public DateTime StartDate { get; set; }

        public Int32 StartWeek { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrder
    {

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EntryDate { get; set; }

        public Guid ID { get; set; }

        public byte IsInPlanning { get; set; }

        public byte IsOnHold { get; set; }

        public byte IsReleased { get; set; }

        public Guid Item { get; set; }

        public Guid ItemVersion { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public DateTime PlannedDate { get; set; }

        public double? PlannedQuantity { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public double? ProducedQuantity { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? ReadyToShipQuantity { get; set; }

        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }

        public Guid ShopOrderMain { get; set; }

        public Int32 ShopOrderMainNumber { get; set; }

        public IEnumerable<ShopOrderMaterialPlan> ShopOrderMaterialPlans { get; set; }

        public Int32 ShopOrderNumber { get; set; }

        public Guid ShopOrderParent { get; set; }

        public Int32 ShopOrderParentNumber { get; set; }

        public IEnumerable<ShopOrderRoutingStepPlan> ShopOrderRoutingStepPlans { get; set; }

        public Int16 Status { get; set; }

        public Int16 Type { get; set; }

        public Guid Warehouse { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlan
    {

        public byte Backflush { get; set; }

        public Int16 CalculatorType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public string DetailDrawing { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public double? PlannedAmountFC { get; set; }

        public DateTime PlannedDate { get; set; }

        public double? PlannedPriceFC { get; set; }

        public double? PlannedQuantity { get; set; }

        public double? PlannedQuantityFactor { get; set; }

        public Guid ShopOrder { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderRoutingStepPlan
    {

        public Guid Account { get; set; }

        public double? AttendedPercentage { get; set; }

        public byte Backflush { get; set; }

        public double? CostPerItem { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public double? EfficiencyPercentage { get; set; }

        public Int16 FactorType { get; set; }

        public Guid ID { get; set; }

        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Operation { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }

        public Guid OperationResource { get; set; }

        public DateTime PlannedEndDate { get; set; }

        public double? PlannedRunHours { get; set; }

        public double? PlannedSetupHours { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public double? PlannedTotalHours { get; set; }

        public string PurchaseUnit { get; set; }

        public double? PurchaseUnitFactor { get; set; }

        public double? PurchaseUnitPriceFC { get; set; }

        public double? PurchaseUnitQuantity { get; set; }

        public Int16 RoutingStepType { get; set; }

        public double? Run { get; set; }

        public Int16 RunMethod { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string RunMethodDescription { get; set; }

        public double? Setup { get; set; }

        public string SetupUnit { get; set; }

        public Guid ShopOrder { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public Int32 SubcontractedLeadDays { get; set; }

        public IEnumerable<ManufacturingTimeTransaction> TimeTransactions { get; set; }

        public double? TotalCostDC { get; set; }

        public Guid Workcenter { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StorageLocation
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte? Main { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Warehouse { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class Subscription
    {

        public bool? BlockEntry { get; set; }

        public DateTime CancellationDate { get; set; }

        public Guid Classification { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public string CustomerPONumber { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EndDate { get; set; }

        public Guid EntryID { get; set; }

        public DateTime InvoicedTo { get; set; }

        public Guid InvoiceTo { get; set; }

        public Guid InvoiceToContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

        public DateTime InvoicingStartDate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Int32 Number { get; set; }

        public Guid OrderedBy { get; set; }

        public Guid OrderedByContactPerson { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        public string PaymentCondition { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public bool Printed { get; set; }

        public Guid ReasonCancelled { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledDescription { get; set; }

        public DateTime StartDate { get; set; }

        public IEnumerable<SubscriptionLine> SubscriptionLines { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionEmployee> SubscriptionRestrictionEmployees { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionItem> SubscriptionRestrictionItems { get; set; }

        public Guid SubscriptionType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionChargeType
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }

        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SubscriptionLine
    {

        public double AmountDC { get; set; }

        public double AmountFC { get; set; }

        public string Costcenter { get; set; }

        public string Costunit { get; set; }

        public string Description { get; set; }

        public double? Discount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid EntryID { get; set; }

        public DateTime FromDate { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        public Int32 LineNumber { get; set; }

        public Int16 LineType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string LineTypeDescription { get; set; }

        public double NetPrice { get; set; }

        public string Notes { get; set; }

        public double Quantity { get; set; }

        public DateTime ToDate { get; set; }

        public string UnitCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        public double UnitPrice { get; set; }

        public double? VATAmountFC { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionReasonCode
    {

        public bool Active { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionEmployee
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Employee { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EmployeeHID { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionItem
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionType
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxComponentRate
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public double Rate { get; set; }

        public DateTime StartDate { get; set; }

        public Guid TaxComponent { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("DocumentID")]
    public class TaxDocument
    {

        public double? Amount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public Guid DocumentID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }

        public DateTime DueDate { get; set; }

        public string Frequency { get; set; }

        public string PayrollDeclarationType { get; set; }

        public Int32 Period { get; set; }

        public string PeriodDescription { get; set; }

        public Guid Request { get; set; }

        public Int32 Status { get; set; }

        public Int32 Type { get; set; }

        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxEmploymentEndFlexCode
    {

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        public DateTime Modified { get; set; }

        public Guid Modifier { get; set; }

        public string ModifierFullName { get; set; }

        public DateTime StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxSchedule
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte IsBlocked { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxScheduleComponent
    {

        public Guid Account { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public Int32 Division { get; set; }

        public Guid GLAccount { get; set; }

        public Guid ID { get; set; }

        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Guid TaxComponent { get; set; }

        public IEnumerable<TaxComponentRate> TaxComponentRates { get; set; }

        public Guid TaxSchedule { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingAccount
    {

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingAccountDetails
    {

        public Guid ID { get; set; }

        public string Name { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingActivitiesAndExpenses
    {

        public string Description { get; set; }

        public Guid ID { get; set; }

        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingItemDetails
    {

        public string Code { get; set; }

        public string Description { get; set; }

        public Guid ID { get; set; }

        public bool IsFractionAllowedItem { get; set; }

        public bool IsSalesItem { get; set; }

        public string SalesCurrency { get; set; }

        public double SalesPrice { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingProject
    {

        public string ProjectCode { get; set; }

        public string ProjectDescription { get; set; }

        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingProjectDetails
    {

        public Guid Account { get; set; }
        public string AccountName { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public Guid ID { get; set; }

        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingRecentAccount
    {

        public Guid AccountId { get; set; }

        public string AccountName { get; set; }

        public DateTime DateLastUsed { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingRecentActivitiesAndExpenses
    {

        public DateTime DateLastUsed { get; set; }

        public string Description { get; set; }

        public Guid ID { get; set; }

        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class TimeAndBillingRecentHourCostType
    {

        public DateTime DateLastUsed { get; set; }

        public string ItemDescription { get; set; }

        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingRecentProject
    {

        public DateTime DateLastUsed { get; set; }

        public string ProjectCode { get; set; }

        public string ProjectDescription { get; set; }

        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public Guid Activity { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ActivityDescription { get; set; }

        public double? Amount { get; set; }

        public double? AmountFC { get; set; }

        public Guid Attachment { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public DateTime Date { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }

        public Guid Employee { get; set; }

        public DateTime EndTime { get; set; }

        public Int32 EntryNumber { get; set; }

        public string ErrorText { get; set; }

        public Int16 HourStatus { get; set; }

        public Guid ID { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public double? Price { get; set; }

        public double? PriceFC { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ProjectAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public DateTime StartTime { get; set; }

        public Guid Subscription { get; set; }

        public Guid SubscriptionAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("EntryID")]
    public class Transaction
    {

        public double? ClosingBalanceFC { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid EntryID { get; set; }

        public Int32 EntryNumber { get; set; }

        public Int16 FinancialPeriod { get; set; }

        public Int16 FinancialYear { get; set; }

        public string JournalCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        public double? OpeningBalanceFC { get; set; }

        public string PaymentConditionCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public Int16 Status { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        public IEnumerable<TransactionLine> TransactionLines { get; set; }

        public Int32 Type { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TransactionLine
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public double? AmountDC { get; set; }

        public double? AmountFC { get; set; }

        public double? AmountVATBaseFC { get; set; }

        public double? AmountVATFC { get; set; }

        public Guid Asset { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        public string CostCenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        public string CostUnit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Currency { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid Document { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        public DateTime DueDate { get; set; }

        public Guid EntryID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        public double? ExchangeRate { get; set; }

        public Int16 FinancialPeriod { get; set; }

        public Int16 FinancialYear { get; set; }

        public Guid GLAccount { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        public Guid ID { get; set; }

        public Int32 InvoiceNumber { get; set; }

        public Guid Item { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        public Int16 LineType { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }
        public Guid OffsetID { get; set; }

        public Int32 OrderNumber { get; set; }

        public double? PaymentDiscountAmount { get; set; }

        public string PaymentReference { get; set; }

        public Guid Project { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        public double? Quantity { get; set; }

        public string SerialNumber { get; set; }

        public Guid Subscription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        public string TrackingNumber { get; set; }

        public string TrackingNumberDescription { get; set; }

        public string VATCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        public double? VATPercentage { get; set; }

        public string VATType { get; set; }

        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Unit
    {

        public bool? Active { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public Guid ID { get; set; }

        public byte? Main { get; set; }

        public string TimeUnit { get; set; }

        public string Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("UserID")]
    public class User
    {

        public DateTime BirthDate { get; set; }

        public string BirthName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public Guid Customer { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }

        public string Email { get; set; }

        public DateTime EndDate { get; set; }

        public string FirstName { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public string Initials { get; set; }

        public string Language { get; set; }

        public DateTime LastLogin { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Mobile { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Nationality { get; set; }

        public string Notes { get; set; }

        public string Phone { get; set; }

        public string PhoneExtension { get; set; }

        public string ProfileCode { get; set; }

        public DateTime StartDate { get; set; }

        public Int32 StartDivision { get; set; }

        public string Title { get; set; }

        public Guid UserID { get; set; }

        public string UserName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<UserRole> UserRoles { get; set; }

        public string UserTypesList { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class UserRole
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public Int32 Role { get; set; }

        public Int32 RoleLevel { get; set; }

        public DateTime StartDate { get; set; }

        public Guid UserID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class VATCode
    {

        public Guid Account { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        public byte? CalculationBasis { get; set; }

        public bool? Charged { get; set; }

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public string EUSalesListing { get; set; }

        public Guid GLDiscountPurchase { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseDescription { get; set; }

        public Guid GLDiscountSales { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesDescription { get; set; }

        public Guid GLToClaim { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimDescription { get; set; }

        public Guid GLToPay { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayCode { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayDescription { get; set; }

        public Guid ID { get; set; }

        public bool? IntraStat { get; set; }

        public bool? IsBlocked { get; set; }

        public string LegalText { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }

        public Int16 TaxReturnType { get; set; }

        public string Type { get; set; }

        public string VatDocType { get; set; }

        public byte VatMargin { get; set; }

        public Int16 VATPartialRatio { get; set; }

        public IEnumerable<VatPercentage> VATPercentages { get; set; }

        public string VATTransactionType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class VatPercentage
    {

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ID { get; set; }

        public Int32 LineNumber { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public double? Percentage { get; set; }

        public DateTime StartDate { get; set; }

        public Guid VATCodeID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Warehouse
    {

        public string Code { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public string EMail { get; set; }

        public Guid ID { get; set; }

        public byte Main { get; set; }

        public Guid ManagerUser { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public byte UseStorageLocations { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Workcenter
    {

        public string Code { get; set; }

        public string Costcenter { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        public string Costunit { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public string Description { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        public double? GeneralBurdenRate { get; set; }

        public Guid ID { get; set; }

        public byte IsLaborBurdenPercent { get; set; }

        public double? LaborBurdenRate { get; set; }

        public double? MachineBurdenRate { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        public string Notes { get; set; }

        public Guid ProductionArea { get; set; }

        public double? RunLaborRate { get; set; }

        public string SearchCode { get; set; }

        public double? SetupLaborRate { get; set; }

        public Int16 Status { get; set; }

        public Int16 Type { get; set; }
    }
}
