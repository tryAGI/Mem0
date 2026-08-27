
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Per-signal breakdown of the relevance score.
    /// </summary>
    public sealed partial class MemoriesSearchV3ResponseResultScoreBreakdown
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantic")]
        public double? Semantic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        public double? Bm25 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public double? Entity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3ResponseResultScoreBreakdown" /> class.
        /// </summary>
        /// <param name="semantic"></param>
        /// <param name="bm25"></param>
        /// <param name="entity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchV3ResponseResultScoreBreakdown(
            double? semantic,
            double? bm25,
            double? entity)
        {
            this.Semantic = semantic;
            this.Bm25 = bm25;
            this.Entity = entity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3ResponseResultScoreBreakdown" /> class.
        /// </summary>
        public MemoriesSearchV3ResponseResultScoreBreakdown()
        {
        }

    }
}