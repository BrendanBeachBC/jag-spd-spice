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
    /// Collection of spice_services
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.spice_servicesCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMspiceServicesCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceServicesCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServicesCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceServicesCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServicesCollection(IList<MicrosoftDynamicsCRMspiceServices> value = default(IList<MicrosoftDynamicsCRMspiceServices>))
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
        public IList<MicrosoftDynamicsCRMspiceServices> Value { get; set; }

    }
}
