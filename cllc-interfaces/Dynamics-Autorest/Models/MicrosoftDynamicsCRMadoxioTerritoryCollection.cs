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
    /// Collection of adoxio_territory
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_territoryCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioTerritoryCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritoryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritoryCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritoryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritoryCollection(IList<MicrosoftDynamicsCRMadoxioTerritory> value = default(IList<MicrosoftDynamicsCRMadoxioTerritory>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioTerritory> Value { get; set; }

    }
}