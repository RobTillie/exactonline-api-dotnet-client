' Last generated on 2015-11-10 09:58:01 +01:00

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Account

    Public Property [Accountant] As Guid?

    Public Property [AccountManager] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountManagerFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountManagerHID] As Int32?

    Public Property [ActivitySector] As Guid?

    Public Property [ActivitySubSector] As Guid?

    Public Property [AddressLine1] As String

    Public Property [AddressLine2] As String

    Public Property [AddressLine3] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccounts] As IEnumerable(Of BankAccount)

    Public Property [Blocked] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BRIN] As Guid?

    Public Property [BusinessType] As Guid?

    Public Property [CanDropShip] As Boolean?

    Public Property [ChamberOfCommerce] As String

    Public Property [City] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Classification] As String

    Public Property [Classification1] As Guid?

    Public Property [Classification2] As Guid?

    Public Property [Classification3] As Guid?

    Public Property [Classification4] As Guid?

    Public Property [Classification5] As Guid?

    Public Property [Classification6] As Guid?

    Public Property [Classification7] As Guid?

    Public Property [Classification8] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ClassificationDescription] As String

    Public Property [Code] As String

    Public Property [CodeAtSupplier] As String

    Public Property [CompanySize] As Guid?

    Public Property [ConsolidationScenario] As Byte?

    Public Property [ControlledDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String
    Public Property [CostPaid] As Byte

    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CountryName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [CreditLinePurchase] As Double?

    Public Property [CreditLineSales] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CustomerSince] As DateTime?

    Public Property [DiscountPurchase] As Double?

    Public Property [DiscountSales] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DunsNumber] As String

    Public Property [Email] As String

    Public Property [EndDate] As DateTime?

    Public Property [Fax] As String

    Public Property [GLAccountPurchase] As Guid?

    Public Property [GLAccountSales] As Guid?

    Public Property [GLAP] As Guid?

    Public Property [GLAR] As Guid?

    Public Property [ID] As Guid

    Public Property [IntraStatArea] As String

    Public Property [IntraStatDeliveryTerm] As String

    Public Property [IntraStatSystem] As String

    Public Property [IntraStatTransactionA] As String

    Public Property [IntraStatTransactionB] As String

    Public Property [IntraStatTransportMethod] As String

    Public Property [InvoiceAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceAccountName] As String

    Public Property [InvoiceAttachmentType] As Int32?

    Public Property [InvoicingMethod] As Int32?

    Public Property [IsAccountant] As Byte

    Public Property [IsAgency] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsBank] As Boolean?

    Public Property [IsCompetitor] As Byte

    Public Property [IsMailing] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsMember] As Boolean?

    Public Property [IsPilot] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsPurchase] As Boolean?

    Public Property [IsReseller] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsSales] As Boolean?

    Public Property [IsSupplier] As Boolean?

    Public Property [Language] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LanguageDescription] As String

    Public Property [Latitude] As Double?

    Public Property [LeadSource] As Guid?

    Public Property [Logo] As Byte()

    Public Property [LogoFileName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LogoThumbnailUrl] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LogoUrl] As String

    Public Property [Longitude] As Double?

    Public Property [MainContact] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Name] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Parent] As Guid?

    Public Property [PaymentConditionPurchase] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionPurchaseDescription] As String

    Public Property [PaymentConditionSales] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionSalesDescription] As String

    Public Property [Phone] As String

    Public Property [PhoneExtension] As String

    Public Property [Postcode] As String

    Public Property [PriceList] As Guid?

    Public Property [PurchaseCurrency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PurchaseCurrencyDescription] As String

    Public Property [PurchaseLeadDays] As Int32?

    Public Property [PurchaseVATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PurchaseVATCodeDescription] As String

    Public Property [RecepientOfCommissions] As Boolean?

    Public Property [Remarks] As String

    Public Property [Reseller] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ResellerCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ResellerName] As String

    Public Property [SalesCurrency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesCurrencyDescription] As String

    Public Property [SalesTaxSchedule] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesTaxScheduleCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesTaxScheduleDescription] As String

    Public Property [SalesVATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesVATCodeDescription] As String

    Public Property [SearchCode] As String

    Public Property [SecurityLevel] As Int32?

    Public Property [SeparateInvPerProject] As Byte

    Public Property [SeparateInvPerSubscription] As Byte

    Public Property [ShippingLeadDays] As Int32?

    Public Property [ShippingMethod] As Guid?

    Public Property [StartDate] As DateTime?

    Public Property [State] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StateName] As String

    Public Property [Status] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusSince] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As String

    Public Property [VATLiability] As String

    Public Property [VATNumber] As String

    Public Property [Website] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClass

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [CreditManagementScenario] As Guid?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassification

    Public Property [AccountClassificationName] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountClassificationNameDescription] As String

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassificationName

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [SequenceNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ActiveEmployment

    Public Property [AverageDaysPerWeek] As Double?

    Public Property [AverageHoursPerWeek] As Double?

    Public Property [Contract] As Guid?

    Public Property [ContractDocument] As Guid?

    Public Property [ContractEndDate] As DateTime?

    Public Property [ContractProbationEndDate] As DateTime?

    Public Property [ContractProbationPeriod] As Int32?

    Public Property [ContractStartDate] As DateTime?

    Public Property [ContractType] As Int32?

    Public Property [ContractTypeDescription] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Department] As Guid?

    Public Property [DepartmentCode] As String

    Public Property [DepartmentDescription] As String

    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    Public Property [EmployeeFullName] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [EmploymentOrganization] As Guid?

    Public Property [EndDate] As DateTime?

    Public Property [HID] As Int32?

    Public Property [HourlyWage] As Double?

    Public Property [ID] As Guid

    Public Property [InternalRate] As Double?

    Public Property [Jobtitle] As Guid?

    Public Property [JobtitleDescription] As String

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [ReasonEnd] As Int32?

    Public Property [ReasonEndDescription] As String

    Public Property [ReasonEndFlex] As Int32?

    Public Property [ReasonEndFlexDescription] As String

    Public Property [Salary] As Guid?

    Public Property [Schedule] As Guid?

    Public Property [ScheduleAverageHours] As Double?

    Public Property [ScheduleCode] As String

    Public Property [ScheduleDays] As Double?

    Public Property [ScheduleDescription] As String

    Public Property [ScheduleHours] As Double?

    Public Property [StartDate] As DateTime?

    Public Property [StartDateOrganization] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Address

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountIsSupplier] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [AddressLine1] As String

    Public Property [AddressLine2] As String

    Public Property [AddressLine3] As String

    Public Property [City] As String

    Public Property [Contact] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ContactName] As String

    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CountryName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Fax] As String

    Public Property [FreeBoolField_01] As Boolean?

    Public Property [FreeBoolField_02] As Boolean?

    Public Property [FreeBoolField_03] As Boolean?

    Public Property [FreeBoolField_04] As Boolean?

    Public Property [FreeBoolField_05] As Boolean?

    Public Property [FreeDateField_01] As DateTime?

    Public Property [FreeDateField_02] As DateTime?

    Public Property [FreeDateField_03] As DateTime?

    Public Property [FreeDateField_04] As DateTime?

    Public Property [FreeDateField_05] As DateTime?

    Public Property [FreeNumberField_01] As Double?

    Public Property [FreeNumberField_02] As Double?

    Public Property [FreeNumberField_03] As Double?

    Public Property [FreeNumberField_04] As Double?

    Public Property [FreeNumberField_05] As Double?

    Public Property [FreeTextField_01] As String

    Public Property [FreeTextField_02] As String

    Public Property [FreeTextField_03] As String

    Public Property [FreeTextField_04] As String

    Public Property [FreeTextField_05] As String

    Public Property [ID] As Guid

    Public Property [Mailbox] As String

    Public Property [Main] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [NicNumber] As String

    Public Property [Notes] As String

    Public Property [Phone] As String

    Public Property [PhoneExtension] As String

    Public Property [Postcode] As String

    Public Property [State] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StateDescription] As String

    Public Property [Type] As Int16?

    Public Property [Warehouse] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AddressState

    Public Property [Country] As String

    Public Property [DisplayValue] As String

    Public Property [ID] As Guid

    Public Property [Latitude] As Double?

    Public Property [Longitude] As Double?

    Public Property [Name] As String

    Public Property [State] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsPayable

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String

    Public Property [AgeGroup1] As Int32

    Public Property [AgeGroup1Amount] As Double

    Public Property [AgeGroup1Description] As String

    Public Property [AgeGroup2] As Int32

    Public Property [AgeGroup2Amount] As Double

    Public Property [AgeGroup2Description] As String

    Public Property [AgeGroup3] As Int32

    Public Property [AgeGroup3Amount] As Double

    Public Property [AgeGroup3Description] As String

    Public Property [AgeGroup4] As Int32

    Public Property [AgeGroup4Amount] As Double

    Public Property [AgeGroup4Description] As String

    Public Property [CurrencyCode] As String

    Public Property [TotalAmount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsReceivable

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String

    Public Property [AgeGroup1] As Int32

    Public Property [AgeGroup1Amount] As Double

    Public Property [AgeGroup1Description] As String

    Public Property [AgeGroup2] As Int32

    Public Property [AgeGroup2Amount] As Double

    Public Property [AgeGroup2Description] As String

    Public Property [AgeGroup3] As Int32

    Public Property [AgeGroup3Amount] As Double

    Public Property [AgeGroup3Description] As String

    Public Property [AgeGroup4] As Int32

    Public Property [AgeGroup4Amount] As Double

    Public Property [AgeGroup4Description] As String

    Public Property [CurrencyCode] As String

    Public Property [TotalAmount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AgeGroup")>
Public Class AgingOverview

    Public Property [AgeGroup] As Int32

    Public Property [AgeGroupDescription] As String

    Public Property [AmountPayable] As Double

    Public Property [AmountReceivable] As Double

    Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Asset

    Public Property [AlreadyDepreciated] As Byte

    Public Property [AssetFrom] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetFromDescription] As String

    Public Property [AssetGroup] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetGroupDescription] As String

    Public Property [CatalogueValue] As Double?

    Public Property [Code] As String

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [DeductionPercentage] As Double?

    Public Property [DepreciatedAmount] As Double?

    Public Property [DepreciatedPeriods] As Int32?

    Public Property [DepreciatedStartDate] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [EngineEmission] As Int16?

    Public Property [EngineType] As Int16?

    Public Property [GLTransactionLine] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLTransactionLineDescription] As String

    Public Property [ID] As Guid

    Public Property [InvestmentAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvestmentAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvestmentAccountName] As String

    Public Property [InvestmentAmountDC] As Double?

    Public Property [InvestmentAmountFC] As Double?

    Public Property [InvestmentCurrency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvestmentCurrencyDescription] As String

    Public Property [InvestmentDate] As DateTime?

    Public Property [InvestmentDeduction] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Parent] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ParentCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ParentDescription] As String

    Public Property [Picture] As Byte()

    Public Property [PictureFileName] As String

    Public Property [PrimaryMethod] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PrimaryMethodCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PrimaryMethodDescription] As String

    Public Property [ResidualValue] As Double?

    Public Property [StartDate] As DateTime?

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TransactionEntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TransactionEntryNo] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Bank

    Public Property [BankName] As String

    Public Property [BICCode] As String

    Public Property [Country] As String

    Public Property [Created] As DateTime?

    Public Property [Description] As String

    Public Property [Format] As String

    Public Property [HomePageAddress] As String

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    Public Property [Status] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class BankAccount

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Bank] As Guid?

    Public Property [BankAccount] As String

    Public Property [BankAccountHolderName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankName] As String

    Public Property [BICCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Format] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IBAN] As String

    Public Property [ID] As Guid

    Public Property [Main] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class BankEntry

    Public Property [BankEntryLines] As IEnumerable(Of BankEntryLine)

    Public Property [BankStatementDocument] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankStatementDocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankStatementDocumentSubject] As String

    Public Property [ClosingBalanceFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    Public Property [FinancialPeriod] As Int16?

    Public Property [FinancialYear] As Int16?

    Public Property [JournalCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    Public Property [OpeningBalanceFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class BankEntryLine

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [AmountVATFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String
    Public Property [Date] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [EntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryNumber] As Int32?

    Public Property [ExchangeRate] As Double?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OffsetID] As Guid?
    Public Property [OurRef] As Int32?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?

    Public Property [VATType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Budget

    Public Property [AmountDC] As Double?

    Public Property [BudgetScenario] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BudgetScenarioCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BudgetScenarioDescription] As String

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [HID] As Int64?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [ReportingPeriod] As Int16?

    Public Property [ReportingYear] As Int16?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class CashEntry

    Public Property [CashEntryLines] As IEnumerable(Of CashEntryLine)

    Public Property [ClosingBalanceFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    Public Property [FinancialPeriod] As Int16?

    Public Property [FinancialYear] As Int16?

    Public Property [JournalCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    Public Property [OpeningBalanceFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class CashEntryLine

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [AmountVATFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String
    Public Property [Date] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [EntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryNumber] As Int32?

    Public Property [ExchangeRate] As Double?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OffsetID] As Guid?
    Public Property [OurRef] As Int32?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?

    Public Property [VATType] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Contact

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountIsCustomer] As Boolean

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountIsSupplier] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountMainContact] As Guid?

    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressLine2] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreet] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreetNumber] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreetNumberSuffix] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AllowMailing] As Int32?

    Public Property [BirthDate] As DateTime?

    Public Property [BirthName] As String

    Public Property [BirthNamePrefix] As String

    Public Property [BirthPlace] As String

    Public Property [BusinessEmail] As String

    Public Property [BusinessFax] As String

    Public Property [BusinessMobile] As String

    Public Property [BusinessPhone] As String

    Public Property [BusinessPhoneExtension] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [City] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Email] As String

    Public Property [EndDate] As DateTime?

    Public Property [FirstName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [FullName] As String

    Public Property [Gender] As String

    Public Property [HID] As Int32?

    Public Property [ID] As Guid

    Public Property [Initials] As String

    Public Property [IsMailingExcluded] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsMainContact] As Boolean?

    Public Property [JobTitleDescription] As String

    Public Property [Language] As String

    Public Property [LastName] As String

    Public Property [MarketingNotes] As String

    Public Property [MiddleName] As String

    Public Property [Mobile] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Nationality] As String

    Public Property [Notes] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PartnerName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PartnerNamePrefix] As String

    Public Property [Person] As Guid?

    Public Property [Phone] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PhoneExtension] As String

    Public Property [Picture] As Byte()

    Public Property [PictureName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PictureThumbnailUrl] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PictureUrl] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Postcode] As String

    Public Property [SocialSecurityNumber] As String

    Public Property [StartDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [State] As String

    Public Property [Title] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costcenter

    Public Property [Active] As Boolean?

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class CostTransaction

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [Amount] As Double?

    Public Property [AmountFC] As Double?

    Public Property [Attachment] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Date] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DivisionDescription] As String

    Public Property [Employee] As Guid?

    Public Property [EntryNumber] As Int32?

    Public Property [ErrorText] As String
    Public Property [Expense] As Guid?

    Public Property [ExpenseDescription] As String

    Public Property [HourStatus] As Int16?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDivisable] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Price] As Double?

    Public Property [PriceFC] As Double?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [Subscription] As Guid?

    Public Property [SubscriptionAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionAccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costunit

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Currency

    Public Property [AmountPrecision] As Double

    Public Property [Code] As String

    Public Property [Created] As DateTime?

    Public Property [Description] As String

    Public Property [Modified] As DateTime?

    Public Property [PricePrecision] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Department

    Public Property [Code] As String

    Public Property [Costcenter] As String

    Public Property [CostcenterDescription] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DepreciationMethod

    Public Property [Amount] As Double?

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [DepreciationInterval] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [MaxPercentage] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Percentage] As Double?

    Public Property [Percentage2] As Double?

    Public Property [Periods] As Int16?

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    Public Property [Years] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DirectDebitMandate

    Public Property [Account] As Guid?

    Public Property [BankAccount] As Guid?

    Public Property [CancellationDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [FirstSend] As Byte?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [PaymentType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Reference] As String

    Public Property [SignatureDate] As DateTime?

    Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Division

    Public Property [BlockingStatus] As Int32?

    Public Property [Code] As Int32

    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CountryDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CurrencyDescription] As String

    Public Property [Customer] As Guid?

    Public Property [Description] As String

    Public Property [HID] As Int64?

    Public Property [Main] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [SiretNumber] As String

    Public Property [StartDate] As DateTime?

    Public Property [Status] As Int16?

    Public Property [TaxOfficeNumber] As String

    Public Property [TaxReferenceNumber] As String

    Public Property [VATNumber] As String

    Public Property [Website] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Document

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [AmountFC] As Double?

    Public Property [Body] As String

    Public Property [Category] As Guid?

    Public Property [CategoryDescription] As String

    Public Property [Contact] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ContactFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [DocumentDate] As DateTime?

    Public Property [DocumentFolder] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentFolderCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentFolderDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentViewUrl] As String

    Public Property [FinancialTransactionEntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [HasEmptyBody] As Boolean

    Public Property [HID] As Int32?

    Public Property [ID] As Guid

    Public Property [Language] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Opportunity] As Guid?

    Public Property [SalesInvoiceNumber] As Int32?

    Public Property [SalesOrderNumber] As Int32?

    Public Property [ShopOrderNumber] As Int32?

    Public Property [Subject] As String

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentAttachment

    Public Property [Attachment] As Byte()

    Public Property [Document] As Guid

    Public Property [FileName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [FileSize] As Double

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Url] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentCategory

    Public Property [Created] As DateTime?

    Public Property [Description] As String

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentFolder

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [ParentFolder] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentType

    Public Property [Created] As DateTime?

    Public Property [Description] As String

    Public Property [DocumentIsCreatable] As Boolean

    Public Property [DocumentIsDeletable] As Boolean

    Public Property [DocumentIsUpdatable] As Boolean

    Public Property [DocumentIsViewable] As Boolean

    Public Property [ID] As Int32

    Public Property [Modified] As DateTime?

    Public Property [TypeCategory] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentTypeCategory

    Public Property [Created] As DateTime?

    Public Property [Description] As String

    Public Property [ID] As Int32

    Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Employee

    Public Property [ActiveEmployment] As Byte?

    Public Property [AddressLine2] As String

    Public Property [AddressLine3] As String

    Public Property [AddressStreet] As String

    Public Property [AddressStreetNumber] As String

    Public Property [AddressStreetNumberSuffix] As String

    Public Property [BirthDate] As DateTime?

    Public Property [BirthName] As String

    Public Property [BirthNamePrefix] As String

    Public Property [BirthPlace] As String

    Public Property [BusinessEmail] As String

    Public Property [BusinessFax] As String

    Public Property [BusinessMobile] As String

    Public Property [BusinessPhone] As String

    Public Property [BusinessPhoneExtension] As String

    Public Property [CASONumber] As String

    Public Property [City] As String

    Public Property [Code] As String

    Public Property [Country] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Customer] As Guid?

    Public Property [Division] As Int32?

    Public Property [Email] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [FirstName] As String

    Public Property [FullName] As String

    Public Property [Gender] As String

    Public Property [HID] As Int32?

    Public Property [ID] As Guid

    Public Property [Initials] As String

    Public Property [IsActive] As Boolean

    Public Property [Language] As String

    Public Property [LastName] As String

    Public Property [LocationDescription] As String

    Public Property [Manager] As Guid?

    Public Property [MaritalDate] As DateTime?

    Public Property [MaritalStatus] As Int16?

    Public Property [MiddleName] As String

    Public Property [Mobile] As String

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Municipality] As String
    Public Property [NameComposition] As Int16?

    Public Property [Nationality] As String

    Public Property [NickName] As String

    Public Property [Notes] As String

    Public Property [PartnerName] As String

    Public Property [PartnerNamePrefix] As String

    Public Property [Person] As Guid?

    Public Property [Phone] As String

    Public Property [PhoneExtension] As String

    Public Property [PictureFileName] As String

    Public Property [PictureUrl] As String

    Public Property [Postcode] As String

    Public Property [PrivateEmail] As String

    Public Property [SocialSecurityNumber] As String

    Public Property [StartDate] As DateTime?

    Public Property [State] As String

    Public Property [Title] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Employment

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    Public Property [EmployeeFullName] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [HID] As Int32?

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [ReasonEnd] As Int32?

    Public Property [ReasonEndDescription] As String

    Public Property [ReasonEndFlex] As Int32?

    Public Property [ReasonEndFlexDescription] As String

    Public Property [StartDate] As DateTime?

    Public Property [StartDateOrganization] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentContract

    Public Property [ContractFlexPhase] As Int32?

    Public Property [ContractFlexPhaseDescription] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    Public Property [Employee] As Guid?

    Public Property [EmployeeFullName] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [EmployeeType] As Int32?

    Public Property [EmployeeTypeDescription] As String

    Public Property [Employment] As Guid?

    Public Property [EmploymentHID] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [ProbationEndDate] As DateTime?

    Public Property [ProbationPeriod] As Int32?

    Public Property [ReasonContract] As Int32?

    Public Property [ReasonContractDescription] As String

    Public Property [Sequence] As Int32?

    Public Property [StartDate] As DateTime?

    Public Property [Type] As Int32?

    Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentContractFlexPhase

    Public Property [Description] As String

    Public Property [ID] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentEndReason

    Public Property [Description] As String

    Public Property [ID] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentOrganization

    Public Property [CostCenter] As String

    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    Public Property [CostUnitDescription] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Department] As Guid?

    Public Property [DepartmentCode] As String

    Public Property [DepartmentDescription] As String

    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    Public Property [EmployeeFullName] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [Employment] As Guid?

    Public Property [EmploymentHID] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [JobTitle] As Guid?

    Public Property [JobTitleCode] As String

    Public Property [JobTitleDescription] As String

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentSalary

    Public Property [AverageDaysPerWeek] As Double?

    Public Property [AverageHoursPerWeek] As Double?

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    Public Property [EmployeeFullName] As String

    Public Property [EmployeeHID] As Int32?

    Public Property [Employment] As Guid?

    Public Property [EmploymentHID] As Int32?

    Public Property [EmploymentSalaryType] As Int32?

    Public Property [EmploymentSalaryTypeDescription] As String

    Public Property [EndDate] As DateTime?

    Public Property [FulltimeAmount] As Double?

    Public Property [HourlyWage] As Double?

    Public Property [ID] As Guid

    Public Property [InternalRate] As Double?

    Public Property [JobLevel] As Int32?

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [ParttimeAmount] As Double?

    Public Property [ParttimeFactor] As Double?

    Public Property [Scale] As String

    Public Property [Schedule] As Guid?

    Public Property [ScheduleCode] As String

    Public Property [ScheduleDescription] As String

    Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ExchangeRate

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Rate] As Double?

    Public Property [SourceCurrency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SourceCurrencyDescription] As String

    Public Property [StartDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TargetCurrency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TargetCurrencyDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class FinancialPeriod

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [FinPeriod] As Int16?

    Public Property [FinYear] As Int16?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class GeneralJournalEntry

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    Public Property [ExchangeRate] As Double?

    Public Property [FinancialPeriod] As Int16?

    Public Property [FinancialYear] As Int16?

    Public Property [GeneralJournalEntryLines] As IEnumerable(Of GeneralJournalEntryLine)

    Public Property [JournalCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    Public Property [Reversal] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class GeneralJournalEntryLine

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountVATDC] As Double?

    Public Property [AmountVATFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Date] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [EntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryNumber] As Int32?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
    Public Property [OffsetID] As Guid?

    Public Property [OurRef] As Int32?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATBaseAmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATBaseAmountFC] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATType] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class GLAccount

    Public Property [AssimilatedVATBox] As Int16?

    Public Property [BalanceSide] As String

    Public Property [BalanceType] As String

    Public Property [BelcotaxType] As Int32?

    Public Property [Code] As String

    Public Property [Compress] As Boolean?

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ExcludeVATListing] As Byte

    Public Property [ExpenseNonDeductiblePercentage] As Double?

    Public Property [ID] As Guid

    Public Property [IsBlocked] As Boolean?

    Public Property [Matching] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [PrivateGLAccount] As Guid?

    Public Property [PrivatePercentage] As Double?

    Public Property [ReportingCode] As String

    Public Property [RevalueCurrency] As Boolean?

    Public Property [SearchCode] As String

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    Public Property [UseCostcenter] As Byte?

    Public Property [UseCostunit] As Byte?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATDescription] As String

    Public Property [VATGLAccountType] As String

    Public Property [VATNonDeductibleGLAccount] As Guid?

    Public Property [VATNonDeductiblePercentage] As Double?

    Public Property [VATSystem] As String

    Public Property [YearEndCostGLAccount] As Guid?

    Public Property [YearEndReflectionGLAccount] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLClassification

    Public Property [Abstract] As Boolean?

    Public Property [Balance] As String

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [IsTupleSubElement] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Name] As String

    Public Property [Nillable] As Boolean?

    Public Property [Parent] As Guid?

    Public Property [PeriodType] As String

    Public Property [SubstitutionGroup] As String

    Public Property [TaxonomyNamespace] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxonomyNamespaceDescription] As String

    Public Property [Type] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLScheme
    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Main] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [TargetNamespace] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLTransactionType
    Public Property [Description] As String
    Public Property [DescriptionSuffix] As String
    Public Property [ID] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class HourCostType

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [ItemId] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class InvolvedUser

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [InvolvedUserRole] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvolvedUserRoleDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [User] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UserFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class InvolvedUserRole

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [DescriptionTermID] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Item

    Public Property [Class_01] As String

    Public Property [Class_02] As String

    Public Property [Class_03] As String

    Public Property [Class_04] As String

    Public Property [Class_05] As String

    Public Property [Code] As String

    Public Property [CopyRemarks] As Byte

    Public Property [CostPriceCurrency] As String

    Public Property [CostPriceNew] As Double?

    Public Property [CostPriceStandard] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [ExtraDescription] As String

    Public Property [FreeBoolField_01] As Boolean?

    Public Property [FreeBoolField_02] As Boolean?

    Public Property [FreeBoolField_03] As Boolean?

    Public Property [FreeBoolField_04] As Boolean?

    Public Property [FreeBoolField_05] As Boolean?

    Public Property [FreeDateField_01] As DateTime?

    Public Property [FreeDateField_02] As DateTime?

    Public Property [FreeDateField_03] As DateTime?

    Public Property [FreeDateField_04] As DateTime?

    Public Property [FreeDateField_05] As DateTime?

    Public Property [FreeNumberField_01] As Double?

    Public Property [FreeNumberField_02] As Double?

    Public Property [FreeNumberField_03] As Double?

    Public Property [FreeNumberField_04] As Double?

    Public Property [FreeNumberField_05] As Double?

    Public Property [FreeNumberField_06] As Double?

    Public Property [FreeNumberField_07] As Double?

    Public Property [FreeNumberField_08] As Double?

    Public Property [FreeTextField_01] As String

    Public Property [FreeTextField_02] As String

    Public Property [FreeTextField_03] As String

    Public Property [FreeTextField_04] As String

    Public Property [FreeTextField_05] As String

    Public Property [FreeTextField_06] As String

    Public Property [FreeTextField_07] As String

    Public Property [FreeTextField_08] As String

    Public Property [FreeTextField_09] As String

    Public Property [FreeTextField_10] As String

    Public Property [GLCosts] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLCostsCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLCostsDescription] As String

    Public Property [GLRevenue] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLRevenueCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLRevenueDescription] As String

    Public Property [GLStock] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockDescription] As String

    Public Property [ID] As Guid

    Public Property [IsBatchItem] As Byte

    Public Property [IsBatchNumberItem] As Byte

    Public Property [IsFractionAllowedItem] As Boolean?

    Public Property [IsMakeItem] As Byte

    Public Property [IsNewContract] As Byte

    Public Property [IsOnDemandItem] As Byte

    Public Property [IsPackageItem] As Boolean?

    Public Property [IsPurchaseItem] As Boolean?

    Public Property [IsRegistrationCodeItem] As Byte

    Public Property [IsSalesItem] As Boolean?

    Public Property [IsSerialItem] As Boolean?

    Public Property [IsSerialNumberItem] As Boolean?

    Public Property [IsStockItem] As Boolean?

    Public Property [IsSubcontractedItem] As Boolean?

    Public Property [IsTime] As Byte

    Public Property [IsWebshopItem] As Byte

    Public Property [ItemGroup] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemGroupCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemGroupDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [SalesVatCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesVatCodeDescription] As String

    Public Property [SearchCode] As String

    Public Property [SecurityLevel] As Int32?

    Public Property [StartDate] As DateTime?

    Public Property [Unit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UnitDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ItemGroup

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [GLCosts] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLCostsCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLCostsDescription] As String

    Public Property [GLPurchaseAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLPurchaseAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLPurchaseAccountDescription] As String

    Public Property [GLPurchasePriceDifference] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLPurchasePriceDifferenceCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLPurchasePriceDifferenceDescr] As String

    Public Property [GLRevenue] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLRevenueCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLRevenueDescription] As String

    Public Property [GLStock] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockDescription] As String

    Public Property [GLStockVariance] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockVarianceCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLStockVarianceDescription] As String

    Public Property [ID] As Guid

    Public Property [IsDefault] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ItemVersion

    Public Property [BatchQuantity] As Double?

    Public Property [CalculatedCostPrice] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [IsDefault] As Byte

    Public Property [Item] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [LeadTime] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [Type] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    Public Property [VersionNumber] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ItemWarehouse

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [DefaultStorageLocation] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [ItemIsFractionAllowedItem] As Boolean?

    Public Property [ItemUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemUnitDescription] As String

    Public Property [MaximumStock] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [ReorderPoint] As Double?

    Public Property [SafetyStock] As Double?

    Public Property [Warehouse] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class JobGroup

    Public Property [Code] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class JobTitle

    Public Property [Code] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [JobCode] As String

    Public Property [JobGroup] As Guid?

    Public Property [JobGroupCode] As String

    Public Property [JobGroupDescription] As String

    Public Property [JobLevelFrom] As Int32?

    Public Property [JobLevelTo] As Int32?

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Journal

    Public Property [AllowVariableCurrency] As Boolean?

    Public Property [AllowVariableExchangeRate] As Boolean?

    Public Property [AllowVAT] As Boolean?

    Public Property [AutoSave] As Boolean?

    Public Property [Bank] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountBICCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountCountry] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountIBAN] As String

    Public Property [BankAccountID] As Guid?

    Public Property [BankAccountIncludingMask] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountUseSEPA] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankAccountUseSepaDirectDebit] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BankName] As String

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CurrencyDescription] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountType] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [PaymentInTransitAccount] As Guid?

    Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period,Journal")>
