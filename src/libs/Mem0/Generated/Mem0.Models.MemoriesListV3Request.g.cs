
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesListV3Request(
            object filters)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV3Request" /> class.
        /// </summary>
        public MemoriesListV3Request()
        {
        }
    }
}