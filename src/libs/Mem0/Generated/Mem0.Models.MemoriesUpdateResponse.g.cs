
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MemoriesUpdateResponse
    {
        /// <summary>
        /// The unique identifier of the updated memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The updated content of the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public string? Memory { get; set; }

        /// <summary>
        /// Identifier of the user associated with this memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The identifier of the agent associated with this memory, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The identifier of the app associated with this memory, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// The run identifier associated with this memory, returned as `session_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Timestamp of when the memory was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the memory was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date when the memory will expire. Format: YYYY-MM-DD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// System-derived temporal breakdown of the memory's creation time (e.g. year, month, day_of_week).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_attributes")]
        public object? StructuredAttributes { get; set; }

        /// <summary>
        /// ID of the memory that superseded this one, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// Whether this memory was synthesized rather than directly extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesized")]
        public bool? Synthesized { get; set; }

        /// <summary>
        /// Lifecycle state of the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle_state")]
        public string? LifecycleState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the updated memory.
        /// </param>
        /// <param name="memory">
        /// The updated content of the memory.
        /// </param>
        /// <param name="userId">
        /// Identifier of the user associated with this memory
        /// </param>
        /// <param name="agentId">
        /// The identifier of the agent associated with this memory, if any.
        /// </param>
        /// <param name="appId">
        /// The identifier of the app associated with this memory, if any.
        /// </param>
        /// <param name="sessionId">
        /// The run identifier associated with this memory, returned as `session_id`.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        /// <param name="categories"></param>
        /// <param name="createdAt">
        /// Timestamp of when the memory was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the memory was last updated.
        /// </param>
        /// <param name="expirationDate">
        /// The date when the memory will expire. Format: YYYY-MM-DD.
        /// </param>
        /// <param name="structuredAttributes">
        /// System-derived temporal breakdown of the memory's creation time (e.g. year, month, day_of_week).
        /// </param>
        /// <param name="replacedBy">
        /// ID of the memory that superseded this one, if any.
        /// </param>
        /// <param name="synthesized">
        /// Whether this memory was synthesized rather than directly extracted.
        /// </param>
        /// <param name="lifecycleState">
        /// Lifecycle state of the memory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesUpdateResponse(
            global::System.Guid? id,
            string? memory,
            string? userId,
            string? agentId,
            string? appId,
            string? sessionId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? expirationDate,
            object? structuredAttributes,
            string? replacedBy,
            bool? synthesized,
            string? lifecycleState)
        {
            this.Id = id;
            this.Memory = memory;
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.SessionId = sessionId;
            this.Metadata = metadata;
            this.Categories = categories;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExpirationDate = expirationDate;
            this.StructuredAttributes = structuredAttributes;
            this.ReplacedBy = replacedBy;
            this.Synthesized = synthesized;
            this.LifecycleState = lifecycleState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateResponse" /> class.
        /// </summary>
        public MemoriesUpdateResponse()
        {
        }

    }
}