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
    /// Extension methods for Ministryemployeeactivityparties.
    /// </summary>
    public static partial class MinistryemployeeactivitypartiesExtensions
    {
            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
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
            public static MicrosoftDynamicsCRMactivitypartyCollection Get(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(spiceMinistryemployeeid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
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
            public static async Task<MicrosoftDynamicsCRMactivitypartyCollection> GetAsync(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(spiceMinistryemployeeid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMactivitypartyCollection> GetWithHttpMessages(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(spiceMinistryemployeeid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
            /// </param>
            /// <param name='activitypartyid'>
            /// key: activitypartyid of activityparty
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMactivityparty ActivityPartiesByKey(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, string activitypartyid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ActivityPartiesByKeyAsync(spiceMinistryemployeeid, activitypartyid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
            /// </param>
            /// <param name='activitypartyid'>
            /// key: activitypartyid of activityparty
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
            public static async Task<MicrosoftDynamicsCRMactivityparty> ActivityPartiesByKeyAsync(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, string activitypartyid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ActivityPartiesByKeyWithHttpMessagesAsync(spiceMinistryemployeeid, activitypartyid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get spice_ministryemployee_ActivityParties from spice_ministryemployees
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
            /// </param>
            /// <param name='activitypartyid'>
            /// key: activitypartyid of activityparty
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMactivityparty> ActivityPartiesByKeyWithHttpMessages(this IMinistryemployeeactivityparties operations, string spiceMinistryemployeeid, string activitypartyid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ActivityPartiesByKeyWithHttpMessagesAsync(spiceMinistryemployeeid, activitypartyid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}