Public Class JournalStatus

    Public Property [Journal] As String

    Public Property [JournalDescription] As String

    Public Property [JournalType] As Int32

    Public Property [JournalTypeDescription] As String

    Public Property [Period] As Int32

    Public Property [Status] As Int32

    Public Property [StatusDescription] As String

    Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Layout

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Subject] As String

    Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Mailbox

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [ForDivision] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ForDivisionDescription] As String

    Public Property [ID] As Guid

    Public Property [Mailbox] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Publish] As Byte

    Public Property [Type] As Int16?

    Public Property [ValidFrom] As DateTime?

    Public Property [ValidTo] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessage

    Public Property [Bank] As Guid?

    Public Property [BankAccount] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [ForDivision] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Operation] As Int16?

    Public Property [OriginalMessage] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OriginalMessageSubject] As String

    Public Property [PartnerKey] As Guid?

    Public Property [Quantity] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RecipientAccount] As Guid?

    Public Property [RecipientDeleted] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RecipientMailbox] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RecipientMailboxDescription] As String

    Public Property [RecipientMailboxID] As Guid?

    Public Property [RecipientStatus] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RecipientStatusDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SenderAccount] As Guid?

    Public Property [SenderDateSent] As DateTime?

    Public Property [SenderDeleted] As Byte

    Public Property [SenderIPAddress] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SenderMailbox] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SenderMailboxDescription] As String

    Public Property [SenderMailboxID] As Guid?

    Public Property [Subject] As String

    Public Property [SynchronizationCode] As String

    Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessageAttachment

    Public Property [Attachment] As Byte()

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AttachmentFileExtension] As String

    Public Property [AttachmentFileName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [FileSize] As Int64

    Public Property [ID] As Guid

    Public Property [MailMessageID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RecipientAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SenderAccount] As Guid?

    Public Property [Type] As Int32

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Url] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ManufacturingTimeTransaction

    Public Property [Activity] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Date] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    Public Property [Hours] As Double?

    Public Property [ID] As Guid

    Public Property [IsOperationFinished] As Byte?

    Public Property [LaborHours] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [PercentComplete] As Double?

    Public Property [Quantity] As Double?

    Public Property [RoutingStepPlan] As Guid?

    Public Property [ShopOrder] As Guid?

    Public Property [Status] As Int16?

    Public Property [TimedTimeTransaction] As Guid?

    Public Property [WorkCenter] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceAfterEntry

    Public Property [Amount] As Double?

    Public Property [BalanceSide] As String

    Public Property [Division] As Int32

    Public Property [GLAccount] As Guid

    Public Property [GLAccountCode] As String

    Public Property [GLAccountDescription] As String

    Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalancePreviousYearAfterEntry

    Public Property [Amount] As Double?

    Public Property [BalanceSide] As String

    Public Property [Division] As Int32

    Public Property [GLAccount] As Guid

    Public Property [GLAccountCode] As String

    Public Property [GLAccountDescription] As String

    Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceProcessed

    Public Property [Amount] As Double?

    Public Property [BalanceSide] As String

    Public Property [Division] As Int32

    Public Property [GLAccount] As Guid

    Public Property [GLAccountCode] As String

    Public Property [GLAccountDescription] As String

    Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalancePreviousYearProcessed

    Public Property [Amount] As Double?

    Public Property [BalanceSide] As String

    Public Property [Division] As Int32

    Public Property [GLAccount] As Guid

    Public Property [GLAccountCode] As String

    Public Property [GLAccountDescription] As String

    Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Operation

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [HasSuppliers] As Byte

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Searchcode] As String

    Public Property [Status] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class OperationResource

    Public Property [Account] As Guid?

    Public Property [AttendedPercentage] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EfficiencyPercentage] As Double?

    Public Property [ID] As Guid

    Public Property [IsPrimary] As Byte?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Operation] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OperationDescription] As String

    Public Property [PurchaseLeadDays] As Int32?

    Public Property [PurchaseUnit] As String

    Public Property [PurchaseVATCode] As String

    Public Property [Run] As Double?

    Public Property [RunMethod] As Int16?

    Public Property [Setup] As Double?

    Public Property [SetupUnit] As String

    Public Property [Type] As Int16?

    Public Property [Workcenter] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WorkcenterDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Opportunity

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [ActionDate] As DateTime?

    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [Campaign] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CampaignDescription] As String

    Public Property [CloseDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [LeadSource] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LeadSourceDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Name] As String

    Public Property [NextAction] As String

    Public Property [Notes] As String

    Public Property [OpportunityStage] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OpportunityStageDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OpportunityStatus] As Int32?

    Public Property [Owner] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OwnerFullName] As String

    Public Property [Probability] As Double?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [RateFC] As Double?

    Public Property [ReasonCode] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ReasonCodeDescription] As String

    Public Property [SalesType] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesTypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class OpportunityContact

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountIsCustomer] As Boolean

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountIsSupplier] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountMainContact] As Guid?

    Public Property [AccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressLine2] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreet] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreetNumber] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AddressStreetNumberSuffix] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AllowMailing] As Int32?

    Public Property [BirthDate] As DateTime?

    Public Property [BirthName] As String

    Public Property [BirthNamePrefix] As String

    Public Property [BirthPlace] As String

    Public Property [BusinessEmail] As String

    Public Property [BusinessFax] As String

    Public Property [BusinessMobile] As String

    Public Property [BusinessPhone] As String

    Public Property [BusinessPhoneExtension] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [City] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Code] As String

    Public Property [Contact] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Email] As String

    Public Property [EndDate] As DateTime?

    Public Property [FirstName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [FullName] As String

    Public Property [Gender] As String

    Public Property [HID] As Int32?

    Public Property [ID] As Guid

    Public Property [Initials] As String

    Public Property [IsMailingExcluded] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [IsMainContact] As Boolean?

    Public Property [JobTitleDescription] As String

    Public Property [Language] As String

    Public Property [LastName] As String

    Public Property [MarketingNotes] As String

    Public Property [MiddleName] As String

    Public Property [Mobile] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Nationality] As String

    Public Property [Notes] As String

    Public Property [Opportunity] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PartnerName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PartnerNamePrefix] As String

    Public Property [Person] As Guid?

    Public Property [Phone] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PhoneExtension] As String

    Public Property [Picture] As Byte()

    Public Property [PictureName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PictureThumbnailUrl] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PictureUrl] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Postcode] As String

    Public Property [SocialSecurityNumber] As String

    Public Property [StartDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [State] As String

    Public Property [Title] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrencyCode")>
Public Class OutstandingInvoiceOverview

    Public Property [CurrencyCode] As String

    Public Property [OutstandingPayableInvoiceAmount] As Double

    Public Property [OutstandingPayableInvoiceCount] As Double

    Public Property [OutstandingReceivableInvoiceAmount] As Double

    Public Property [OutstandingReceivableInvoiceCount] As Double

    Public Property [OverduePayableInvoiceAmount] As Double

    Public Property [OverduePayableInvoiceCount] As Double

    Public Property [OverdueReceivableInvoiceAmount] As Double

    Public Property [OverdueReceivableInvoiceCount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Payable

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String

    Public Property [Amount] As Double

    Public Property [AmountInTransit] As Double

    Public Property [CurrencyCode] As String

    Public Property [Description] As String

    Public Property [DueDate] As DateTime

    Public Property [EntryNumber] As Int32

    Public Property [HID] As Int64

    Public Property [Id] As Guid

    Public Property [InvoiceDate] As DateTime

    Public Property [InvoiceNumber] As Int32

    Public Property [JournalCode] As String

    Public Property [JournalDescription] As String

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PaymentCondition

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [CreditManagementScenario] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreditManagementScenarioCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreditManagementScenarioDescription] As String

    Public Property [Description] As String

    Public Property [DiscountCalculation] As String

    Public Property [DiscountPaymentDays] As Int32?

    Public Property [DiscountPercentage] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [PaymentDays] As Int32?

    Public Property [PaymentDiscountType] As String

    Public Property [PaymentEndOfMonths] As Int32?

    Public Property [PaymentMethod] As String

    Public Property [Percentage] As Double?

    Public Property [VATCalculation] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period")>
Public Class PeriodRevenue

    Public Property [Amount] As Double

    Public Property [Period] As Int32

    Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PriceList

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DivisionDescription] As String

    Public Property [Entity] As Int16?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("InvoiceID")>
