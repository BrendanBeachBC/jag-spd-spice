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
    /// Collection of spice_lcrblicencetype
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.spice_lcrblicencetypeCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMspiceLcrblicencetypeCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceLcrblicencetypeCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceLcrblicencetypeCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceLcrblicencetypeCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceLcrblicencetypeCollection(IList<MicrosoftDynamicsCRMspiceLcrblicencetype> value = default(IList<MicrosoftDynamicsCRMspiceLcrblicencetype>))
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
        public IList<MicrosoftDynamicsCRMspiceLcrblicencetype> Value { get; set; }

    }
}
