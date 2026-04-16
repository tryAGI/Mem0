
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesListV3Response
    {
        /// <summary>
        /// Total number of memories matching the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// URL for the next page, or `null` if this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// URL for the previous page, or `null` if this is the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mem0.MemoriesListV3ResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3Response" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of memories matching the filters.
        /// </param>
        /// <param name="results"></param>
        /// <param name="next">
        /// URL for the next page, or `null` if this is the last page.
        /// </param>
        /// <param name="previous">
        /// URL for the previous page, or `null` if this is the first page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesListV3Response(
            int count,
            global::System.Collections.Generic.IList<global::Mem0.MemoriesListV3ResponseResult> results,
            string? next,
            string? previous)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3Response" /> class.
        /// </summary>
        public MemoriesListV3Response()
        {
        }
    }
}