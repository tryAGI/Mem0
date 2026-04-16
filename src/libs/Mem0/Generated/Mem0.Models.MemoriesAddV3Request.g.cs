
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesAddV3Request
    {
        /// <summary>
        /// Conversation messages to extract memories from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage> Messages { get; set; }

        /// <summary>
        /// Scope memories to this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Scope memories to this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Scope memories to this session / run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// User-supplied metadata to attach to each extracted memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Project-level instructions that guide extraction for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// When `false`, stores each message verbatim without running the extraction LLM.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infer")]
        public bool? Infer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesAddV3Request(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage> messages,
            string? userId,
            string? agentId,
            string? runId,
            object? metadata,
            string? customInstructions,
            bool? infer)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.UserId = userId;
            this.AgentId = agentId;
            this.RunId = runId;
            this.Metadata = metadata;
            this.CustomInstructions = customInstructions;
            this.Infer = infer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3Request" /> class.
        /// </summary>
        public MemoriesAddV3Request()
        {
        }
    }
}