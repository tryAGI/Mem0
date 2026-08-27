
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EntitiesDeleteResponse
    {
        /// <summary>
        /// Example: Delete in progress. This may take some time.
        /// </summary>
        /// <example>Delete in progress. This may take some time.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public global::System.Guid? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesDeleteResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Delete in progress. This may take some time.
        /// </param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesDeleteResponse(
            string? message,
            global::System.Guid? eventId)
        {
            this.Message = message;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesDeleteResponse" /> class.
        /// </summary>
        public EntitiesDeleteResponse()
        {
        }

    }
}