Public Class PrintedSalesInvoice

    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    Public Property [DocumentCreationError] As String

    Public Property [DocumentCreationSuccess] As String

    Public Property [DocumentLayout] As Guid?

    Public Property [EmailCreationError] As String

    Public Property [EmailCreationSuccess] As String

    Public Property [EmailLayout] As Guid?

    Public Property [ExtraText] As String

    Public Property [InvoiceDate] As DateTime?

    Public Property [InvoiceID] As Guid

    Public Property [PostboxMessageCreationError] As String

    Public Property [PostboxMessageCreationSuccess] As String

    Public Property [PostboxSender] As Guid?

    Public Property [ReportingPeriod] As Int32?

    Public Property [ReportingYear] As Int32?

    Public Property [SendEmailToCustomer] As Boolean?

    Public Property [SendInvoiceToCustomerPostbox] As Boolean?

    Public Property [SendOutputBasedOnAccount] As Boolean?
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("OrderId")>
Public Class PrintedSalesOrder

    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    Public Property [DocumentCreationError] As String

    Public Property [DocumentCreationSuccess] As String

    Public Property [DocumentLayout] As Guid?

    Public Property [EmailCreationError] As String

    Public Property [EmailCreationSuccess] As String

    Public Property [EmailLayout] As Guid?

    Public Property [ExtraText] As String

    Public Property [OrderId] As Guid

    Public Property [SendEmailToCustomer] As Boolean?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProductionArea

    Public Property [Code] As String

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [IsDefault] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrentYear")>
Public Class ProfitLossOverview

    Public Property [CostsCurrentPeriod] As Double

    Public Property [CostsCurrentYear] As Double

    Public Property [CostsPreviousYear] As Double

    Public Property [CostsPreviousYearPeriod] As Double

    Public Property [CurrencyCode] As String

    Public Property [CurrentPeriod] As Int32

    Public Property [CurrentYear] As Int32

    Public Property [PreviousYear] As Int32

    Public Property [PreviousYearPeriod] As Int32

    Public Property [ResultCurrentPeriod] As Double
    Public Property [ResultCurrentYear] As Double
    Public Property [ResultPreviousYear] As Double

    Public Property [ResultPreviousYearPeriod] As Double

    Public Property [RevenueCurrentPeriod] As Double

    Public Property [RevenueCurrentYear] As Double

    Public Property [RevenuePreviousYear] As Double

    Public Property [RevenuePreviousYearPeriod] As Double
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Project

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    Public Property [AccountContact] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [AllowAdditionalInvoicing] As Boolean?

    Public Property [BlockEntry] As Boolean?

    Public Property [BlockRebilling] As Boolean?

    Public Property [BudgetedAmount] As Double?

    Public Property [BudgetedCosts] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BudgetedHoursPerHourType] As IEnumerable(Of ProjectHourBudget)

    Public Property [BudgetedRevenue] As Double?

    Public Property [BudgetType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [BudgetTypeDescription] As String

    Public Property [Classification] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ClassificationDescription] As String

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostsAmountFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [CustomerPOnumber] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DivisionName] As String

    Public Property [EndDate] As DateTime?

    Public Property [FixedPriceItem] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [FixedPriceItemDescription] As String

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceAsQuoted] As Boolean

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceTerms] As IEnumerable(Of ProjectTerm)

    Public Property [Manager] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ManagerFullname] As String

    Public Property [MarkupPercentage] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [PrepaidItem] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PrepaidItemDescription] As String

    Public Property [PrepaidType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PrepaidTypeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectRestrictionEmployees] As IEnumerable(Of ProjectRestrictionEmployee)

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectRestrictionItems] As IEnumerable(Of ProjectRestrictionItem)

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectRestrictionRebillings] As IEnumerable(Of ProjectRestrictionRebilling)

    Public Property [SalesTimeQuantity] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SourceQuotation] As Guid?

    Public Property [StartDate] As DateTime?
    Public Property [TimeQuantityToAlert] As Double?

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    Public Property [UseBillingMilestones] As Boolean?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ProjectBudgetType

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Description] As String

    Public Property [ID] As Int16
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectHourBudget

    Public Property [Budget] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Project] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionEmployee

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EmployeeFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EmployeeHID] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionItem

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemIsTime] As Byte?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionRebilling

    Public Property [CostTypeRebill] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostTypeRebillCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostTypeRebillDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectTerm

    Public Property [Amount] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Deliverable] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [InvoiceDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Percentage] As Double?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class PurchaseEntry

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountFC] As Double?

    Public Property [BatchNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [DueDate] As DateTime?

    Public Property [EntryDate] As DateTime?

    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ExternalLinkDescription] As String
    Public Property [ExternalLinkReference] As String

    Public Property [InvoiceNumber] As Int32?

    Public Property [Journal] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [OrderNumber] As Int32?

    Public Property [PaymentCondition] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String
    Public Property [ProcessNumber] As Int32?

    Public Property [PurchaseEntryLines] As IEnumerable(Of PurchaseEntryLine)

    Public Property [Rate] As Double?

    Public Property [ReportingPeriod] As Int16?

    Public Property [ReportingYear] As Int16?

    Public Property [Reversal] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [Supplier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SupplierName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountDC] As Double?

    Public Property [VATAmountFC] As Double?

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class PurchaseEntryLine

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EntryID] As Guid

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    Public Property [Notes] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [SerialNumber] As String

    Public Property [Subscription] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    Public Property [TrackingNumber] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TrackingNumberDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountDC] As Double?

    Public Property [VATAmountFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATBaseAmountDC] As Double?

    Public Property [VATBaseAmountFC] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Receivable

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String

    Public Property [Amount] As Double

    Public Property [AmountInTransit] As Double

    Public Property [CurrencyCode] As String

    Public Property [Description] As String

    Public Property [DueDate] As DateTime

    Public Property [EntryNumber] As Int32

    Public Property [HID] As Int64

    Public Property [Id] As Guid

    Public Property [InvoiceDate] As DateTime

    Public Property [InvoiceNumber] As Int32

    Public Property [JournalCode] As String

    Public Property [JournalDescription] As String

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentCosts

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid?

    Public Property [AccountName] As String

    Public Property [AmountApproved] As Double

    Public Property [AmountDraft] As Double

    Public Property [AmountRejected] As Double

    Public Property [AmountSubmitted] As Double

    Public Property [CurrencyCode] As String

    Public Property [Date] As DateTime

    Public Property [EntryId] As Guid?

    Public Property [Expense] As Guid?

    Public Property [ExpenseDescription] As String

    Public Property [Id] As Int32

    Public Property [ItemCode] As String

    Public Property [ItemDescription] As String

    Public Property [ItemId] As Guid?

    Public Property [Notes] As String

    Public Property [ProjectCode] As String

    Public Property [ProjectDescription] As String

    Public Property [ProjectId] As Guid?

    Public Property [QuantityApproved] As Double

    Public Property [QuantityDraft] As Double

    Public Property [QuantityRejected] As Double

    Public Property [QuantitySubmitted] As Double

    Public Property [WeekNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentHours

    Public Property [AccountCode] As String

    Public Property [AccountId] As Guid?

    Public Property [AccountName] As String

    Public Property [Activity] As Guid?

    Public Property [ActivityDescription] As String

    Public Property [Date] As DateTime

    Public Property [EntryId] As Guid?

    Public Property [HoursApproved] As Double

    Public Property [HoursApprovedBillable] As Double

    Public Property [HoursDraft] As Double

    Public Property [HoursDraftBillable] As Double

    Public Property [HoursRejected] As Double

    Public Property [HoursRejectedBillable] As Double

    Public Property [HoursSubmitted] As Double

    Public Property [HoursSubmittedBillable] As Double

    Public Property [Id] As Int32

    Public Property [ItemCode] As String

    Public Property [ItemDescription] As String

    Public Property [ItemId] As Guid?

    Public Property [Notes] As String

    Public Property [ProjectCode] As String

    Public Property [ProjectDescription] As String

    Public Property [ProjectId] As Guid?

    Public Property [WeekNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ReportingBalance

    Public Property [Amount] As Double?

    Public Property [AmountCredit] As Double?

    Public Property [AmountDebit] As Double?

    Public Property [BalanceType] As String

    Public Property [CostCenterCode] As String

    Public Property [CostCenterDescription] As String

    Public Property [CostUnitCode] As String

    Public Property [CostUnitDescription] As String

    Public Property [Count] As Int32?

    Public Property [Division] As Int32?

    Public Property [GLAccount] As Guid?

    Public Property [GLAccountCode] As String

    Public Property [GLAccountDescription] As String

    Public Property [ID] As Int64

    Public Property [ReportingPeriod] As Int32?

    Public Property [ReportingYear] As Int32?

    Public Property [Status] As Int32?

    Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class SalesEntry

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountFC] As Double?

    Public Property [BatchNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Customer] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CustomerName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [DueDate] As DateTime?

    Public Property [EntryDate] As DateTime?

    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ExternalLinkDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ExternalLinkReference] As String

    Public Property [InvoiceNumber] As Int32?

    Public Property [Journal] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [OrderNumber] As Int32?

    Public Property [PaymentCondition] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String

    Public Property [PaymentReference] As String
    Public Property [ProcessNumber] As Int32?

    Public Property [Rate] As Double?

    Public Property [ReportingPeriod] As Int16?

    Public Property [ReportingYear] As Int16?

    Public Property [Reversal] As Boolean?

    Public Property [SalesEntryLines] As IEnumerable(Of SalesEntryLine)

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountDC] As Double?

    Public Property [VATAmountFC] As Double?

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesEntryLine

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EntryID] As Guid

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    Public Property [Notes] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [SerialNumber] As String

    Public Property [Subscription] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    Public Property [TrackingNumber] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TrackingNumberDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountDC] As Double?

    Public Property [VATAmountFC] As Double?

    Public Property [VATBaseAmountDC] As Double?

    Public Property [VATBaseAmountFC] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("InvoiceID")>
