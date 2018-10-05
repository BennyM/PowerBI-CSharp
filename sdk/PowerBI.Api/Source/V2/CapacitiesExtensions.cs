// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Capacities.
    /// </summary>
    public static partial class CapacitiesExtensions
    {
            /// <summary>
            /// Gets a list of capacities the user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ODataResponseListCapacity GetCapacities(this ICapacities operations)
            {
                return operations.GetCapacitiesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of capacities the user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListCapacity> GetCapacitiesAsync(this ICapacities operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacitiesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
