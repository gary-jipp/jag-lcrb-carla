// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.quotedetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMquotedetail
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquotedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquotedetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquotedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquotedetail(System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), decimal? tax = default(decimal?), int? quotestatecode = default(int?), decimal? extendedamountBase = default(decimal?), bool? ispriceoverridden = default(bool?), string owninguser = default(string), string productnumber = default(string), string _modifiedonbehalfbyValue = default(string), decimal? baseamount = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string shiptoStateorprovince = default(string), string shiptoContactname = default(string), string _parentbundleidrefValue = default(string), string parentbundleid = default(string), decimal? manualdiscountamount = default(decimal?), int? propertyconfigurationstatus = default(int?), string _owneridValue = default(string), string shiptoPostalcode = default(string), string _modifiedbyValue = default(string), string shiptoLine2 = default(string), string shiptoCountry = default(string), string productdescription = default(string), string shiptoName = default(string), decimal? priceperunitBase = default(decimal?), int? pricingerrorcode = default(int?), bool? isproductoverridden = default(bool?), string _productidValue = default(string), bool? willcall = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? sequencenumber = default(int?), decimal? extendedamount = default(decimal?), string productname = default(string), string _owningteamValue = default(string), string _createdbyValue = default(string), string quotedetailid = default(string), string _quoteidValue = default(string), string productassociationid = default(string), int? utcconversiontimezonecode = default(int?), string shiptoTelephone = default(string), int? lineitemnumber = default(int?), decimal? exchangerate = default(decimal?), int? importsequencenumber = default(int?), string _uomidValue = default(string), string shiptoFax = default(string), string versionnumber = default(string), string quotedetailname = default(string), string _salesrepidValue = default(string), decimal? baseamountBase = default(decimal?), decimal? volumediscountamountBase = default(decimal?), string description = default(string), string _transactioncurrencyidValue = default(string), string shiptoAddressid = default(string), decimal? volumediscountamount = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? producttypecode = default(int?), decimal? taxBase = default(decimal?), decimal? priceperunit = default(decimal?), string shiptoLine1 = default(string), decimal? manualdiscountamountBase = default(decimal?), string shiptoLine3 = default(string), int? shiptoFreighttermscode = default(int?), string shiptoCity = default(string), int? skippricecalculation = default(int?), int? timezoneruleversionnumber = default(int?), decimal? quantity = default(decimal?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMteam> quotedetailTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> quotedetailMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprocesssession> quoteDetailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> quoteDetailDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMquotedetail parentbundleidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), IList<MicrosoftDynamicsCRMquotedetail> quotedetailParentQuotedetail = default(IList<MicrosoftDynamicsCRMquotedetail>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> quoteDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> quoteDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> quotedetailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser salesrepid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMquotedetail parentbundleidrefQuotedetail = default(MicrosoftDynamicsCRMquotedetail), IList<MicrosoftDynamicsCRMquotedetail> quotedetailParentrefQuotedetail = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMsalesorderdetail> msdynQuotedetailSalesorderdetail = default(IList<MicrosoftDynamicsCRMsalesorderdetail>))
        {
            Requestdeliveryby = requestdeliveryby;
            Tax = tax;
            Quotestatecode = quotestatecode;
            ExtendedamountBase = extendedamountBase;
            Ispriceoverridden = ispriceoverridden;
            Owninguser = owninguser;
            Productnumber = productnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Baseamount = baseamount;
            Modifiedon = modifiedon;
            ShiptoStateorprovince = shiptoStateorprovince;
            ShiptoContactname = shiptoContactname;
            this._parentbundleidrefValue = _parentbundleidrefValue;
            Parentbundleid = parentbundleid;
            Manualdiscountamount = manualdiscountamount;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            this._owneridValue = _owneridValue;
            ShiptoPostalcode = shiptoPostalcode;
            this._modifiedbyValue = _modifiedbyValue;
            ShiptoLine2 = shiptoLine2;
            ShiptoCountry = shiptoCountry;
            Productdescription = productdescription;
            ShiptoName = shiptoName;
            PriceperunitBase = priceperunitBase;
            Pricingerrorcode = pricingerrorcode;
            Isproductoverridden = isproductoverridden;
            this._productidValue = _productidValue;
            Willcall = willcall;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Sequencenumber = sequencenumber;
            Extendedamount = extendedamount;
            Productname = productname;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            Quotedetailid = quotedetailid;
            this._quoteidValue = _quoteidValue;
            Productassociationid = productassociationid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            ShiptoTelephone = shiptoTelephone;
            Lineitemnumber = lineitemnumber;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            this._uomidValue = _uomidValue;
            ShiptoFax = shiptoFax;
            Versionnumber = versionnumber;
            Quotedetailname = quotedetailname;
            this._salesrepidValue = _salesrepidValue;
            BaseamountBase = baseamountBase;
            VolumediscountamountBase = volumediscountamountBase;
            Description = description;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            ShiptoAddressid = shiptoAddressid;
            Volumediscountamount = volumediscountamount;
            Overriddencreatedon = overriddencreatedon;
            Producttypecode = producttypecode;
            TaxBase = taxBase;
            Priceperunit = priceperunit;
            ShiptoLine1 = shiptoLine1;
            ManualdiscountamountBase = manualdiscountamountBase;
            ShiptoLine3 = shiptoLine3;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            ShiptoCity = shiptoCity;
            Skippricecalculation = skippricecalculation;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Quantity = quantity;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Owningteam = owningteam;
            QuotedetailTeams = quotedetailTeams;
            QuotedetailMailboxTrackingFolders = quotedetailMailboxTrackingFolders;
            Createdby = createdby;
            QuoteDetailProcessSessions = quoteDetailProcessSessions;
            QuoteDetailBulkDeleteFailures = quoteDetailBulkDeleteFailures;
            Productid = productid;
            QuoteDetailDynamicpropertyinstance = quoteDetailDynamicpropertyinstance;
            Uomid = uomid;
            Createdonbehalfby = createdonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            ProductassociationidProductassociation = productassociationidProductassociation;
            ParentbundleidQuotedetail = parentbundleidQuotedetail;
            QuotedetailParentQuotedetail = quotedetailParentQuotedetail;
            Modifiedonbehalfby = modifiedonbehalfby;
            QuoteDetailAsyncOperations = quoteDetailAsyncOperations;
            QuoteDetailSyncErrors = quoteDetailSyncErrors;
            Modifiedby = modifiedby;
            Quoteid = quoteid;
            QuotedetailPrincipalobjectattributeaccess = quotedetailPrincipalobjectattributeaccess;
            Salesrepid = salesrepid;
            ParentbundleidrefQuotedetail = parentbundleidrefQuotedetail;
            QuotedetailParentrefQuotedetail = quotedetailParentrefQuotedetail;
            MsdynQuotedetailSalesorderdetail = msdynQuotedetailSalesorderdetail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotestatecode")]
        public int? Quotestatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public decimal? ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public decimal? Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentbundleidref_value")]
        public string _parentbundleidrefValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public decimal? Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public decimal? PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public decimal? Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productname")]
        public string Productname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetailid")]
        public string Quotedetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetailname")]
        public string Quotedetailname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesrepid_value")]
        public string _salesrepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public decimal? BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public decimal? VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public decimal? Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public decimal? TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public decimal? Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public decimal? ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skippricecalculation")]
        public int? Skippricecalculation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_Teams")]
        public IList<MicrosoftDynamicsCRMteam> QuotedetailTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> QuotedetailMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> QuoteDetailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> QuoteDetailDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail ParentbundleidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_parent_quotedetail")]
        public IList<MicrosoftDynamicsCRMquotedetail> QuotedetailParentQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QuotedetailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesrepid")]
        public MicrosoftDynamicsCRMsystemuser Salesrepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleidref_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail ParentbundleidrefQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_parentref_quotedetail")]
        public IList<MicrosoftDynamicsCRMquotedetail> QuotedetailParentrefQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_quotedetail_salesorderdetail")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> MsdynQuotedetailSalesorderdetail { get; set; }

    }
}