Public Class SalesInvoice

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [DueDate] As DateTime?

    Public Property [InvoiceDate] As DateTime?

    Public Property [InvoiceID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceNumber] As Int32?

    Public Property [InvoiceTo] As Guid?

    Public Property [InvoiceToContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToName] As String

    Public Property [Journal] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [OrderDate] As DateTime?

    Public Property [OrderedBy] As Guid?

    Public Property [OrderedByContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByName] As String

    Public Property [OrderNumber] As Int32?

    Public Property [PaymentCondition] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String

    Public Property [PaymentReference] As String

    Public Property [Remarks] As String

    Public Property [SalesInvoiceLines] As IEnumerable(Of SalesInvoiceLine)

    Public Property [Salesperson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalespersonFullName] As String

    Public Property [StarterSalesInvoiceStatus] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StarterSalesInvoiceStatusDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [TaxSchedule] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleDescription] As String

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATAmountFC] As Double?

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesInvoiceLine

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    Public Property [Description] As String

    Public Property [Discount] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Employee] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EmployeeFullName] As String

    Public Property [EndTime] As DateTime?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [ID] As Guid

    Public Property [InvoiceID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    Public Property [NetPrice] As Double?

    Public Property [Notes] As String

    Public Property [Pricelist] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PricelistDescription] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesOrder] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesOrderLine] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesOrderLineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalesOrderNumber] As Int32?

    Public Property [StartTime] As DateTime?

    Public Property [Subscription] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    Public Property [TaxSchedule] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleDescription] As String

    Public Property [UnitCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UnitDescription] As String

    Public Property [UnitPrice] As Double?

    Public Property [VATAmountDC] As Double?

    Public Property [VATAmountFC] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("OrderID")>
