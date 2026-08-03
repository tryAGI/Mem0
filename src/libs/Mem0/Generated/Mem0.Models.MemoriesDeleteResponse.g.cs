
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesDeleteResponse
    {
        /// <summary>
        /// Example: Memory deleted successfully!
        /// </summary>
        /// <example>Memory deleted successfully!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Number of linked memories also deleted. Only present when `delete_linked=true` was passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascade_count")]
        public int? CascadeCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Memory deleted successfully!
        /// </param>
        /// <param name="cascadeCount">
        /// Number of linked memories also deleted. Only present when `delete_linked=true` was passed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesDeleteResponse(
            string? message,
            int? cascadeCount)
        {
            this.Message = message;
            this.CascadeCount = cascadeCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse" /> class.
        /// </summary>
        public MemoriesDeleteResponse()
        {
        }

    }
}