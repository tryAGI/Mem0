
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Only the fields present are written. `schema` and `custom_instructions` nest under `entities.user`; a flat body is rejected.
    /// </summary>
    public sealed partial class ProfilesSettingsUpdateRequest
    {
        /// <summary>
        /// Whether profile generation runs for this project. Project-wide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Settings for user profiles, under `user`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::Mem0.ProfilesSettingsUpdateRequestEntities? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether profile generation runs for this project. Project-wide.
        /// </param>
        /// <param name="entities">
        /// Settings for user profiles, under `user`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsUpdateRequest(
            bool? enabled,
            global::Mem0.ProfilesSettingsUpdateRequestEntities? entities)
        {
            this.Enabled = enabled;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequest" /> class.
        /// </summary>
        public ProfilesSettingsUpdateRequest()
        {
        }

    }
}