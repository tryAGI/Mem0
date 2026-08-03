
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsCreateRequest
    {
        /// <summary>
        /// Schema definition for the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Filters to apply while exporting memories, using the structured AND/OR filter format (see `/v2/memories/search/`), e.g. `{"AND": [{"user_id": "&lt;user_id&gt;"}]}`. Available fields are: user_id, agent_id, app_id, run_id. Flat filter objects (e.g. `{"user_id": "&lt;user_id&gt;"}`) are rejected with a 400 error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// Filter exports by organization ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Filter exports by project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequest" /> class.
        /// </summary>
        /// <param name="schema">
        /// Schema definition for the export
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories, using the structured AND/OR filter format (see `/v2/memories/search/`), e.g. `{"AND": [{"user_id": "&lt;user_id&gt;"}]}`. Available fields are: user_id, agent_id, app_id, run_id. Flat filter objects (e.g. `{"user_id": "&lt;user_id&gt;"}`) are rejected with a 400 error.
        /// </param>
        /// <param name="orgId">
        /// Filter exports by organization ID.
        /// </param>
        /// <param name="projectId">
        /// Filter exports by project ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportsCreateRequest(
            object schema,
            object? filters,
            string? orgId,
            string? projectId)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Filters = filters;
            this.OrgId = orgId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequest" /> class.
        /// </summary>
        public ExportsCreateRequest()
        {
        }

    }
}