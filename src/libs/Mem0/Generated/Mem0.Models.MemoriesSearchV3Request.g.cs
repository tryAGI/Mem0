
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
        /// When true, include memories whose `expiration_date` has passed. Expired memories are hidden by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_expired")]
        public bool? ShowExpired { get; set; }

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
        /// Optional query anchor time for relative temporal interpretation. Accepts Unix epoch, YYYY-MM-DD, or ISO datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_date")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.OneOfJsonConverter<int?, double?, string>))]
        public global::Mem0.OneOf<int?, double?, string>? ReferenceDate { get; set; }

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
        /// <param name="showExpired">
        /// When true, include memories whose `expiration_date` has passed. Expired memories are hidden by default.<br/>
        /// Default Value: false
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
        /// <param name="referenceDate">
        /// Optional query anchor time for relative temporal interpretation. Accepts Unix epoch, YYYY-MM-DD, or ISO datetime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchV3Request(
            string query,
            object filters,
            bool? showExpired,
            int? topK,
            double? threshold,
            bool? rerank,
            global::Mem0.OneOf<int?, double?, string>? referenceDate)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.ShowExpired = showExpired;
            this.TopK = topK;
            this.Threshold = threshold;
            this.Rerank = rerank;
            this.ReferenceDate = referenceDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3Request" /> class.
        /// </summary>
        public MemoriesSearchV3Request()
        {
        }

    }
}