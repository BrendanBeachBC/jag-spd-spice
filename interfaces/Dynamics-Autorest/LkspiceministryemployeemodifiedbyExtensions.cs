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
    /// Extension methods for Lkspiceministryemployeemodifiedby.
    /// </summary>
    public static partial class LkspiceministryemployeemodifiedbyExtensions
    {
            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static MicrosoftDynamicsCRMspiceMinistryemployeeCollection Get(this ILkspiceministryemployeemodifiedby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(ownerid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static async Task<MicrosoftDynamicsCRMspiceMinistryemployeeCollection> GetAsync(this ILkspiceministryemployeemodifiedby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(ownerid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceMinistryemployeeCollection> GetWithHttpMessages(this ILkspiceministryemployeemodifiedby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(ownerid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceMinistryemployee ModifiedbyByKey(this ILkspiceministryemployeemodifiedby operations, string ownerid, string spiceMinistryemployeeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ModifiedbyByKeyAsync(ownerid, spiceMinistryemployeeid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
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
            public static async Task<MicrosoftDynamicsCRMspiceMinistryemployee> ModifiedbyByKeyAsync(this ILkspiceministryemployeemodifiedby operations, string ownerid, string spiceMinistryemployeeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ModifiedbyByKeyWithHttpMessagesAsync(ownerid, spiceMinistryemployeeid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_spice_ministryemployee_modifiedby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='spiceMinistryemployeeid'>
            /// key: spice_ministryemployeeid of spice_ministryemployee
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceMinistryemployee> ModifiedbyByKeyWithHttpMessages(this ILkspiceministryemployeemodifiedby operations, string ownerid, string spiceMinistryemployeeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ModifiedbyByKeyWithHttpMessagesAsync(ownerid, spiceMinistryemployeeid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
