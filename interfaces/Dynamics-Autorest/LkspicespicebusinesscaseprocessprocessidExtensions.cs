// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Lkspicespicebusinesscaseprocessprocessid.
    /// </summary>
    public static partial class LkspicespicebusinesscaseprocessprocessidExtensions
    {
            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection Get(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(workflowid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection> GetAsync(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(workflowid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocessCollection> GetWithHttpMessages(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(workflowid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of spice_spice_businesscaseprocess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess ProcessidByKey(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, string businessprocessflowinstanceid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ProcessidByKeyAsync(workflowid, businessprocessflowinstanceid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of spice_spice_businesscaseprocess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess> ProcessidByKeyAsync(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, string businessprocessflowinstanceid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ProcessidByKeyWithHttpMessagesAsync(workflowid, businessprocessflowinstanceid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_spice_spice_businesscaseprocess_processid from workflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowid'>
            /// key: workflowid of workflow
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of spice_spice_businesscaseprocess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceSpiceBusinesscaseprocess> ProcessidByKeyWithHttpMessages(this ILkspicespicebusinesscaseprocessprocessid operations, string workflowid, string businessprocessflowinstanceid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ProcessidByKeyWithHttpMessagesAsync(workflowid, businessprocessflowinstanceid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
