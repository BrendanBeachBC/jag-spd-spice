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
    /// Collection of spice_exportrequest
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.spice_exportrequestCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMspiceExportrequestCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceExportrequestCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceExportrequestCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceExportrequestCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceExportrequestCollection(IList<MicrosoftDynamicsCRMspiceExportrequest> value = default(IList<MicrosoftDynamicsCRMspiceExportrequest>))
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
        public IList<MicrosoftDynamicsCRMspiceExportrequest> Value { get; set; }

    }
}
