// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of spice_spice_businesscaseprocess
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.spice_spice_businesscaseprocessCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection(IList<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess> value = default(IList<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess>))
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
        public IList<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess> Value { get; set; }

    }
}