// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_list_adoxio_externalcontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioListAdoxioExternalcontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioListAdoxioExternalcontact class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioListAdoxioExternalcontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioListAdoxioExternalcontact class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioListAdoxioExternalcontact(string adoxioExternalcontactid = default(string), string adoxioListAdoxioExternalcontactid = default(string), string listid = default(string), string versionnumber = default(string))
        {
            AdoxioExternalcontactid = adoxioExternalcontactid;
            AdoxioListAdoxioExternalcontactid = adoxioListAdoxioExternalcontactid;
            Listid = listid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_externalcontactid")]
        public string AdoxioExternalcontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_list_adoxio_externalcontactid")]
        public string AdoxioListAdoxioExternalcontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listid")]
        public string Listid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

    }
}
