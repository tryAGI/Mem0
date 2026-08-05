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
        ///       {"role": "assistant", "content": "Got it, I\u0027ll update your location."}<br/>
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
        ///       {"role": "assistant", "content": "Got it, I\u0027ll update your location."}<br/>
        ///     ],<br/>
        ///     "user_id": "alice"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.MemoriesAddV3Response>> MemoriesAddV3AsResponseAsync(

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
        /// <param name="expirationDate">
        /// Optional expiration date in YYYY-MM-DD format. After this date, memories are hidden from search and get-all unless `show_expired` is true.
        /// </param>
        /// <param name="customInstructions">
        /// Project-level instructions that guide extraction for this call.
        /// </param>
        /// <param name="agentCustomInstructions">
        /// Extraction instructions for agent-scoped memories, overriding the project-level setting for this call. Applied when `agent_id` is sent without `user_id`; when both are sent it governs the assistant-attributed memories while `custom_instructions` governs the rest.
        /// </param>
        /// <param name="customCategories">
        /// Category catalog for this call. Replaces the project-level list rather than merging with it. Omit to fall back to the project list, then the default catalog.
        /// </param>
        /// <param name="infer">
        /// When `false`, stores each message verbatim without running the extraction LLM.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="appId">
        /// Scope memories to this app.
        /// </param>
        /// <param name="immutable">
        /// Mark stored memories as immutable, excluding them from future update/consolidation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includes">
        /// Free-text hint of what to include during extraction, e.g. "vehicles".
        /// </param>
        /// <param name="excludes">
        /// Free-text hint of what to exclude during extraction, e.g. "politics".
        /// </param>
        /// <param name="enableGraph">
        /// Enable graph memory extraction for this call.
        /// </param>
        /// <param name="structuredDataSchema">
        /// Optional schema constraining structured extraction. Exact shape not fully characterized; observed only as null in captured traffic.
        /// </param>
        /// <param name="outputFormat">
        /// Response envelope version, e.g. "v1.1". Full set of accepted values not confirmed.
        /// </param>
        /// <param name="promptProfileId">
        /// ID of a saved prompt profile to use for extraction.
        /// </param>
        /// <param name="temporalReasoning">
        /// Enable temporal reasoning during extraction.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone used to interpret observation_datetime and observation_date, e.g. "UTC".
        /// </param>
        /// <param name="observationDatetime">
        /// ISO 8601 datetime the conversation was observed.
        /// </param>
        /// <param name="observationDate">
        /// Date the conversation was observed (YYYY-MM-DD).
        /// </param>
        /// <param name="timestamp">
        /// Unix epoch seconds used to backdate created_at on the stored memories. Not echoed back in the event payload but confirmed applied.
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
            global::System.DateTime? expirationDate = default,
            string? customInstructions = default,
            string? agentCustomInstructions = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? customCategories = default,
            bool? infer = default,
            string? appId = default,
            bool? immutable = default,
            string? includes = default,
            string? excludes = default,
            bool? enableGraph = default,
            object? structuredDataSchema = default,
            string? outputFormat = default,
            string? promptProfileId = default,
            bool? temporalReasoning = default,
            string? timezone = default,
            global::System.DateTime? observationDatetime = default,
            global::System.DateTime? observationDate = default,
            int? timestamp = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}