
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
        /// Optional expiration date in YYYY-MM-DD format. After this date, memories are hidden from search and get-all unless `show_expired` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Project-level instructions that guide extraction for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Extraction instructions for agent-scoped memories, overriding the project-level setting for this call. Applied when `agent_id` is sent without `user_id`; when both are sent it governs the assistant-attributed memories while `custom_instructions` governs the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_custom_instructions")]
        public string? AgentCustomInstructions { get; set; }

        /// <summary>
        /// Category catalog for this call. Replaces the project-level list rather than merging with it. Omit to fall back to the project list, then the default catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_categories")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? CustomCategories { get; set; }

        /// <summary>
        /// When `false`, stores each message verbatim without running the extraction LLM.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infer")]
        public bool? Infer { get; set; }

        /// <summary>
        /// Scope memories to this app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Mark stored memories as immutable, excluding them from future update/consolidation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immutable")]
        public bool? Immutable { get; set; }

        /// <summary>
        /// Free-text hint of what to include during extraction, e.g. "vehicles".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        public string? Includes { get; set; }

        /// <summary>
        /// Free-text hint of what to exclude during extraction, e.g. "politics".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public string? Excludes { get; set; }

        /// <summary>
        /// Enable graph memory extraction for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_graph")]
        public bool? EnableGraph { get; set; }

        /// <summary>
        /// Optional schema constraining structured extraction. Exact shape not fully characterized; observed only as null in captured traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_data_schema")]
        public object? StructuredDataSchema { get; set; }

        /// <summary>
        /// Response envelope version, e.g. "v1.1". Full set of accepted values not confirmed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// ID of a saved prompt profile to use for extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_profile_id")]
        public string? PromptProfileId { get; set; }

        /// <summary>
        /// Enable temporal reasoning during extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporal_reasoning")]
        public bool? TemporalReasoning { get; set; }

        /// <summary>
        /// IANA timezone used to interpret observation_datetime and observation_date, e.g. "UTC".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// ISO 8601 datetime the conversation was observed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observation_datetime")]
        public global::System.DateTime? ObservationDatetime { get; set; }

        /// <summary>
        /// Date the conversation was observed (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observation_date")]
        public global::System.DateTime? ObservationDate { get; set; }

        /// <summary>
        /// Unix epoch seconds used to backdate created_at on the stored memories. Not echoed back in the event payload but confirmed applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesAddV3Request(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage> messages,
            string? userId,
            string? agentId,
            string? runId,
            object? metadata,
            global::System.DateTime? expirationDate,
            string? customInstructions,
            string? agentCustomInstructions,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? customCategories,
            bool? infer,
            string? appId,
            bool? immutable,
            string? includes,
            string? excludes,
            bool? enableGraph,
            object? structuredDataSchema,
            string? outputFormat,
            string? promptProfileId,
            bool? temporalReasoning,
            string? timezone,
            global::System.DateTime? observationDatetime,
            global::System.DateTime? observationDate,
            int? timestamp)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.UserId = userId;
            this.AgentId = agentId;
            this.RunId = runId;
            this.Metadata = metadata;
            this.ExpirationDate = expirationDate;
            this.CustomInstructions = customInstructions;
            this.AgentCustomInstructions = agentCustomInstructions;
            this.CustomCategories = customCategories;
            this.Infer = infer;
            this.AppId = appId;
            this.Immutable = immutable;
            this.Includes = includes;
            this.Excludes = excludes;
            this.EnableGraph = enableGraph;
            this.StructuredDataSchema = structuredDataSchema;
            this.OutputFormat = outputFormat;
            this.PromptProfileId = promptProfileId;
            this.TemporalReasoning = temporalReasoning;
            this.Timezone = timezone;
            this.ObservationDatetime = observationDatetime;
            this.ObservationDate = observationDate;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3Request" /> class.
        /// </summary>
        public MemoriesAddV3Request()
        {
        }

    }
}