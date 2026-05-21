#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Delete memories by filter. At least one filter is required — previously omitting all filters silently deleted everything; now it returns a validation error.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesDeleteAllResponse> MemoriesDeleteAllAsync(
            string? userId = default,
            string? agentId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            string? orgId = default,
            string? projectId = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete memories by filter. At least one filter is required — previously omitting all filters silently deleted everything; now it returns a validation error.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.MemoriesDeleteAllResponse>> MemoriesDeleteAllAsResponseAsync(
            string? userId = default,
            string? agentId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            string? orgId = default,
            string? projectId = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}