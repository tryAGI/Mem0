#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get all memories (V3, paginated)<br/>
        /// List memories scoped by filters, paginated. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. `filters` supports the same operator set as V2 search (`AND`, `OR`, `NOT`, `in`, `gte`, `lte`, etc.). Response is a paginated envelope; pass `page` and `page_size` as query parameters to step through results.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.mem0.ai/v3/memories/?page=1&amp;page_size=50' \<br/>
        ///   -H "Authorization: Token &lt;api-key&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"filters": {"user_id": "alice"}}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesListV3Response> MemoriesListV3Async(

            global::Mem0.MemoriesListV3Request request,
            int? page = default,
            int? pageSize = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all memories (V3, paginated)<br/>
        /// List memories scoped by filters, paginated. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. `filters` supports the same operator set as V2 search (`AND`, `OR`, `NOT`, `in`, `gte`, `lte`, etc.). Response is a paginated envelope; pass `page` and `page_size` as query parameters to step through results.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.mem0.ai/v3/memories/?page=1&amp;page_size=50' \<br/>
        ///   -H "Authorization: Token &lt;api-key&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"filters": {"user_id": "alice"}}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.MemoriesListV3Response>> MemoriesListV3AsResponseAsync(

            global::Mem0.MemoriesListV3Request request,
            int? page = default,
            int? pageSize = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all memories (V3, paginated)<br/>
        /// List memories scoped by filters, paginated. Entity IDs **must** be passed inside the `filters` object — top-level `user_id` / `agent_id` / `run_id` are rejected with 400. `filters` supports the same operator set as V2 search (`AND`, `OR`, `NOT`, `in`, `gte`, `lte`, etc.). Response is a paginated envelope; pass `page` and `page_size` as query parameters to step through results.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="filters">
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesListV3Response> MemoriesListV3Async(
            object filters,
            int? page = default,
            int? pageSize = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}