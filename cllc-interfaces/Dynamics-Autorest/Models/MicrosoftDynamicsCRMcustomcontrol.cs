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
    /// Microsoft.Dynamics.CRM.customcontrol
    /// </summary>
    public partial class MicrosoftDynamicsCRMcustomcontrol
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcustomcontrol
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontrol()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcustomcontrol
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontrol(bool? ismanaged = default(bool?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string compatibledatatypes = default(string), string solutionid = default(string), string _modifiedbyValue = default(string), string clientjson = default(string), string customcontrolid = default(string), string _organizationidValue = default(string), string authoringmanifest = default(string), string version = default(string), string customcontrolidunique = default(string), int? componentstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string name = default(string), string manifest = default(string), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string introducedversion = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcustomcontrolresource> customcontrolResourceId = default(IList<MicrosoftDynamicsCRMcustomcontrolresource>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Ismanaged = ismanaged;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Compatibledatatypes = compatibledatatypes;
            Solutionid = solutionid;
            this._modifiedbyValue = _modifiedbyValue;
            Clientjson = clientjson;
            Customcontrolid = customcontrolid;
            this._organizationidValue = _organizationidValue;
            Authoringmanifest = authoringmanifest;
            Version = version;
            Customcontrolidunique = customcontrolidunique;
            Componentstate = componentstate;
            Overwritetime = overwritetime;
            Name = name;
            Manifest = manifest;
            Versionnumber = versionnumber;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Introducedversion = introducedversion;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomcontrolResourceId = customcontrolResourceId;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatibledatatypes")]
        public string Compatibledatatypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientjson")]
        public string Clientjson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolid")]
        public string Customcontrolid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authoringmanifest")]
        public string Authoringmanifest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolidunique")]
        public string Customcontrolidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrol_resource_id")]
        public IList<MicrosoftDynamicsCRMcustomcontrolresource> CustomcontrolResourceId { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
