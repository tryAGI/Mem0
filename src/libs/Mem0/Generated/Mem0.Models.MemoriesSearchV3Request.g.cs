
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesSearchV3Request
    {
        /// <summary>
        /// Natural-language search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`). Supports `AND`, `OR`, `NOT`, and comparison operators (`in`, `gte`, `lte`, `gt`, `lt`, `contains`, `icontains`, `ne`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filters { get; set; }

        /// <summary>
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Minimum semantic relevance score. Pass `0.0` to disable filtering.<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Apply the managed reranker for better ordering (adds latency).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3Request" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language search query.
        /// </param>
        /// <param name="filters">
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`). Supports `AND`, `OR`, `NOT`, and comparison operators (`in`, `gte`, `lte`, `gt`, `lt`, `contains`, `icontains`, `ne`).
        /// </param>
        /// <param name="topK">
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="threshold">
        /// Minimum semantic relevance score. Pass `0.0` to disable filtering.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="rerank">
        /// Apply the managed reranker for better ordering (adds latency).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchV3Request(
            string query,
            object filters,
            int? topK,
            double? threshold,
            bool? rerank)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.TopK = topK;
            this.Threshold = threshold;
            this.Rerank = rerank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3Request" /> class.
        /// </summary>
        public MemoriesSearchV3Request()
        {
        }
    }
}