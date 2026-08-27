
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EventReadResponse2
    {
        /// <summary>
        /// Example: Event not found or you don't have permission to access it.
        /// </summary>
        /// <example>Event not found or you don't have permission to access it.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventReadResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Event not found or you don't have permission to access it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventReadResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventReadResponse2" /> class.
        /// </summary>
        public EventReadResponse2()
        {
        }

    }
}