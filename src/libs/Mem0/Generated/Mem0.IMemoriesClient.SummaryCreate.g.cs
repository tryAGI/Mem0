#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get a summary of memories matching the given filters.<br/>
        /// Backs the Python SDK's `client.get_summary()`. Not currently exposed by the TypeScript SDK.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> SummaryCreateAsync(

            global::Mem0.SummaryCreateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a summary of memories matching the given filters.<br/>
        /// Backs the Python SDK's `client.get_summary()`. Not currently exposed by the TypeScript SDK.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> SummaryCreateAsResponseAsync(

            global::Mem0.SummaryCreateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a summary of memories matching the given filters.<br/>
        /// Backs the Python SDK's `client.get_summary()`. Not currently exposed by the TypeScript SDK.
        /// </summary>
        /// <param name="filters">
        /// Either flat field:value pairs (e.g. `{"user_id": "&lt;user_id&gt;"}`) or the structured AND/OR filter format used by `/v2/memories/search/`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> SummaryCreateAsync(
            object filters,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}