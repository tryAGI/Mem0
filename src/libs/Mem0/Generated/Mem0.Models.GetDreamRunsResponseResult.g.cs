
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamRunsResponseResult
    {
        /// <summary>
        /// Identifier of the synthesis run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// When the run produced memories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        public global::System.DateTime? At { get; set; }

        /// <summary>
        /// Total synthesized memories in this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// First page of synthesized memories (each with its sources).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesized")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>? Synthesized { get; set; }

        /// <summary>
        /// Whether the run has more memories than are inlined here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Cursor to page this run's remaining memories via the run-memories endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mem_cursor")]
        public string? MemCursor { get; set; }

        /// <summary>
        /// De-duplicated source memories across the inlined page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunsResponseResult" /> class.
        /// </summary>
        /// <param name="runId">
        /// Identifier of the synthesis run.
        /// </param>
        /// <param name="at">
        /// When the run produced memories.
        /// </param>
        /// <param name="count">
        /// Total synthesized memories in this run.
        /// </param>
        /// <param name="synthesized">
        /// First page of synthesized memories (each with its sources).
        /// </param>
        /// <param name="hasMore">
        /// Whether the run has more memories than are inlined here.
        /// </param>
        /// <param name="memCursor">
        /// Cursor to page this run's remaining memories via the run-memories endpoint.
        /// </param>
        /// <param name="sources">
        /// De-duplicated source memories across the inlined page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamRunsResponseResult(
            string? runId,
            global::System.DateTime? at,
            int? count,
            global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>? synthesized,
            bool? hasMore,
            string? memCursor,
            global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSource>? sources)
        {
            this.RunId = runId;
            this.At = at;
            this.Count = count;
            this.Synthesized = synthesized;
            this.HasMore = hasMore;
            this.MemCursor = memCursor;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunsResponseResult" /> class.
        /// </summary>
        public GetDreamRunsResponseResult()
        {
        }

    }
}