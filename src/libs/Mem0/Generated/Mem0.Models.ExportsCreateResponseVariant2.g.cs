
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Returned when filters are missing or not in the required structured AND/OR format.
    /// </summary>
    public sealed partial class ExportsCreateResponseVariant2
    {
        /// <summary>
        /// Example: One of the filters: app_id, user_id, agent_id, run_id, memory_export_id is required!
        /// </summary>
        /// <example>One of the filters: app_id, user_id, agent_id, run_id, memory_export_id is required!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponseVariant2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: One of the filters: app_id, user_id, agent_id, run_id, memory_export_id is required!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportsCreateResponseVariant2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponseVariant2" /> class.
        /// </summary>
        public ExportsCreateResponseVariant2()
        {
        }

    }
}