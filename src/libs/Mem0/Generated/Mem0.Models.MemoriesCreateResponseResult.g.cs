
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesCreateResponseResult
    {
        /// <summary>
        /// Example: Memory processing has been queued for background execution
        /// </summary>
        /// <example>Memory processing has been queued for background execution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Example: PENDING
        /// </summary>
        /// <example>PENDING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseResult" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Memory processing has been queued for background execution
        /// </param>
        /// <param name="status">
        /// Example: PENDING
        /// </param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesCreateResponseResult(
            string message,
            string status,
            global::System.Guid eventId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseResult" /> class.
        /// </summary>
        public MemoriesCreateResponseResult()
        {
        }

    }
}