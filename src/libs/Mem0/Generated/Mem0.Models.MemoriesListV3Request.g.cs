
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesListV3Request
    {
        /// <summary>
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`).
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
        /// Only include memories created on or after this date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Only include memories created on or before this date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Restrict results to memories tagged with any of these categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Restrict the fields returned per memory, e.g. ["id", "memory"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Free-text keyword filter applied on top of filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// 1-indexed page number. Also accepted here in the request body; the query parameter of the same name takes precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Results per page. Also accepted here in the request body; the query parameter of the same name takes precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3Request" /> class.
        /// </summary>
        /// <param name="filters">
        /// Entity and metadata filters. Must include at least one entity ID (`user_id`, `agent_id`, `app_id`, or `run_id`).
        /// </param>
        /// <param name="showExpired">
        /// When true, include memories whose `expiration_date` has passed. Expired memories are hidden by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startDate">
        /// Only include memories created on or after this date (YYYY-MM-DD).
        /// </param>
        /// <param name="endDate">
        /// Only include memories created on or before this date (YYYY-MM-DD).
        /// </param>
        /// <param name="categories">
        /// Restrict results to memories tagged with any of these categories.
        /// </param>
        /// <param name="fields">
        /// Restrict the fields returned per memory, e.g. ["id", "memory"].
        /// </param>
        /// <param name="keywords">
        /// Free-text keyword filter applied on top of filters.
        /// </param>
        /// <param name="page">
        /// 1-indexed page number. Also accepted here in the request body; the query parameter of the same name takes precedence.
        /// </param>
        /// <param name="pageSize">
        /// Results per page. Also accepted here in the request body; the query parameter of the same name takes precedence.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesListV3Request(
            object filters,
            bool? showExpired,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.Collections.Generic.IList<string>? fields,
            string? keywords,
            int? page,
            int? pageSize)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.ShowExpired = showExpired;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Categories = categories;
            this.Fields = fields;
            this.Keywords = keywords;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3Request" /> class.
        /// </summary>
        public MemoriesListV3Request()
        {
        }

    }
}