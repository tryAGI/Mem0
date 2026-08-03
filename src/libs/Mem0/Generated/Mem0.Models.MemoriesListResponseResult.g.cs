
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesListResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// ID of the user this memory belongs to, if scoped to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Initializes a new instance of the <see cref="MemoriesListResponseResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memory"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId">
        /// ID of the user this memory belongs to, if scoped to a user.
        /// </param>
        /// <param name="metadata">
        /// User-supplied metadata attached to the memory.
        /// </param>
        /// <param name="categories"></param>
        /// <param name="expirationDate">
        /// The date when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        public MemoriesListResponseResult(
            string id,
            string memory,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? userId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.DateTime? expirationDate,
            object? structuredAttributes,
            string? replacedBy,
            bool? synthesized,
            string? lifecycleState)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.UserId = userId;
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
        /// Initializes a new instance of the <see cref="MemoriesListResponseResult" /> class.
        /// </summary>
        public MemoriesListResponseResult()
        {
        }

    }
}