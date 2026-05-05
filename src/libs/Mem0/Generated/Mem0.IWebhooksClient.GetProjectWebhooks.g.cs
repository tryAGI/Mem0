#nullable enable

namespace Mem0
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get Project Webhooks<br/>
        /// Retrieve all webhooks for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.GetProjectWebhooksResponseItem>> GetProjectWebhooksAsync(
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project Webhooks<br/>
        /// Retrieve all webhooks for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Mem0.GetProjectWebhooksResponseItem>>> GetProjectWebhooksAsResponseAsync(
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}