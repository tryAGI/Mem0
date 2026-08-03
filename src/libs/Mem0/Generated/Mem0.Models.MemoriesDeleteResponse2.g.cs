
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesDeleteResponse2
    {
        /// <summary>
        /// Example: memory_id should be a valid UUID
        /// </summary>
        /// <example>memory_id should be a valid UUID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: memory_id should be a valid UUID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesDeleteResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse2" /> class.
        /// </summary>
        public MemoriesDeleteResponse2()
        {
        }

    }
}