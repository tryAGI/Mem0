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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.GetProjectWebhooksResponseItem>> GetProjectWebhooksAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}