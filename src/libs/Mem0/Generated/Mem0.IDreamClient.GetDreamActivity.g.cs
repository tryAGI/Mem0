#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Get Dream activity<br/>
        /// Supersede/merge activity feed (newest first), keyset-paginated. Synthesis output is not included here — see the runs endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetDreamActivityResponse> GetDreamActivityAsync(
            string orgId,
            string projectId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dream activity<br/>
        /// Supersede/merge activity feed (newest first), keyset-paginated. Synthesis output is not included here — see the runs endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetDreamActivityResponse>> GetDreamActivityAsResponseAsync(
            string orgId,
            string projectId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}