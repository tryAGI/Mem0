#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Search memories (V3)<br/>
        /// Relevance-ranked search across stored memories. V3 uses hybrid retrieval — the returned `score` is a combined `[0, 1]` value; per-signal component scores are not exposed on the response. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. At least one entity ID is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.mem0.ai/v3/memories/search/ \<br/>
        ///   -H "Authorization: Token &lt;api-key&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "query": "where does the user live?",<br/>
        ///     "filters": {"user_id": "alice"},<br/>
        ///     "top_k": 10<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesSearchV3Response> MemoriesSearchV3Async(

            global::Mem0.MemoriesSearchV3Request request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search memories (V3)<br/>
        /// Relevance-ranked search across stored memories. V3 uses hybrid retrieval — the returned `score` is a combined `[0, 1]` value; per-signal component scores are not exposed on the response. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. At least one entity ID is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.mem0.ai/v3/memories/search/ \<br/>
        ///   -H "Authorization: Token &lt;api-key&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "query": "where does the user live?",<br/>
        ///     "filters": {"user_id": "alice"},<br/>
        ///     "top_k": 10<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.MemoriesSearchV3Response>> MemoriesSearchV3AsResponseAsync(

            global::Mem0.MemoriesSearchV3Request request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search memories (V3)<br/>
        /// Relevance-ranked search across stored memories. V3 uses hybrid retrieval — the returned `score` is a combined `[0, 1]` value; per-signal component scores are not exposed on the response. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. At least one entity ID is required.
        /// </summary>
        /// <param name="query">
        /// Natural-language search query.
        /// </param>
        /// <param name="filters">
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`). Supports `AND`, `OR`, `NOT`, and comparison operators (`in`, `gte`, `lte`, `gt`, `lt`, `contains`, `icontains`, `ne`).
        /// </param>
        /// <param name="topK">
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="threshold">
        /// Minimum semantic relevance score. Pass `0.0` to disable filtering.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="rerank">
        /// Apply the managed reranker for better ordering (adds latency).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesSearchV3Response> MemoriesSearchV3Async(
            string query,
            object filters,
            int? topK = default,
            double? threshold = default,
            bool? rerank = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}