Public Class SalesOrder

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ApprovalStatus] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ApprovalStatusDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Approved] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Approver] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ApproverFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [DeliverTo] As Guid?

    Public Property [DeliverToContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DeliverToContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DeliverToName] As String

    Public Property [DeliveryDate] As DateTime?

    Public Property [DeliveryStatus] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DeliveryStatusDescription] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [InvoiceStatus] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceStatusDescription] As String

    Public Property [InvoiceTo] As Guid?

    Public Property [InvoiceToContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [OrderDate] As DateTime?

    Public Property [OrderedBy] As Guid?

    Public Property [OrderedByContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByName] As String

    Public Property [OrderID] As Guid

    Public Property [OrderNumber] As Int32?

    Public Property [PaymentCondition] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String

    Public Property [PaymentReference] As String

    Public Property [Remarks] As String

    Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)

    Public Property [Salesperson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SalespersonFullName] As String

    Public Property [ShippingMethod] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ShippingMethodDescription] As String

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [TaxSchedule] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseDescription] As String

    Public Property [WarehouseID] As Guid?

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesOrderLine

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    Public Property [DeliveryDate] As DateTime?

    Public Property [Description] As String

    Public Property [Discount] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [ItemVersion] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemVersionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    Public Property [NetPrice] As Double?

    Public Property [Notes] As String

    Public Property [OrderID] As Guid

    Public Property [OrderNumber] As Int32?

    Public Property [Pricelist] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PricelistDescription] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [QuantityDelivered] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [QuantityInvoiced] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ShopOrder] As Guid?

    Public Property [TaxSchedule] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TaxScheduleDescription] As String

    Public Property [UnitCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UnitDescription] As String

    Public Property [UnitPrice] As Double?

    Public Property [UseDropShipment] As Byte

    Public Property [VATAmount] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Schedule

    Public Property [Active] As Byte?

    Public Property [AverageHours] As Double?

    Public Property [Code] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Days] As Double?

    Public Property [Description] As String

    Public Property [Division] As Int32?

    Public Property [Employment] As Guid?

    Public Property [EmploymentHID] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [Hours] As Double?

    Public Property [ID] As Guid

    Public Property [LeaveHoursCompensation] As Double?

    Public Property [Main] As Byte?

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [PaymentParttimeFactor] As Double?

    Public Property [ScheduleType] As Int32?

    Public Property [ScheduleTypeDescription] As String

    Public Property [StartDate] As DateTime?

    Public Property [StartWeek] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrder

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EntryDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [IsInPlanning] As Byte

    Public Property [IsOnHold] As Byte

    Public Property [IsReleased] As Byte

    Public Property [Item] As Guid?

    Public Property [ItemVersion] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemVersionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [PlannedDate] As DateTime?

    Public Property [PlannedQuantity] As Double?

    Public Property [PlannedStartDate] As DateTime?

    Public Property [ProducedQuantity] As Double?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [ReadyToShipQuantity] As Double?

    Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)

    Public Property [ShopOrderMain] As Guid?

    Public Property [ShopOrderMainNumber] As Int32?

    Public Property [ShopOrderMaterialPlans] As IEnumerable(Of ShopOrderMaterialPlan)

    Public Property [ShopOrderNumber] As Int32?

    Public Property [ShopOrderParent] As Guid?

    Public Property [ShopOrderParentNumber] As Int32?

    Public Property [ShopOrderRoutingStepPlans] As IEnumerable(Of ShopOrderRoutingStepPlan)

    Public Property [Status] As Int16?

    Public Property [Type] As Int16?

    Public Property [Warehouse] As Guid?

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderMaterialPlan

    Public Property [Backflush] As Byte

    Public Property [CalculatorType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [DetailDrawing] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [PlannedAmountFC] As Double?

    Public Property [PlannedDate] As DateTime?

    Public Property [PlannedPriceFC] As Double?

    Public Property [PlannedQuantity] As Double?

    Public Property [PlannedQuantityFactor] As Double?

    Public Property [ShopOrder] As Guid?

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderRoutingStepPlan

    Public Property [Account] As Guid?

    Public Property [AttendedPercentage] As Double?

    Public Property [Backflush] As Byte

    Public Property [CostPerItem] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EfficiencyPercentage] As Double?

    Public Property [FactorType] As Int16?

    Public Property [ID] As Guid

    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Operation] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OperationDescription] As String

    Public Property [OperationResource] As Guid?

    Public Property [PlannedEndDate] As DateTime?

    Public Property [PlannedRunHours] As Double?

    Public Property [PlannedSetupHours] As Double?

    Public Property [PlannedStartDate] As DateTime?

    Public Property [PlannedTotalHours] As Double?

    Public Property [PurchaseUnit] As String

    Public Property [PurchaseUnitFactor] As Double?

    Public Property [PurchaseUnitPriceFC] As Double?

    Public Property [PurchaseUnitQuantity] As Double?

    Public Property [RoutingStepType] As Int16?

    Public Property [Run] As Double?

    Public Property [RunMethod] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [RunMethodDescription] As String

    Public Property [Setup] As Double?

    Public Property [SetupUnit] As String

    Public Property [ShopOrder] As Guid?

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [SubcontractedLeadDays] As Int32?

    Public Property [TimeTransactions] As IEnumerable(Of ManufacturingTimeTransaction)

    Public Property [TotalCostDC] As Double?

    Public Property [Workcenter] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class StorageLocation

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Main] As Byte?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Warehouse] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class Subscription

    Public Property [BlockEntry] As Boolean?

    Public Property [CancellationDate] As DateTime?

    Public Property [Classification] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ClassificationCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ClassificationDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [CustomerPONumber] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [EndDate] As DateTime?

    Public Property [EntryID] As Guid

    Public Property [InvoicedTo] As DateTime?

    Public Property [InvoiceTo] As Guid?

    Public Property [InvoiceToContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [InvoiceToName] As String

    Public Property [InvoicingStartDate] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Number] As Int32

    Public Property [OrderedBy] As Guid?

    Public Property [OrderedByContactPerson] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByContactPersonFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [OrderedByName] As String

    Public Property [PaymentCondition] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String

    Public Property [Printed] As Boolean

    Public Property [ReasonCancelled] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ReasonCancelledCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ReasonCancelledDescription] As String

    Public Property [StartDate] As DateTime

    Public Property [SubscriptionLines] As IEnumerable(Of SubscriptionLine)

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionRestrictionEmployees] As IEnumerable(Of SubscriptionRestrictionEmployee)

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionRestrictionItems] As IEnumerable(Of SubscriptionRestrictionItem)

    Public Property [SubscriptionType] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionTypeCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionTypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionChargeType

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Description] As String

    Public Property [ID] As Int16
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SubscriptionLine

    Public Property [AmountDC] As Double

    Public Property [AmountFC] As Double

    Public Property [Costcenter] As String

    Public Property [Costunit] As String

    Public Property [Description] As String

    Public Property [Discount] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [EntryID] As Guid

    Public Property [FromDate] As DateTime

    Public Property [ID] As Guid

    Public Property [Item] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    Public Property [LineNumber] As Int32

    Public Property [LineType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineTypeDescription] As String

    Public Property [NetPrice] As Double

    Public Property [Notes] As String

    Public Property [Quantity] As Double

    Public Property [ToDate] As DateTime?

    Public Property [UnitCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UnitDescription] As String

    Public Property [UnitPrice] As Double

    Public Property [VATAmountFC] As Double?

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionReasonCode

    Public Property [Active] As Boolean

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionEmployee

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [Employee] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EmployeeFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EmployeeHID] As Int32?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Subscription] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionNumber] As Int32
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionItem

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Subscription] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionType

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxComponentRate

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Division] As Int32

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [LineNumber] As Int32

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Rate] As Double

    Public Property [StartDate] As DateTime?

    Public Property [TaxComponent] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("DocumentID")>
