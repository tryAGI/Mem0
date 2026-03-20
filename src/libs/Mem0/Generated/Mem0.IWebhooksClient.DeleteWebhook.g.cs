#nullable enable

namespace Mem0
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete Webhook<br/>
        /// Delete an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.DeleteWebhookResponse> DeleteWebhookAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}