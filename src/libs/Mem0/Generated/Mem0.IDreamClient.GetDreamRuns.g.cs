#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Get Dream synthesis runs<br/>
        /// Synthesis activity grouped per run (newest first), keyset-paginated. Each run inlines its first page of synthesized memories with their sources; larger runs page the rest via the run-memories endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetDreamRunsResponse> GetDreamRunsAsync(
            string orgId,
            string projectId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dream synthesis runs<br/>
        /// Synthesis activity grouped per run (newest first), keyset-paginated. Each run inlines its first page of synthesized memories with their sources; larger runs page the rest via the run-memories endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetDreamRunsResponse>> GetDreamRunsAsResponseAsync(
            string orgId,
            string projectId,
            int? limit = default,
            string? cursor = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}