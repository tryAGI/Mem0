
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Settings for user profiles, under `user`.
    /// </summary>
    public sealed partial class ProfilesSettingsReadResponseEntities
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Mem0.ProfilesSettingsReadResponseEntitiesUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsReadResponseEntities" /> class.
        /// </summary>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsReadResponseEntities(
            global::Mem0.ProfilesSettingsReadResponseEntitiesUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsReadResponseEntities" /> class.
        /// </summary>
        public ProfilesSettingsReadResponseEntities()
        {
        }

    }
}