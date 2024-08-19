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
    /// Microsoft.Dynamics.CRM.metric
    /// </summary>
    public partial class MicrosoftDynamicsCRMmetric
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmetric class.
        /// </summary>
        public MicrosoftDynamicsCRMmetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmetric class.
        /// </summary>
        public MicrosoftDynamicsCRMmetric(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string metricid = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), bool? isstretchtracked = default(bool?), string _createdbyValue = default(string), bool? isamount = default(bool?), int? statuscode = default(int?), int? importsequencenumber = default(int?), int? amountdatatype = default(int?), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), int? timezoneruleversionnumber = default(int?), string name = default(string), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string description = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMgoal> metricGoal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMrollupfield> metricRollupfield = default(IList<MicrosoftDynamicsCRMrollupfield>), IList<MicrosoftDynamicsCRMprocesssession> metricProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMasyncoperation> metricAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> metricSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Modifiedon = modifiedon;
            Metricid = metricid;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isstretchtracked = isstretchtracked;
            this._createdbyValue = _createdbyValue;
            Isamount = isamount;
            Statuscode = statuscode;
            Importsequencenumber = importsequencenumber;
            Amountdatatype = amountdatatype;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Description = description;
            Overriddencreatedon = overriddencreatedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MetricGoal = metricGoal;
            MetricRollupfield = metricRollupfield;
            MetricProcessSessions = metricProcessSessions;
            MetricAsyncOperations = metricAsyncOperations;
            MetricSyncErrors = metricSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metricid")]
        public string Metricid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isstretchtracked")]
        public bool? Isstretchtracked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isamount")]
        public bool? Isamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amountdatatype")]
        public int? Amountdatatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric_goal")]
        public IList<MicrosoftDynamicsCRMgoal> MetricGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric_rollupfield")]
        public IList<MicrosoftDynamicsCRMrollupfield> MetricRollupfield { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> MetricProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MetricAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Metric_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MetricSyncErrors { get; set; }

    }
}
