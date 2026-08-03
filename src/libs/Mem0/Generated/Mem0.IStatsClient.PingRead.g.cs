#nullable enable

namespace Mem0
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Check API key validity and resolve organization/project context.<br/>
        /// Both the Python and TypeScript SDKs call this endpoint on client construction to validate the API key and resolve the default `org_id` and `project_id`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.PingReadResponse> PingReadAsync(
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check API key validity and resolve organization/project context.<br/>
        /// Both the Python and TypeScript SDKs call this endpoint on client construction to validate the API key and resolve the default `org_id` and `project_id`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.PingReadResponse>> PingReadAsResponseAsync(
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}