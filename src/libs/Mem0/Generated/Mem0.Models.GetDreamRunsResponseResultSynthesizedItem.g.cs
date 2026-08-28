
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamRunsResponseResultSynthesizedItem
    {
        /// <summary>
        /// Synthesized memory ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Synthesized (pattern) memory text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Source memories this pattern was distilled from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunsResponseResultSynthesizedItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Synthesized memory ID.
        /// </param>
        /// <param name="text">
        /// Synthesized (pattern) memory text.
        /// </param>
        /// <param name="sources">
        /// Source memories this pattern was distilled from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamRunsResponseResultSynthesizedItem(
            string? id,
            string? text,
            global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>? sources)
        {
            this.Id = id;
            this.Text = text;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunsResponseResultSynthesizedItem" /> class.
        /// </summary>
        public GetDreamRunsResponseResultSynthesizedItem()
        {
        }

    }
}