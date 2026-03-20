#nullable enable

namespace Mem0
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update Webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateWebhookResponse> UpdateWebhookAsync(
            string webhookId,

            global::Mem0.UpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="name">
        /// New name for the webhook
        /// </param>
        /// <param name="url">
        /// New URL endpoint for the webhook
        /// </param>
        /// <param name="eventTypes">
        /// New list of event types to subscribe to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateWebhookResponse> UpdateWebhookAsync(
            string webhookId,
            string? name = default,
            string? url = default,
            global::System.Collections.Generic.IList<global::Mem0.UpdateWebhookRequestEventType>? eventTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}