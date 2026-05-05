#nullable enable

namespace Mem0
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization members<br/>
        /// Retrieve a list of members for a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetOrganizationMembersResponse> GetOrganizationMembersAsync(
            string orgId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization members<br/>
        /// Retrieve a list of members for a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetOrganizationMembersResponse>> GetOrganizationMembersAsResponseAsync(
            string orgId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}