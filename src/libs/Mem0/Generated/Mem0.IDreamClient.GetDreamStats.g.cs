#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Get Dream stats<br/>
        /// Lifecycle + synthesis counts for the project's Dream dashboard, plus reflection freshness. Requires a Pro or Enterprise (CUSTOM) plan.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetDreamStatsResponse> GetDreamStatsAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dream stats<br/>
        /// Lifecycle + synthesis counts for the project's Dream dashboard, plus reflection freshness. Requires a Pro or Enterprise (CUSTOM) plan.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetDreamStatsResponse>> GetDreamStatsAsResponseAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}