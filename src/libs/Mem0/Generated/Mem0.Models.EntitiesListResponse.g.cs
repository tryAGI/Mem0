
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EntitiesListResponse
    {
        /// <summary>
        /// Total number of entities matching the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// URL of the next page of results, or null if this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// URL of the previous page of results, or null if this is the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mem0.EntitiesListResponseResult> Results { get; set; }

        /// <summary>
        /// Total number of user entities in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_users")]
        public int? TotalUsers { get; set; }

        /// <summary>
        /// Total number of agent entities in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_agents")]
        public int? TotalAgents { get; set; }

        /// <summary>
        /// Total number of app entities in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_apps")]
        public int? TotalApps { get; set; }

        /// <summary>
        /// Total number of run entities in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_runs")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesListResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of entities matching the filters.
        /// </param>
        /// <param name="results"></param>
        /// <param name="next">
        /// URL of the next page of results, or null if this is the last page.
        /// </param>
        /// <param name="previous">
        /// URL of the previous page of results, or null if this is the first page.
        /// </param>
        /// <param name="totalUsers">
        /// Total number of user entities in the project.
        /// </param>
        /// <param name="totalAgents">
        /// Total number of agent entities in the project.
        /// </param>
        /// <param name="totalApps">
        /// Total number of app entities in the project.
        /// </param>
        /// <param name="totalRuns">
        /// Total number of run entities in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesListResponse(
            int count,
            global::System.Collections.Generic.IList<global::Mem0.EntitiesListResponseResult> results,
            string? next,
            string? previous,
            int? totalUsers,
            int? totalAgents,
            int? totalApps,
            int? totalRuns)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TotalUsers = totalUsers;
            this.TotalAgents = totalAgents;
            this.TotalApps = totalApps;
            this.TotalRuns = totalRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesListResponse" /> class.
        /// </summary>
        public EntitiesListResponse()
        {
        }

    }
}