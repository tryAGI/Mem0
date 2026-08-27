
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MemoriesListV3ResponseResult
    {
        /// <summary>
        /// Unique memory identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The extracted memory fact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// User the memory is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Agent the memory is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// App the memory is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Run/session the memory is scoped to. Note: this endpoint returns this field as `session_id`, while `POST /v3/memories/search/` returns the same value as `run_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// User-supplied metadata attached to the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

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
        /// Date after which the memory is hidden from search and get-all unless `show_expired` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3ResponseResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique memory identifier.
        /// </param>
        /// <param name="memory">
        /// The extracted memory fact.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="userId">
        /// User the memory is scoped to.
        /// </param>
        /// <param name="agentId">
        /// Agent the memory is scoped to.
        /// </param>
        /// <param name="appId">
        /// App the memory is scoped to.
        /// </param>
        /// <param name="sessionId">
        /// Run/session the memory is scoped to. Note: this endpoint returns this field as `session_id`, while `POST /v3/memories/search/` returns the same value as `run_id`.
        /// </param>
        /// <param name="metadata">
        /// User-supplied metadata attached to the memory.
        /// </param>
        /// <param name="categories"></param>
        /// <param name="structuredAttributes">
        /// System-derived temporal breakdown of the memory's creation time (e.g. year, month, day_of_week).
        /// </param>
        /// <param name="replacedBy">
        /// ID of the memory that superseded this one, if any.
        /// </param>
        /// <param name="synthesized">
        /// Whether this memory was synthesized rather than directly extracted.
        /// </param>
        /// <param name="expirationDate">
        /// Date after which the memory is hidden from search and get-all unless `show_expired` is true.
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesListV3ResponseResult(
            global::System.Guid id,
            string memory,
            global::System.DateTime createdAt,
            string? userId,
            string? agentId,
            string? appId,
            string? sessionId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            object? structuredAttributes,
            string? replacedBy,
            bool? synthesized,
            global::System.DateTime? expirationDate,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.SessionId = sessionId;
            this.Metadata = metadata;
            this.Categories = categories;
            this.StructuredAttributes = structuredAttributes;
            this.ReplacedBy = replacedBy;
            this.Synthesized = synthesized;
            this.ExpirationDate = expirationDate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3ResponseResult" /> class.
        /// </summary>
        public MemoriesListV3ResponseResult()
        {
        }

    }
}