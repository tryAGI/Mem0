
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SummaryCreateRequest
    {
        /// <summary>
        /// Either flat field:value pairs (e.g. `{"user_id": "&lt;user_id&gt;"}`) or the structured AND/OR filter format used by `/v2/memories/search/`.
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
        /// Initializes a new instance of the <see cref="SummaryCreateRequest" /> class.
        /// </summary>
        /// <param name="filters">
        /// Either flat field:value pairs (e.g. `{"user_id": "&lt;user_id&gt;"}`) or the structured AND/OR filter format used by `/v2/memories/search/`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryCreateRequest(
            object filters)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryCreateRequest" /> class.
        /// </summary>
        public SummaryCreateRequest()
        {
        }

    }
}