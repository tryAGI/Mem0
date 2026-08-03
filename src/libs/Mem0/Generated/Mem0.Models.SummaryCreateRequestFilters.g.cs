
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Either flat field:value pairs (e.g. `{"user_id": "&lt;user_id&gt;"}`) or the structured AND/OR filter format used by `/v2/memories/search/`.
    /// </summary>
    public sealed partial class SummaryCreateRequestFilters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}