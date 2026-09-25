
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Settings for user profiles, under `user`.
    /// </summary>
    public sealed partial class ProfilesSettingsUpdateRequestEntities
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Mem0.ProfilesSettingsUpdateRequestEntitiesUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequestEntities" /> class.
        /// </summary>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsUpdateRequestEntities(
            global::Mem0.ProfilesSettingsUpdateRequestEntitiesUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequestEntities" /> class.
        /// </summary>
        public ProfilesSettingsUpdateRequestEntities()
        {
        }

    }
}