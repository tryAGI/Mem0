
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesReadResponse
    {
        /// <summary>
        /// The generated profile, shaped by the project's schema. Empty unless status is succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public object? Profile { get; set; }

        /// <summary>
        /// Generation state. Branch on this rather than on an empty profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.ProfilesReadResponseStatusJsonConverter))]
        public global::Mem0.ProfilesReadResponseStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.ProfilesReadResponseEntityTypeJsonConverter))]
        public global::Mem0.ProfilesReadResponseEntityType? EntityType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_count")]
        public int? GenerationCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesReadResponse" /> class.
        /// </summary>
        /// <param name="profile">
        /// The generated profile, shaped by the project's schema. Empty unless status is succeeded.
        /// </param>
        /// <param name="status">
        /// Generation state. Branch on this rather than on an empty profile.
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="generationCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesReadResponse(
            object? profile,
            global::Mem0.ProfilesReadResponseStatus? status,
            global::Mem0.ProfilesReadResponseEntityType? entityType,
            string? entityId,
            global::System.DateTime? updatedAt,
            int? generationCount)
        {
            this.Profile = profile;
            this.Status = status;
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.UpdatedAt = updatedAt;
            this.GenerationCount = generationCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesReadResponse" /> class.
        /// </summary>
        public ProfilesReadResponse()
        {
        }

    }
}