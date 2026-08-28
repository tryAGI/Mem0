
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamStatsResponse
    {
        /// <summary>
        /// Active (current) memory count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public int? Active { get; set; }

        /// <summary>
        /// Count of memories merged into a canonical one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged")]
        public int? Merged { get; set; }

        /// <summary>
        /// Count of memories superseded by a newer one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("superseded")]
        public int? Superseded { get; set; }

        /// <summary>
        /// Count of higher-order pattern memories created by synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesized")]
        public int? Synthesized { get; set; }

        /// <summary>
        /// When synthesis last completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// Timestamp of the newest source memory synthesis has processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_through")]
        public global::System.DateTime? ProcessedThrough { get; set; }

        /// <summary>
        /// Whether a synthesis run is currently in flight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        public bool? Running { get; set; }

        /// <summary>
        /// Projected next synthesis run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_run_at")]
        public global::System.DateTime? NextRunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamStatsResponse" /> class.
        /// </summary>
        /// <param name="active">
        /// Active (current) memory count.
        /// </param>
        /// <param name="merged">
        /// Count of memories merged into a canonical one.
        /// </param>
        /// <param name="superseded">
        /// Count of memories superseded by a newer one.
        /// </param>
        /// <param name="synthesized">
        /// Count of higher-order pattern memories created by synthesis.
        /// </param>
        /// <param name="lastRunAt">
        /// When synthesis last completed.
        /// </param>
        /// <param name="processedThrough">
        /// Timestamp of the newest source memory synthesis has processed.
        /// </param>
        /// <param name="running">
        /// Whether a synthesis run is currently in flight.
        /// </param>
        /// <param name="nextRunAt">
        /// Projected next synthesis run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamStatsResponse(
            int? active,
            int? merged,
            int? superseded,
            int? synthesized,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? processedThrough,
            bool? running,
            global::System.DateTime? nextRunAt)
        {
            this.Active = active;
            this.Merged = merged;
            this.Superseded = superseded;
            this.Synthesized = synthesized;
            this.LastRunAt = lastRunAt;
            this.ProcessedThrough = processedThrough;
            this.Running = running;
            this.NextRunAt = nextRunAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamStatsResponse" /> class.
        /// </summary>
        public GetDreamStatsResponse()
        {
        }

    }
}