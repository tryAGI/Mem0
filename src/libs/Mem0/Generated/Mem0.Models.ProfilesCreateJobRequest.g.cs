
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesCreateJobRequest
    {
        /// <summary>
        /// What to generate. Optional only when `entity_id` is set, which means `trigger`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.ProfilesCreateJobRequestOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mem0.ProfilesCreateJobRequestOperation Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.ProfilesCreateJobRequestEntityTypeJsonConverter))]
        public global::Mem0.ProfilesCreateJobRequestEntityType EntityType { get; set; }

        /// <summary>
        /// One entity, for `trigger`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// How many entities to sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesCreateJobRequest" /> class.
        /// </summary>
        /// <param name="operation">
        /// What to generate. Optional only when `entity_id` is set, which means `trigger`.
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="entityId">
        /// One entity, for `trigger`.
        /// </param>
        /// <param name="limit">
        /// How many entities to sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesCreateJobRequest(
            global::Mem0.ProfilesCreateJobRequestOperation operation,
            global::Mem0.ProfilesCreateJobRequestEntityType entityType,
            string? entityId,
            int? limit)
        {
            this.Operation = operation;
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesCreateJobRequest" /> class.
        /// </summary>
        public ProfilesCreateJobRequest()
        {
        }

    }
}