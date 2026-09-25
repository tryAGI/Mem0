
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSettingsUpdateResponse
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
        public global::Mem0.ProfilesSettingsUpdateResponseEntities? Entities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Mem0.ProfilesSettingsUpdateResponseCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateResponse" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether profile generation runs for this project. Project-wide.
        /// </param>
        /// <param name="entities">
        /// Settings for user profiles, under `user`.
        /// </param>
        /// <param name="capabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsUpdateResponse(
            bool? enabled,
            global::Mem0.ProfilesSettingsUpdateResponseEntities? entities,
            global::Mem0.ProfilesSettingsUpdateResponseCapabilities? capabilities)
        {
            this.Enabled = enabled;
            this.Entities = entities;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateResponse" /> class.
        /// </summary>
        public ProfilesSettingsUpdateResponse()
        {
        }

    }
}