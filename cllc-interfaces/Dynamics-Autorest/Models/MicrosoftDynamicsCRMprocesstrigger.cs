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
    /// Microsoft.Dynamics.CRM.processtrigger
    /// </summary>
    public partial class MicrosoftDynamicsCRMprocesstrigger
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprocesstrigger class.
        /// </summary>
        public MicrosoftDynamicsCRMprocesstrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprocesstrigger class.
        /// </summary>
        public MicrosoftDynamicsCRMprocesstrigger(string processtriggerid = default(string), string _formidValue = default(string), string methodid = default(string), string iscustomizable = default(string), int? controltype = default(int?), int? scope = default(int?), int? componentstate = default(int?), string _modifiedonbehalfbyValue = default(string), string owninguser = default(string), string owningbusinessunit = default(string), string _createdbyValue = default(string), string processtriggeridunique = default(string), string _processidValue = default(string), string _modifiedbyValue = default(string), string primaryentitytypecode = default(string), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), bool? ismanaged = default(bool?), string solutionid = default(string), int? pipelinestage = default(int?), string versionnumber = default(string), string eventProperty = default(string), string controlname = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> processTriggerSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemform formid = default(MicrosoftDynamicsCRMsystemform), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Processtriggerid = processtriggerid;
            this._formidValue = _formidValue;
            Methodid = methodid;
            Iscustomizable = iscustomizable;
            Controltype = controltype;
            Scope = scope;
            Componentstate = componentstate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Owninguser = owninguser;
            Owningbusinessunit = owningbusinessunit;
            this._createdbyValue = _createdbyValue;
            Processtriggeridunique = processtriggeridunique;
            this._processidValue = _processidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Primaryentitytypecode = primaryentitytypecode;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Ismanaged = ismanaged;
            Solutionid = solutionid;
            Pipelinestage = pipelinestage;
            Versionnumber = versionnumber;
            EventProperty = eventProperty;
            Controlname = controlname;
            Overwritetime = overwritetime;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            ProcessTriggerSyncErrors = processTriggerSyncErrors;
            Formid = formid;
            Processid = processid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processtriggerid")]
        public string Processtriggerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_formid_value")]
        public string _formidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "methodid")]
        public string Methodid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "controltype")]
        public int? Controltype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public int? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processtriggeridunique")]
        public string Processtriggeridunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pipelinestage")]
        public int? Pipelinestage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public string EventProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "controlname")]
        public string Controlname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "ProcessTrigger_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProcessTriggerSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public MicrosoftDynamicsCRMsystemform Formid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
