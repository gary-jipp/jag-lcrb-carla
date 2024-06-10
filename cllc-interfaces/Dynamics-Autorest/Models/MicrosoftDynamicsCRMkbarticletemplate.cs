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
    /// Microsoft.Dynamics.CRM.kbarticletemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMkbarticletemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMkbarticletemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMkbarticletemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMkbarticletemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMkbarticletemplate(string kbarticletemplateid = default(string), string iscustomizable = default(string), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), string description = default(string), bool? ismanaged = default(bool?), int? languagecode = default(int?), string _createdonbehalfbyValue = default(string), string formatxml = default(string), string solutionid = default(string), string _createdbyValue = default(string), bool? isactive = default(bool?), string structurexml = default(string), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string title = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string introducedversion = default(string), string _organizationidValue = default(string), int? componentstate = default(int?), string kbarticletemplateidunique = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprocesssession> kbArticleTemplateProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMasyncoperation> kbArticleTemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMkbarticle> kbArticleTemplateKbArticles = default(IList<MicrosoftDynamicsCRMkbarticle>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> kbArticleTemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMbulkdeletefailure> kbArticleTemplateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Kbarticletemplateid = kbarticletemplateid;
            Iscustomizable = iscustomizable;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Description = description;
            Ismanaged = ismanaged;
            Languagecode = languagecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Formatxml = formatxml;
            Solutionid = solutionid;
            this._createdbyValue = _createdbyValue;
            Isactive = isactive;
            Structurexml = structurexml;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Overwritetime = overwritetime;
            Title = title;
            Modifiedon = modifiedon;
            Createdon = createdon;
            Introducedversion = introducedversion;
            this._organizationidValue = _organizationidValue;
            Componentstate = componentstate;
            Kbarticletemplateidunique = kbarticletemplateidunique;
            Createdby = createdby;
            KbArticleTemplateProcessSessions = kbArticleTemplateProcessSessions;
            KbArticleTemplateAsyncOperations = kbArticleTemplateAsyncOperations;
            KbArticleTemplateKbArticles = kbArticleTemplateKbArticles;
            Createdonbehalfby = createdonbehalfby;
            KbArticleTemplateSyncErrors = kbArticleTemplateSyncErrors;
            KbArticleTemplateBulkDeleteFailures = kbArticleTemplateBulkDeleteFailures;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticletemplateid")]
        public string Kbarticletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formatxml")]
        public string Formatxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isactive")]
        public bool? Isactive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "structurexml")]
        public string Structurexml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

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
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticletemplateidunique")]
        public string Kbarticletemplateidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticleTemplate_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> KbArticleTemplateProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticleTemplate_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KbArticleTemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kb_article_template_kb_articles")]
        public IList<MicrosoftDynamicsCRMkbarticle> KbArticleTemplateKbArticles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticleTemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KbArticleTemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticleTemplate_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KbArticleTemplateBulkDeleteFailures { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
