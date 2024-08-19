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
    /// Microsoft.Dynamics.CRM.adoxio_policejurisdiction
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioPolicejurisdiction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdiction class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdiction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdiction class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdiction(string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), int? statecode = default(int?), string adoxioPolicejurisdictionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statuscode = default(int?), string versionnumber = default(string), string adoxioPosition = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string adoxioName = default(string), string adoxioEmail = default(string), string _adoxioLginidValue = default(string), string adoxioContactname = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioPhonenumber = default(string), string adoxioFaxnumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioPolicejurisdictionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPolicejurisdictionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPolicejurisdictionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPolicejurisdictionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioPolicejurisdictionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioPolicejurisdictionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPolicejurisdictionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioPolicejurisdictionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioPolicejurisdictionAdoxioLicencesPDJurisdiction = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioPolicejurisdictionApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), MicrosoftDynamicsCRMadoxioLocalgovindigenousnation adoxioLGINId = default(MicrosoftDynamicsCRMadoxioLocalgovindigenousnation), IList<MicrosoftDynamicsCRMaccount> adoxioPolicejurisdictionAccount = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMadoxioSpecialevent> adoxioPolicejurisdictionSpecialevents = default(IList<MicrosoftDynamicsCRMadoxioSpecialevent>), IList<MicrosoftDynamicsCRMadoxioSepcity> adoxioPolicejurisdictionSepcities = default(IList<MicrosoftDynamicsCRMadoxioSepcity>))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            Statecode = statecode;
            AdoxioPolicejurisdictionid = adoxioPolicejurisdictionid;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            AdoxioPosition = adoxioPosition;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            AdoxioName = adoxioName;
            AdoxioEmail = adoxioEmail;
            this._adoxioLginidValue = _adoxioLginidValue;
            AdoxioContactname = adoxioContactname;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioFaxnumber = adoxioFaxnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioPolicejurisdictionSyncErrors = adoxioPolicejurisdictionSyncErrors;
            AdoxioPolicejurisdictionDuplicateMatchingRecord = adoxioPolicejurisdictionDuplicateMatchingRecord;
            AdoxioPolicejurisdictionDuplicateBaseRecord = adoxioPolicejurisdictionDuplicateBaseRecord;
            AdoxioPolicejurisdictionAsyncOperations = adoxioPolicejurisdictionAsyncOperations;
            AdoxioPolicejurisdictionMailboxTrackingFolders = adoxioPolicejurisdictionMailboxTrackingFolders;
            AdoxioPolicejurisdictionProcessSession = adoxioPolicejurisdictionProcessSession;
            AdoxioPolicejurisdictionBulkDeleteFailures = adoxioPolicejurisdictionBulkDeleteFailures;
            AdoxioPolicejurisdictionPrincipalObjectAttributeAccesses = adoxioPolicejurisdictionPrincipalObjectAttributeAccesses;
            AdoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction = adoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction;
            AdoxioPolicejurisdictionAdoxioLicencesPDJurisdiction = adoxioPolicejurisdictionAdoxioLicencesPDJurisdiction;
            AdoxioPolicejurisdictionApplications = adoxioPolicejurisdictionApplications;
            AdoxioLGINId = adoxioLGINId;
            AdoxioPolicejurisdictionAccount = adoxioPolicejurisdictionAccount;
            AdoxioPolicejurisdictionSpecialevents = adoxioPolicejurisdictionSpecialevents;
            AdoxioPolicejurisdictionSepcities = adoxioPolicejurisdictionSepcities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdictionid")]
        public string AdoxioPolicejurisdictionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_position")]
        public string AdoxioPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_lginid_value")]
        public string _adoxioLginidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactname")]
        public string AdoxioContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_faxnumber")]
        public string AdoxioFaxnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPolicejurisdictionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPolicejurisdictionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPolicejurisdictionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPolicejurisdictionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioPolicejurisdictionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioPolicejurisdictionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPolicejurisdictionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioPolicejurisdictionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_adoxio_establishment_PDJurisdiction")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioPolicejurisdictionAdoxioEstablishmentPDJurisdiction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_adoxio_licences_PDJurisdiction")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioPolicejurisdictionAdoxioLicencesPDJurisdiction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioPolicejurisdictionApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LGINId")]
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation AdoxioLGINId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_account")]
        public IList<MicrosoftDynamicsCRMaccount> AdoxioPolicejurisdictionAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_specialevents")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialevent> AdoxioPolicejurisdictionSpecialevents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policejurisdiction_sepcities")]
        public IList<MicrosoftDynamicsCRMadoxioSepcity> AdoxioPolicejurisdictionSepcities { get; set; }

    }
}
