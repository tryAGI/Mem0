
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesAddV3Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.MemoriesAddV3ResponseStatusJsonConverter))]
        public global::Mem0.MemoriesAddV3ResponseStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="MemoriesAddV3Response" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesAddV3Response(
            string? message,
            global::Mem0.MemoriesAddV3ResponseStatus? status,
            global::System.Guid? eventId)
        {
            this.Message = message;
            this.Status = status;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3Response" /> class.
        /// </summary>
        public MemoriesAddV3Response()
        {
        }
    }
}