
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Returned when `output_format=v1.1` is requested.
    /// </summary>
    public sealed partial class MemoriesSearchCreateResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Relations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchCreateResponse2" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="relations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchCreateResponse2(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseResult> results,
            global::System.Collections.Generic.IList<object> relations)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Relations = relations ?? throw new global::System.ArgumentNullException(nameof(relations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchCreateResponse2" /> class.
        /// </summary>
        public MemoriesSearchCreateResponse2()
        {
        }

    }
}