
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MemoriesEntityReadResponseResult
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
        ///
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
        /// The conversation input that produced this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResultInputItem>? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_updated")]
        public bool? IsUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponseResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memory"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="metadata"></param>
        /// <param name="categories"></param>
        /// <param name="input">
        /// The conversation input that produced this memory.
        /// </param>
        /// <param name="isUpdated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesEntityReadResponseResult(
            string id,
            string memory,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResultInputItem>? input,
            bool? isUpdated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.Metadata = metadata;
            this.Categories = categories;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Input = input;
            this.IsUpdated = isUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponseResult" /> class.
        /// </summary>
        public MemoriesEntityReadResponseResult()
        {
        }

    }
}