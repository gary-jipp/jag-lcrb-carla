// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.pluginassembly
    /// </summary>
    public partial class MicrosoftDynamicsCRMpluginassembly
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly(string culture = default(string), string _modifiedbyValue = default(string), string version = default(string), string description = default(string), string sourcehash = default(string), string username = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string introducedversion = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? customizationlevel = default(int?), string publickeytoken = default(string), string content = default(string), byte[] contentBinary = default(byte[]), string path = default(string), string name = default(string), string _createdonbehalfbyValue = default(string), bool? ispasswordset = default(bool?), string password = default(string), string _organizationidValue = default(string), int? isolationmode = default(int?), string url = default(string), string iscustomizable = default(string), string _createdbyValue = default(string), int? major = default(int?), int? minor = default(int?), int? componentstate = default(int?), string _modifiedonbehalfbyValue = default(string), string solutionid = default(string), int? authtype = default(int?), int? sourcetype = default(int?), string pluginassemblyid = default(string), string ishidden = default(string), string pluginassemblyidunique = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMplugintype> pluginassemblyPlugintype = default(IList<MicrosoftDynamicsCRMplugintype>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Culture = culture;
            this._modifiedbyValue = _modifiedbyValue;
            Version = version;
            Description = description;
            Sourcehash = sourcehash;
            Username = username;
            Ismanaged = ismanaged;
            Modifiedon = modifiedon;
            Introducedversion = introducedversion;
            Createdon = createdon;
            Customizationlevel = customizationlevel;
            Publickeytoken = publickeytoken;
            Content = content;
            ContentBinary = contentBinary;
            Path = path;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Ispasswordset = ispasswordset;
            Password = password;
            this._organizationidValue = _organizationidValue;
            Isolationmode = isolationmode;
            Url = url;
            Iscustomizable = iscustomizable;
            this._createdbyValue = _createdbyValue;
            Major = major;
            Minor = minor;
            Componentstate = componentstate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Solutionid = solutionid;
            Authtype = authtype;
            Sourcetype = sourcetype;
            Pluginassemblyid = pluginassemblyid;
            Ishidden = ishidden;
            Pluginassemblyidunique = pluginassemblyidunique;
            Overwritetime = overwritetime;
            Versionnumber = versionnumber;
            Createdby = createdby;
            PluginassemblyPlugintype = pluginassemblyPlugintype;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcehash")]
        public string Sourcehash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publickeytoken")]
        public string Publickeytoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "content_binary")]
        public byte[] ContentBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispasswordset")]
        public bool? Ispasswordset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isolationmode")]
        public int? Isolationmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public int? Major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public int? Minor { get; set; }

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
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authtype")]
        public int? Authtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcetype")]
        public int? Sourcetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyid")]
        public string Pluginassemblyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public string Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyidunique")]
        public string Pluginassemblyidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

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
        [JsonProperty(PropertyName = "pluginassembly_plugintype")]
        public IList<MicrosoftDynamicsCRMplugintype> PluginassemblyPlugintype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
