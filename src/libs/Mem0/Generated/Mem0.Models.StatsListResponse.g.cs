
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StatsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_memories")]
        public int? TotalMemories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_retrieval_events")]
        public int? TotalRetrievalEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_add_events")]
        public int? TotalAddEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_api_retrieval_events")]
        public int? TotalApiRetrievalEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_retrieval_events_limit")]
        public int? TotalRetrievalEventsLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_users_with_memories")]
        public int? TotalUsersWithMemories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_agents_with_memories")]
        public int? TotalAgentsWithMemories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_runs_with_memories")]
        public int? TotalRunsWithMemories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories_per_user")]
        public int? MemoriesPerUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories_per_agent")]
        public int? MemoriesPerAgent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories_per_run")]
        public int? MemoriesPerRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatsListResponse" /> class.
        /// </summary>
        /// <param name="totalMemories"></param>
        /// <param name="totalRetrievalEvents"></param>
        /// <param name="totalAddEvents"></param>
        /// <param name="totalApiRetrievalEvents"></param>
        /// <param name="totalRetrievalEventsLimit"></param>
        /// <param name="totalUsersWithMemories"></param>
        /// <param name="totalAgentsWithMemories"></param>
        /// <param name="totalRunsWithMemories"></param>
        /// <param name="memoriesPerUser"></param>
        /// <param name="memoriesPerAgent"></param>
        /// <param name="memoriesPerRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatsListResponse(
            int? totalMemories,
            int? totalRetrievalEvents,
            int? totalAddEvents,
            int? totalApiRetrievalEvents,
            int? totalRetrievalEventsLimit,
            int? totalUsersWithMemories,
            int? totalAgentsWithMemories,
            int? totalRunsWithMemories,
            int? memoriesPerUser,
            int? memoriesPerAgent,
            int? memoriesPerRun)
        {
            this.TotalMemories = totalMemories;
            this.TotalRetrievalEvents = totalRetrievalEvents;
            this.TotalAddEvents = totalAddEvents;
            this.TotalApiRetrievalEvents = totalApiRetrievalEvents;
            this.TotalRetrievalEventsLimit = totalRetrievalEventsLimit;
            this.TotalUsersWithMemories = totalUsersWithMemories;
            this.TotalAgentsWithMemories = totalAgentsWithMemories;
            this.TotalRunsWithMemories = totalRunsWithMemories;
            this.MemoriesPerUser = memoriesPerUser;
            this.MemoriesPerAgent = memoriesPerAgent;
            this.MemoriesPerRun = memoriesPerRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatsListResponse" /> class.
        /// </summary>
        public StatsListResponse()
        {
        }

    }
}