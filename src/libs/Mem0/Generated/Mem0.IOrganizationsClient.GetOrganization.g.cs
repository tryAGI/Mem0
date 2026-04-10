#nullable enable

namespace Mem0
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get a organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetOrganizationResponse> GetOrganizationAsync(
            global::System.Guid orgId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}