
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Filters to apply while exporting memories, using the structured AND/OR filter format (see `/v2/memories/search/`), e.g. `{"AND": [{"user_id": "&lt;user_id&gt;"}]}`. Available fields are: user_id, agent_id, app_id, run_id. Flat filter objects (e.g. `{"user_id": "&lt;user_id&gt;"}`) are rejected with a 400 error.
    /// </summary>
    public sealed partial class ExportsCreateRequestFilters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}