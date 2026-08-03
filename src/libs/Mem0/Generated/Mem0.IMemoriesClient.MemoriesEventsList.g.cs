#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Despite the endpoint name, this returns memory history entries (the same shape as `GET /v1/memories/{memory_id}/history/`), not event/ingestion-job records. For event/ingestion-job status, use `GET /v1/event/{event_id}/`.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesEventsListResponse> MemoriesEventsListAsync(
            int? page = default,
            int? limit = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Despite the endpoint name, this returns memory history entries (the same shape as `GET /v1/memories/{memory_id}/history/`), not event/ingestion-job records. For event/ingestion-job status, use `GET /v1/event/{event_id}/`.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.MemoriesEventsListResponse>> MemoriesEventsListAsResponseAsync(
            int? page = default,
            int? limit = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}