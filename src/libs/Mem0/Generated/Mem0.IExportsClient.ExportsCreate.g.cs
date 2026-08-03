#nullable enable

namespace Mem0
{
    public partial interface IExportsClient
    {
        /// <summary>
        /// Create an export job with schema<br/>
        /// Create a structured export of memories based on a provided schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ExportsCreateResponse> ExportsCreateAsync(

            global::Mem0.ExportsCreateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an export job with schema<br/>
        /// Create a structured export of memories based on a provided schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.ExportsCreateResponse>> ExportsCreateAsResponseAsync(

            global::Mem0.ExportsCreateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an export job with schema<br/>
        /// Create a structured export of memories based on a provided schema.
        /// </summary>
        /// <param name="schema">
        /// Schema definition for the export
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories, using the structured AND/OR filter format (see `/v2/memories/search/`), e.g. `{"AND": [{"user_id": "&lt;user_id&gt;"}]}`. Available fields are: user_id, agent_id, app_id, run_id. Flat filter objects (e.g. `{"user_id": "&lt;user_id&gt;"}`) are rejected with a 400 error.
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
        global::System.Threading.Tasks.Task<global::Mem0.ExportsCreateResponse> ExportsCreateAsync(
            object schema,
            object? filters = default,
            string? orgId = default,
            string? projectId = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}