
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamActivityResponseResult
    {
        /// <summary>
        /// The superseded/merged memory's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        public string? MemoryId { get; set; }

        /// <summary>
        /// The memory's text (truncated).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Lifecycle transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.GetDreamActivityResponseResultTransitionJsonConverter))]
        public global::Mem0.GetDreamActivityResponseResultTransition? Transition { get; set; }

        /// <summary>
        /// When the transition happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        public global::System.DateTime? At { get; set; }

        /// <summary>
        /// The newer memory that replaced this one (null for a merge with no single replacement).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_by")]
        public global::Mem0.GetDreamActivityResponseResultReplacedBy? ReplacedBy { get; set; }

        /// <summary>
        /// Always null on this feed; synthesis provenance is shown on the runs feed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResultSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResult" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The superseded/merged memory's ID.
        /// </param>
        /// <param name="text">
        /// The memory's text (truncated).
        /// </param>
        /// <param name="transition">
        /// Lifecycle transition.
        /// </param>
        /// <param name="at">
        /// When the transition happened.
        /// </param>
        /// <param name="replacedBy">
        /// The newer memory that replaced this one (null for a merge with no single replacement).
        /// </param>
        /// <param name="sources">
        /// Always null on this feed; synthesis provenance is shown on the runs feed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamActivityResponseResult(
            string? memoryId,
            string? text,
            global::Mem0.GetDreamActivityResponseResultTransition? transition,
            global::System.DateTime? at,
            global::Mem0.GetDreamActivityResponseResultReplacedBy? replacedBy,
            global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResultSource>? sources)
        {
            this.MemoryId = memoryId;
            this.Text = text;
            this.Transition = transition;
            this.At = at;
            this.ReplacedBy = replacedBy;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResult" /> class.
        /// </summary>
        public GetDreamActivityResponseResult()
        {
        }

    }
}