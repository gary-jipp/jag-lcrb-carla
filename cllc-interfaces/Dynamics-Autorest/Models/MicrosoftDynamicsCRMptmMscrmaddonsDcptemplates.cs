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
    /// Microsoft.Dynamics.CRM.ptm_mscrmaddons_dcptemplates
    /// </summary>
    public partial class MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates class.
        /// </summary>
        public MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates class.
        /// </summary>
        public MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates(int? statuscode = default(int?), bool? ptmLabeltemplate = default(bool?), string ptmCompany = default(string), int? importsequencenumber = default(int?), string _owningteamValue = default(string), string versionnumber = default(string), int? timezoneruleversionnumber = default(int?), string ptmComments = default(string), string _modifiedonbehalfbyValue = default(string), string ptmChecksum = default(string), string _createdbyValue = default(string), string _owninguserValue = default(string), string ptmKeywords = default(string), string _ptmRevisionidValue = default(string), string ptmEntitytype = default(string), string _createdonbehalfbyValue = default(string), string ptmName = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ptmMscrmaddonsDcptemplatesid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ptmGroup = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string ptmProperties = default(string), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), string _ptmPreviewimageidValue = default(string), string ptmManager = default(string), string ptmSubject = default(string), string _owneridValue = default(string), string ptmCategory = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ptmMscrmaddonsDcptemplatesSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> ptmMscrmaddonsDcptemplatesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ptmMscrmaddonsDcptemplatesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ptmMscrmaddonsDcptemplatesProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ptmMscrmaddonsDcptemplatesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ptmMscrmaddonsDcptemplatesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> ptmMscrmaddonsDcptemplatesAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates ptmRevisionid = default(MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates), IList<MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates> ptmPtmMscrmaddonsDcptemplatesPtmMscrmaddonsDcptemplatesRevision = default(IList<MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates>), MicrosoftDynamicsCRMptmMscrmaddonstemp ptmPreviewimageid = default(MicrosoftDynamicsCRMptmMscrmaddonstemp), IList<MicrosoftDynamicsCRMptmAutomergeworkingitems> ptmPtmMscrmaddonsDcptemplatesPtmAutomerg = default(IList<MicrosoftDynamicsCRMptmAutomergeworkingitems>))
        {
            Statuscode = statuscode;
            PtmLabeltemplate = ptmLabeltemplate;
            PtmCompany = ptmCompany;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            PtmComments = ptmComments;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            PtmChecksum = ptmChecksum;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            PtmKeywords = ptmKeywords;
            this._ptmRevisionidValue = _ptmRevisionidValue;
            PtmEntitytype = ptmEntitytype;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            PtmName = ptmName;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            PtmMscrmaddonsDcptemplatesid = ptmMscrmaddonsDcptemplatesid;
            Overriddencreatedon = overriddencreatedon;
            PtmGroup = ptmGroup;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            PtmProperties = ptmProperties;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            this._ptmPreviewimageidValue = _ptmPreviewimageidValue;
            PtmManager = ptmManager;
            PtmSubject = ptmSubject;
            this._owneridValue = _owneridValue;
            PtmCategory = ptmCategory;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            PtmMscrmaddonsDcptemplatesSyncErrors = ptmMscrmaddonsDcptemplatesSyncErrors;
            PtmMscrmaddonsDcptemplatesAsyncOperations = ptmMscrmaddonsDcptemplatesAsyncOperations;
            PtmMscrmaddonsDcptemplatesMailboxTrackingFolders = ptmMscrmaddonsDcptemplatesMailboxTrackingFolders;
            PtmMscrmaddonsDcptemplatesProcessSession = ptmMscrmaddonsDcptemplatesProcessSession;
            PtmMscrmaddonsDcptemplatesBulkDeleteFailures = ptmMscrmaddonsDcptemplatesBulkDeleteFailures;
            PtmMscrmaddonsDcptemplatesPrincipalObjectAttributeAccesses = ptmMscrmaddonsDcptemplatesPrincipalObjectAttributeAccesses;
            PtmMscrmaddonsDcptemplatesAnnotations = ptmMscrmaddonsDcptemplatesAnnotations;
            PtmRevisionid = ptmRevisionid;
            PtmPtmMscrmaddonsDcptemplatesPtmMscrmaddonsDcptemplatesRevision = ptmPtmMscrmaddonsDcptemplatesPtmMscrmaddonsDcptemplatesRevision;
            PtmPreviewimageid = ptmPreviewimageid;
            PtmPtmMscrmaddonsDcptemplatesPtmAutomerg = ptmPtmMscrmaddonsDcptemplatesPtmAutomerg;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_labeltemplate")]
        public bool? PtmLabeltemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_company")]
        public string PtmCompany { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_comments")]
        public string PtmComments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_checksum")]
        public string PtmChecksum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_keywords")]
        public string PtmKeywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ptm_revisionid_value")]
        public string _ptmRevisionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_entitytype")]
        public string PtmEntitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_name")]
        public string PtmName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplatesid")]
        public string PtmMscrmaddonsDcptemplatesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_group")]
        public string PtmGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_properties")]
        public string PtmProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ptm_previewimageid_value")]
        public string _ptmPreviewimageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_manager")]
        public string PtmManager { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_subject")]
        public string PtmSubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_category")]
        public string PtmCategory { get; set; }

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
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PtmMscrmaddonsDcptemplatesSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PtmMscrmaddonsDcptemplatesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> PtmMscrmaddonsDcptemplatesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> PtmMscrmaddonsDcptemplatesProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PtmMscrmaddonsDcptemplatesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PtmMscrmaddonsDcptemplatesPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddons_dcptemplates_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> PtmMscrmaddonsDcptemplatesAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_revisionid")]
        public MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates PtmRevisionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_ptm_mscrmaddons_dcptemplates_ptm_mscrmaddons_dcptemplates_revision")]
        public IList<MicrosoftDynamicsCRMptmMscrmaddonsDcptemplates> PtmPtmMscrmaddonsDcptemplatesPtmMscrmaddonsDcptemplatesRevision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_previewimageid")]
        public MicrosoftDynamicsCRMptmMscrmaddonstemp PtmPreviewimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_ptm_mscrmaddons_dcptemplates_ptm_automerg")]
        public IList<MicrosoftDynamicsCRMptmAutomergeworkingitems> PtmPtmMscrmaddonsDcptemplatesPtmAutomerg { get; set; }

    }
}
