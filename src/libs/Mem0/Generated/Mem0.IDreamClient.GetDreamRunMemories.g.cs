#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Get memories in a Dream run<br/>
        /// Keyset page of the synthesized memories within a single run (for runs whose `has_more` is true).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetDreamRunMemoriesResponse> GetDreamRunMemoriesAsync(
            string orgId,
            string projectId,
            string runId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get memories in a Dream run<br/>
        /// Keyset page of the synthesized memories within a single run (for runs whose `has_more` is true).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetDreamRunMemoriesResponse>> GetDreamRunMemoriesAsResponseAsync(
            string orgId,
            string projectId,
            string runId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}