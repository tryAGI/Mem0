#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Add memories (V3)<br/>
        /// Extract and store memories from a conversation using the V3 additive pipeline. Entity IDs (`user_id` / `agent_id` / `run_id`) are accepted at the top level. At least one entity ID is required so the memory is scoped to a session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.mem0.ai/v3/memories/add/ \<br/>
        ///   -H "Authorization: Token &lt;api-key&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "I just moved to San Francisco from New York."},<br/>
        ///       {"role": "assistant", "content": "Got it — I\u0027ll update your location."}<br/>
        ///     ],<br/>
        ///     "user_id": "alice"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesAddV3Response> MemoriesAddV3Async(

            global::Mem0.MemoriesAddV3Request request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add memories (V3)<br/>
        /// Extract and store memories from a conversation using the V3 additive pipeline. Entity IDs (`user_id` / `agent_id` / `run_id`) are accepted at the top level. At least one entity ID is required so the memory is scoped to a session.
        /// </summary>
        /// <param name="messages">
        /// Conversation messages to extract memories from.
        /// </param>
        /// <param name="userId">
        /// Scope memories to this user.
        /// </param>
        /// <param name="agentId">
        /// Scope memories to this agent.
        /// </param>
        /// <param name="runId">
        /// Scope memories to this session / run.
        /// </param>
        /// <param name="metadata">
        /// User-supplied metadata to attach to each extracted memory.
        /// </param>
        /// <param name="customInstructions">
        /// Project-level instructions that guide extraction for this call.
        /// </param>
        /// <param name="infer">
        /// When `false`, stores each message verbatim without running the extraction LLM.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesAddV3Response> MemoriesAddV3Async(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage> messages,
            string? userId = default,
            string? agentId = default,
            string? runId = default,
            object? metadata = default,
            string? customInstructions = default,
            bool? infer = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}