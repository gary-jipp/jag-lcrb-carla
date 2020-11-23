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
    /// Microsoft.Dynamics.CRM.adoxio_specialevent
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioSpecialevent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpecialevent class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpecialevent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpecialevent class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpecialevent(string adoxioEventname = default(string), string adoxioResponsibleindividualfirstname = default(string), int? utcconversiontimezonecode = default(int?), string adoxioResponsibleindividuallastname = default(string), string adoxioSpecialeventid = default(string), string adoxioSpecialeventstreet1 = default(string), int? statuscode = default(int?), string adoxioSpecialeventcity = default(string), bool? adoxioTastingevent = default(bool?), string adoxioSpecialeventapplicantphone = default(string), string _owninguserValue = default(string), int? adoxioCapacity = default(int?), string adoxioSpecialeventprovince = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string _owneridValue = default(string), string adoxioEventtype = default(string), string _createdonbehalfbyValue = default(string), string adoxioSeplicencenumber = default(string), string adoxioSpecialeventdescripton = default(string), int? adoxioTypeofevent = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), string _modifiedbyValue = default(string), string adoxioResponsibleindividualposition = default(string), string adoxioSpecialeventapplicantemail = default(string), string adoxioSpecialeventpostalcode = default(string), string adoxioResponsibleindividualsir = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioResponsibleindividualmiddleinitial = default(string), string adoxioSpecialeventapplicant = default(string), string versionnumber = default(string), string _owningbusinessunitValue = default(string), string adoxioSpecialeventstreet2 = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioSpecialeventSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioSpecialeventDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioSpecialeventDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioSpecialeventAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioSpecialeventMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioSpecialeventProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioSpecialeventBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioSpecialeventPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMadoxioSpecialeventlocation> adoxioSpecialeventSpecialeventlocations = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventlocation>), IList<MicrosoftDynamicsCRMactivitypointer> adoxioSpecialeventActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> adoxioSpecialeventAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMappointment> adoxioSpecialeventAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioSpecialeventEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioSpecialeventFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioSpecialeventLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioSpecialeventPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> adoxioSpecialeventTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioSpecialeventRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioSpecialeventSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioSpecialeventServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMannotation> adoxioSpecialeventAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMactivityparty> adoxioSpecialeventActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMadoxioSpecialeventschedule> adoxioSpecialeventSchedule = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventschedule>), IList<MicrosoftDynamicsCRMadoxioSpecialeventlicencedarea> adoxioSpecialeventLicencedarea = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventlicencedarea>), IList<MicrosoftDynamicsCRMadoxioSpecialeventnote> adoxioSpecialeventSpecialeventnotes = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventnote>), IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc> adoxioSpecialeventSpecialeventtsacs = default(IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc>))
        {
            AdoxioEventname = adoxioEventname;
            AdoxioResponsibleindividualfirstname = adoxioResponsibleindividualfirstname;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioResponsibleindividuallastname = adoxioResponsibleindividuallastname;
            AdoxioSpecialeventid = adoxioSpecialeventid;
            AdoxioSpecialeventstreet1 = adoxioSpecialeventstreet1;
            Statuscode = statuscode;
            AdoxioSpecialeventcity = adoxioSpecialeventcity;
            AdoxioTastingevent = adoxioTastingevent;
            AdoxioSpecialeventapplicantphone = adoxioSpecialeventapplicantphone;
            this._owninguserValue = _owninguserValue;
            AdoxioCapacity = adoxioCapacity;
            AdoxioSpecialeventprovince = adoxioSpecialeventprovince;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._owneridValue = _owneridValue;
            AdoxioEventtype = adoxioEventtype;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioSeplicencenumber = adoxioSeplicencenumber;
            AdoxioSpecialeventdescripton = adoxioSpecialeventdescripton;
            AdoxioTypeofevent = adoxioTypeofevent;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Statecode = statecode;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioResponsibleindividualposition = adoxioResponsibleindividualposition;
            AdoxioSpecialeventapplicantemail = adoxioSpecialeventapplicantemail;
            AdoxioSpecialeventpostalcode = adoxioSpecialeventpostalcode;
            AdoxioResponsibleindividualsir = adoxioResponsibleindividualsir;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            AdoxioResponsibleindividualmiddleinitial = adoxioResponsibleindividualmiddleinitial;
            AdoxioSpecialeventapplicant = adoxioSpecialeventapplicant;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioSpecialeventstreet2 = adoxioSpecialeventstreet2;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioSpecialeventSyncErrors = adoxioSpecialeventSyncErrors;
            AdoxioSpecialeventDuplicateMatchingRecord = adoxioSpecialeventDuplicateMatchingRecord;
            AdoxioSpecialeventDuplicateBaseRecord = adoxioSpecialeventDuplicateBaseRecord;
            AdoxioSpecialeventAsyncOperations = adoxioSpecialeventAsyncOperations;
            AdoxioSpecialeventMailboxTrackingFolders = adoxioSpecialeventMailboxTrackingFolders;
            AdoxioSpecialeventProcessSession = adoxioSpecialeventProcessSession;
            AdoxioSpecialeventBulkDeleteFailures = adoxioSpecialeventBulkDeleteFailures;
            AdoxioSpecialeventPrincipalObjectAttributeAccesses = adoxioSpecialeventPrincipalObjectAttributeAccesses;
            AdoxioSpecialeventSpecialeventlocations = adoxioSpecialeventSpecialeventlocations;
            AdoxioSpecialeventActivityPointers = adoxioSpecialeventActivityPointers;
            AdoxioSpecialeventAbsScheduledprocessexecutions = adoxioSpecialeventAbsScheduledprocessexecutions;
            AdoxioSpecialeventAppointments = adoxioSpecialeventAppointments;
            AdoxioSpecialeventEmails = adoxioSpecialeventEmails;
            AdoxioSpecialeventFaxes = adoxioSpecialeventFaxes;
            AdoxioSpecialeventLetters = adoxioSpecialeventLetters;
            AdoxioSpecialeventPhoneCalls = adoxioSpecialeventPhoneCalls;
            AdoxioSpecialeventTasks = adoxioSpecialeventTasks;
            AdoxioSpecialeventRecurringAppointmentMasters = adoxioSpecialeventRecurringAppointmentMasters;
            AdoxioSpecialeventSocialActivities = adoxioSpecialeventSocialActivities;
            AdoxioSpecialeventServiceAppointments = adoxioSpecialeventServiceAppointments;
            AdoxioSpecialeventAnnotations = adoxioSpecialeventAnnotations;
            AdoxioSpecialeventActivityParties = adoxioSpecialeventActivityParties;
            AdoxioSpecialeventSchedule = adoxioSpecialeventSchedule;
            AdoxioSpecialeventLicencedarea = adoxioSpecialeventLicencedarea;
            AdoxioSpecialeventSpecialeventnotes = adoxioSpecialeventSpecialeventnotes;
            AdoxioSpecialeventSpecialeventtsacs = adoxioSpecialeventSpecialeventtsacs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventname")]
        public string AdoxioEventname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsibleindividualfirstname")]
        public string AdoxioResponsibleindividualfirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsibleindividuallastname")]
        public string AdoxioResponsibleindividuallastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventid")]
        public string AdoxioSpecialeventid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventstreet1")]
        public string AdoxioSpecialeventstreet1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventcity")]
        public string AdoxioSpecialeventcity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tastingevent")]
        public bool? AdoxioTastingevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventapplicantphone")]
        public string AdoxioSpecialeventapplicantphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_capacity")]
        public int? AdoxioCapacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventprovince")]
        public string AdoxioSpecialeventprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventtype")]
        public string AdoxioEventtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_seplicencenumber")]
        public string AdoxioSeplicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventdescripton")]
        public string AdoxioSpecialeventdescripton { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_typeofevent")]
        public int? AdoxioTypeofevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsibleindividualposition")]
        public string AdoxioResponsibleindividualposition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventapplicantemail")]
        public string AdoxioSpecialeventapplicantemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventpostalcode")]
        public string AdoxioSpecialeventpostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsibleindividualsir")]
        public string AdoxioResponsibleindividualsir { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_responsibleindividualmiddleinitial")]
        public string AdoxioResponsibleindividualmiddleinitial { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventapplicant")]
        public string AdoxioSpecialeventapplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialeventstreet2")]
        public string AdoxioSpecialeventstreet2 { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_specialevent_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioSpecialeventSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioSpecialeventDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioSpecialeventDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioSpecialeventAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioSpecialeventMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioSpecialeventProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioSpecialeventBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioSpecialeventPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_specialeventlocations")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventlocation> AdoxioSpecialeventSpecialeventlocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioSpecialeventActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AdoxioSpecialeventAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioSpecialeventAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioSpecialeventEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioSpecialeventFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioSpecialeventLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioSpecialeventPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioSpecialeventTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioSpecialeventRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioSpecialeventSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioSpecialeventServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioSpecialeventAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AdoxioSpecialeventActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_schedule")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventschedule> AdoxioSpecialeventSchedule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_licencedarea")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventlicencedarea> AdoxioSpecialeventLicencedarea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_specialeventnotes")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventnote> AdoxioSpecialeventSpecialeventnotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specialevent_specialeventtsacs")]
        public IList<MicrosoftDynamicsCRMadoxioSpecialeventtandc> AdoxioSpecialeventSpecialeventtsacs { get; set; }

    }
}
