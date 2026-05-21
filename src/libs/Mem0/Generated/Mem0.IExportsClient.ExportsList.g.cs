#nullable enable

namespace Mem0
{
    public partial interface IExportsClient
    {
        /// <summary>
        /// Export data based on filters<br/>
        /// Get the latest memory export.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportsListAsync(

            global::Mem0.ExportsListRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export data based on filters<br/>
        /// Get the latest memory export.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<string>> ExportsListAsResponseAsync(

            global::Mem0.ExportsListRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export data based on filters<br/>
        /// Get the latest memory export.
        /// </summary>
        /// <param name="memoryExportId">
        /// The unique identifier of the memory export.
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at.
        /// </param>
        /// <param name="orgId">
        /// Filter exports by organization ID.
        /// </param>
        /// <param name="projectId">
        /// Filter exports by project ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportsListAsync(
            string? memoryExportId = default,
            global::Mem0.ExportsListRequestFilters? filters = default,
            string? orgId = default,
            string? projectId = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}