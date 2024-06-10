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
    /// Microsoft.Dynamics.CRM.adoxio_licencesubcategory
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLicencesubcategory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencesubcategory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencesubcategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencesubcategory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencesubcategory(int? adoxioFinalinspectiontimeunit = default(int?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string adoxioLicencesubcategoryid = default(string), string _adoxioLicencefeeproductValue = default(string), string _owningteamValue = default(string), int? adoxioFinalinspectiontime = default(int?), int? adoxioProratedbydaymonth = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? adoxioRoutineinspectionoccurrence = default(int?), string _createdonbehalfbyValue = default(string), string _adoxioLicencetypeValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statuscode = default(int?), bool? adoxioIslicencefeeprorated = default(bool?), string _owninguserValue = default(string), int? adoxioProratedendingmonth = default(int?), string adoxioName = default(string), string _createdbyValue = default(string), int? statecode = default(int?), int? importsequencenumber = default(int?), int? adoxioProratedendingday = default(int?), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLicencesubcategorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLicencesubcategoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioLicencesubcategoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioLicencesubcategoryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLicencesubcategoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioLicencesubcategoryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioLicencesubcategoryAdoxioLicencesLicenceSubCategoryId = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> adoxioLicencesubcategoryAdoxioTermsconditionslimitationspresetLicenceSubCategory = default(IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLicencesubcategoryAdoxioApplicationLicenceSubCategoryId = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMincident> adoxioLicencesubcategoryIncidentLicenceSubCategoryId = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioLicencesubcategoryAdoxioApplicationtermsconditionslimitationLicenceSubCategoryId = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>), MicrosoftDynamicsCRMproduct adoxioLicenceFeeProduct = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule> adoxioLicencesubcategoryAdoxioProratedlicencefeescheduleLicenceSubCategory = default(IList<MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule>))
        {
            AdoxioFinalinspectiontimeunit = adoxioFinalinspectiontimeunit;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioLicencesubcategoryid = adoxioLicencesubcategoryid;
            this._adoxioLicencefeeproductValue = _adoxioLicencefeeproductValue;
            this._owningteamValue = _owningteamValue;
            AdoxioFinalinspectiontime = adoxioFinalinspectiontime;
            AdoxioProratedbydaymonth = adoxioProratedbydaymonth;
            Modifiedon = modifiedon;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioRoutineinspectionoccurrence = adoxioRoutineinspectionoccurrence;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            AdoxioIslicencefeeprorated = adoxioIslicencefeeprorated;
            this._owninguserValue = _owninguserValue;
            AdoxioProratedendingmonth = adoxioProratedendingmonth;
            AdoxioName = adoxioName;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            AdoxioProratedendingday = adoxioProratedendingday;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLicencesubcategorySyncErrors = adoxioLicencesubcategorySyncErrors;
            AdoxioLicencesubcategoryAsyncOperations = adoxioLicencesubcategoryAsyncOperations;
            AdoxioLicencesubcategoryMailboxTrackingFolders = adoxioLicencesubcategoryMailboxTrackingFolders;
            AdoxioLicencesubcategoryProcessSession = adoxioLicencesubcategoryProcessSession;
            AdoxioLicencesubcategoryBulkDeleteFailures = adoxioLicencesubcategoryBulkDeleteFailures;
            AdoxioLicencesubcategoryPrincipalObjectAttributeAccesses = adoxioLicencesubcategoryPrincipalObjectAttributeAccesses;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioLicencesubcategoryAdoxioLicencesLicenceSubCategoryId = adoxioLicencesubcategoryAdoxioLicencesLicenceSubCategoryId;
            AdoxioLicencesubcategoryAdoxioTermsconditionslimitationspresetLicenceSubCategory = adoxioLicencesubcategoryAdoxioTermsconditionslimitationspresetLicenceSubCategory;
            AdoxioLicencesubcategoryAdoxioApplicationLicenceSubCategoryId = adoxioLicencesubcategoryAdoxioApplicationLicenceSubCategoryId;
            AdoxioLicencesubcategoryIncidentLicenceSubCategoryId = adoxioLicencesubcategoryIncidentLicenceSubCategoryId;
            AdoxioLicencesubcategoryAdoxioApplicationtermsconditionslimitationLicenceSubCategoryId = adoxioLicencesubcategoryAdoxioApplicationtermsconditionslimitationLicenceSubCategoryId;
            AdoxioLicenceFeeProduct = adoxioLicenceFeeProduct;
            AdoxioLicencesubcategoryAdoxioProratedlicencefeescheduleLicenceSubCategory = adoxioLicencesubcategoryAdoxioProratedlicencefeescheduleLicenceSubCategory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_finalinspectiontimeunit")]
        public int? AdoxioFinalinspectiontimeunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategoryid")]
        public string AdoxioLicencesubcategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencefeeproduct_value")]
        public string _adoxioLicencefeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_finalinspectiontime")]
        public int? AdoxioFinalinspectiontime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_proratedbydaymonth")]
        public int? AdoxioProratedbydaymonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_routineinspectionoccurrence")]
        public int? AdoxioRoutineinspectionoccurrence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islicencefeeprorated")]
        public bool? AdoxioIslicencefeeprorated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_proratedendingmonth")]
        public int? AdoxioProratedendingmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_proratedendingday")]
        public int? AdoxioProratedendingday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLicencesubcategorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLicencesubcategoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioLicencesubcategoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioLicencesubcategoryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLicencesubcategoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioLicencesubcategoryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_adoxio_licences_LicenceSubCategoryId")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioLicencesubcategoryAdoxioLicencesLicenceSubCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_adoxio_termsconditionslimitationspreset_LicenceSubCategory")]
        public IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> AdoxioLicencesubcategoryAdoxioTermsconditionslimitationspresetLicenceSubCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_adoxio_application_LicenceSubCategoryId")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLicencesubcategoryAdoxioApplicationLicenceSubCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_incident_LicenceSubCategoryId")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioLicencesubcategoryIncidentLicenceSubCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_adoxio_applicationtermsconditionslimitation_LicenceSubCategoryId")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioLicencesubcategoryAdoxioApplicationtermsconditionslimitationLicenceSubCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioLicenceFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory")]
        public IList<MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule> AdoxioLicencesubcategoryAdoxioProratedlicencefeescheduleLicenceSubCategory { get; set; }

    }
}