Public Class TaxDocument

    Public Property [Amount] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime

    Public Property [Currency] As String

    Public Property [Description] As String

    Public Property [DocumentID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentViewUrl] As String

    Public Property [DueDate] As DateTime?

    Public Property [Frequency] As String

    Public Property [PayrollDeclarationType] As String

    Public Property [Period] As Int32

    Public Property [PeriodDescription] As String

    Public Property [Request] As Guid?

    Public Property [Status] As Int32

    Public Property [Type] As Int32

    Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxEmploymentEndFlexCode

    Public Property [Code] As String

    Public Property [Created] As DateTime?

    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [Modified] As DateTime?

    Public Property [Modifier] As Guid?

    Public Property [ModifierFullName] As String

    Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxSchedule

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [Division] As Int32

    Public Property [ID] As Guid

    Public Property [IsBlocked] As Byte

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Type] As Int16
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxScheduleComponent

    Public Property [Account] As Guid?

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [Division] As Int32

    Public Property [GLAccount] As Guid?

    Public Property [ID] As Guid

    Public Property [LineNumber] As Int32

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [TaxComponent] As Guid

    Public Property [TaxComponentRates] As IEnumerable(Of TaxComponentRate)

    Public Property [TaxSchedule] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingAccount

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingAccountDetails

    Public Property [ID] As Guid

    Public Property [Name] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingActivitiesAndExpenses

    Public Property [Description] As String

    Public Property [ID] As Guid

    Public Property [ParentDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingItemDetails

    Public Property [Code] As String

    Public Property [Description] As String

    Public Property [ID] As Guid

    Public Property [IsFractionAllowedItem] As Boolean

    Public Property [IsSalesItem] As Boolean

    Public Property [SalesCurrency] As String

    Public Property [SalesPrice] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingProject

    Public Property [ProjectCode] As String

    Public Property [ProjectDescription] As String

    Public Property [ProjectId] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingProjectDetails

    Public Property [Account] As Guid?
    Public Property [AccountName] As String

    Public Property [Code] As String

    Public Property [Description] As String

    Public Property [ID] As Guid

    Public Property [Type] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingRecentAccount

    Public Property [AccountId] As Guid

    Public Property [AccountName] As String

    Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingRecentActivitiesAndExpenses

    Public Property [DateLastUsed] As DateTime

    Public Property [Description] As String

    Public Property [ID] As Guid

    Public Property [ParentDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class TimeAndBillingRecentHourCostType

    Public Property [DateLastUsed] As DateTime

    Public Property [ItemDescription] As String

    Public Property [ItemId] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingRecentProject

    Public Property [DateLastUsed] As DateTime

    Public Property [ProjectCode] As String

    Public Property [ProjectDescription] As String

    Public Property [ProjectId] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class TimeTransaction

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [Activity] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ActivityDescription] As String

    Public Property [Amount] As Double?

    Public Property [AmountFC] As Double?

    Public Property [Attachment] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Date] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DivisionDescription] As String

    Public Property [Employee] As Guid?

    Public Property [EndTime] As DateTime?

    Public Property [EntryNumber] As Int32?

    Public Property [ErrorText] As String

    Public Property [HourStatus] As Int16?

    Public Property [ID] As Guid

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDivisable] As Boolean?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [Price] As Double?

    Public Property [PriceFC] As Double?

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectAccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [StartTime] As DateTime?

    Public Property [Subscription] As Guid?

    Public Property [SubscriptionAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionAccountName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("EntryID")>
Public Class Transaction

    Public Property [ClosingBalanceFC] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    Public Property [Date] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EntryID] As Guid

    Public Property [EntryNumber] As Int32?

    Public Property [FinancialPeriod] As Int16?

    Public Property [FinancialYear] As Int16?

    Public Property [JournalCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [JournalDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    Public Property [OpeningBalanceFC] As Double?

    Public Property [PaymentConditionCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [PaymentConditionDescription] As String

    Public Property [Status] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [StatusDescription] As String

    Public Property [TransactionLines] As IEnumerable(Of TransactionLine)

    Public Property [Type] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TransactionLine

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [AmountDC] As Double?

    Public Property [AmountFC] As Double?

    Public Property [AmountVATBaseFC] As Double?

    Public Property [AmountVATFC] As Double?

    Public Property [Asset] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AssetDescription] As String

    Public Property [CostCenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostCenterDescription] As String

    Public Property [CostUnit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostUnitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Currency] As String

    Public Property [Date] As DateTime?

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [Document] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [DocumentSubject] As String

    Public Property [DueDate] As DateTime?

    Public Property [EntryID] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [EntryNumber] As Int32?

    Public Property [ExchangeRate] As Double?

    Public Property [FinancialPeriod] As Int16?

    Public Property [FinancialYear] As Int16?

    Public Property [GLAccount] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLAccountDescription] As String

    Public Property [ID] As Guid

    Public Property [InvoiceNumber] As Int32?

    Public Property [Item] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ItemDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [LineNumber] As Int32?

    Public Property [LineType] As Int16?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String
    Public Property [OffsetID] As Guid?

    Public Property [OrderNumber] As Int32?

    Public Property [PaymentDiscountAmount] As Double?

    Public Property [PaymentReference] As String

    Public Property [Project] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ProjectDescription] As String

    Public Property [Quantity] As Double?

    Public Property [SerialNumber] As String

    Public Property [Subscription] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [SubscriptionDescription] As String

    Public Property [TrackingNumber] As String

    Public Property [TrackingNumberDescription] As String

    Public Property [VATCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [VATCodeDescription] As String

    Public Property [VATPercentage] As Double?

    Public Property [VATType] As String

    Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Unit

    Public Property [Active] As Boolean?

    Public Property [Code] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [ID] As Guid

    Public Property [Main] As Byte?

    Public Property [TimeUnit] As String

    Public Property [Type] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("UserID")>
Public Class User

    Public Property [BirthDate] As DateTime?

    Public Property [BirthName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Customer] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CustomerName] As String

    Public Property [Email] As String

    Public Property [EndDate] As DateTime?

    Public Property [FirstName] As String

    Public Property [FullName] As String

    Public Property [Gender] As String

    Public Property [Initials] As String

    Public Property [Language] As String

    Public Property [LastLogin] As DateTime?

    Public Property [LastName] As String

    Public Property [MiddleName] As String

    Public Property [Mobile] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Nationality] As String

    Public Property [Notes] As String

    Public Property [Phone] As String

    Public Property [PhoneExtension] As String

    Public Property [ProfileCode] As String

    Public Property [StartDate] As DateTime?

    Public Property [StartDivision] As Int32

    Public Property [Title] As String

    Public Property [UserID] As Guid

    Public Property [UserName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [UserRoles] As IEnumerable(Of UserRole)

    Public Property [UserTypesList] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class UserRole

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Role] As Int32

    Public Property [RoleLevel] As Int32

    Public Property [StartDate] As DateTime

    Public Property [UserID] As Guid?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class VATCode

    Public Property [Account] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [AccountName] As String

    Public Property [CalculationBasis] As Byte?

    Public Property [Charged] As Boolean?

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Country] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EUSalesListing] As String

    Public Property [GLDiscountPurchase] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLDiscountPurchaseCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLDiscountPurchaseDescription] As String

    Public Property [GLDiscountSales] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLDiscountSalesCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLDiscountSalesDescription] As String

    Public Property [GLToClaim] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLToClaimCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLToClaimDescription] As String

    Public Property [GLToPay] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLToPayCode] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [GLToPayDescription] As String

    Public Property [ID] As Guid

    Public Property [IntraStat] As Boolean?

    Public Property [IsBlocked] As Boolean?

    Public Property [LegalText] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Percentage] As Double?

    Public Property [TaxReturnType] As Int16?

    Public Property [Type] As String

    Public Property [VatDocType] As String

    Public Property [VatMargin] As Byte

    Public Property [VATPartialRatio] As Int16?

    Public Property [VATPercentages] As IEnumerable(Of VatPercentage)

    Public Property [VATTransactionType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class VatPercentage

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EndDate] As DateTime?

    Public Property [ID] As Guid

    Public Property [LineNumber] As Int32?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Percentage] As Double?

    Public Property [StartDate] As DateTime?

    Public Property [VATCodeID] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Warehouse

    Public Property [Code] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [EMail] As String

    Public Property [ID] As Guid

    Public Property [Main] As Byte

    Public Property [ManagerUser] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [UseStorageLocations] As Byte
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Workcenter

    Public Property [Code] As String

    Public Property [Costcenter] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostcenterDescription] As String

    Public Property [Costunit] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CostunitDescription] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Created] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Creator] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [CreatorFullName] As String

    Public Property [Description] As String

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Division] As Int32?

    Public Property [GeneralBurdenRate] As Double?

    Public Property [ID] As Guid

    Public Property [IsLaborBurdenPercent] As Byte

    Public Property [LaborBurdenRate] As Double?

    Public Property [MachineBurdenRate] As Double?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modified] As DateTime?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [Modifier] As Guid?

    <SDKFieldType(FieldType.ReadOnly)>
    Public Property [ModifierFullName] As String

    Public Property [Notes] As String

    Public Property [ProductionArea] As Guid?

    Public Property [RunLaborRate] As Double?

    Public Property [SearchCode] As String

    Public Property [SetupLaborRate] As Double?

    Public Property [Status] As Int16?

    Public Property [Type] As Int16?
End Class

