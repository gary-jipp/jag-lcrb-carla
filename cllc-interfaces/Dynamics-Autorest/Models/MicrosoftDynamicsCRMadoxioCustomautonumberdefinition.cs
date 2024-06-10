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
    /// Microsoft.Dynamics.CRM.adoxio_customautonumberdefinition
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioCustomautonumberdefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCustomautonumberdefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCustomautonumberdefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCustomautonumberdefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCustomautonumberdefinition(int? adoxioDigits = default(int?), System.DateTimeOffset? adoxioLocktimestamp = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string versionnumber = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioFormat = default(string), string _createdonbehalfbyValue = default(string), string adoxioCustomautonumberdefinitionid = default(string), int? statecode = default(int?), string _createdbyValue = default(string), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string adoxioLockvalue = default(string), string adoxioName = default(string), int? adoxioLastnumberissued = default(int?), string _modifiedbyValue = default(string), string adoxioLockverification = default(string), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioCustomautonumberdefinitionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioCustomautonumberdefinitionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioCustomautonumberdefinitionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioCustomautonumberdefinitionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioCustomautonumberdefinitionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioCustomautonumberdefinitionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            AdoxioDigits = adoxioDigits;
            AdoxioLocktimestamp = adoxioLocktimestamp;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            AdoxioFormat = adoxioFormat;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioCustomautonumberdefinitionid = adoxioCustomautonumberdefinitionid;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioLockvalue = adoxioLockvalue;
            AdoxioName = adoxioName;
            AdoxioLastnumberissued = adoxioLastnumberissued;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioLockverification = adoxioLockverification;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioCustomautonumberdefinitionSyncErrors = adoxioCustomautonumberdefinitionSyncErrors;
            AdoxioCustomautonumberdefinitionAsyncOperations = adoxioCustomautonumberdefinitionAsyncOperations;
            AdoxioCustomautonumberdefinitionMailboxTrackingFolders = adoxioCustomautonumberdefinitionMailboxTrackingFolders;
            AdoxioCustomautonumberdefinitionProcessSession = adoxioCustomautonumberdefinitionProcessSession;
            AdoxioCustomautonumberdefinitionBulkDeleteFailures = adoxioCustomautonumberdefinitionBulkDeleteFailures;
            AdoxioCustomautonumberdefinitionPrincipalObjectAttributeAccesses = adoxioCustomautonumberdefinitionPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_digits")]
        public int? AdoxioDigits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_locktimestamp")]
        public System.DateTimeOffset? AdoxioLocktimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_format")]
        public string AdoxioFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinitionid")]
        public string AdoxioCustomautonumberdefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lockvalue")]
        public string AdoxioLockvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastnumberissued")]
        public int? AdoxioLastnumberissued { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lockverification")]
        public string AdoxioLockverification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioCustomautonumberdefinitionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioCustomautonumberdefinitionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioCustomautonumberdefinitionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioCustomautonumberdefinitionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioCustomautonumberdefinitionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberdefinition_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioCustomautonumberdefinitionPrincipalObjectAttributeAccesses { get; set; }

    }
}
