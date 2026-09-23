
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSettingsUpdateRequestEntitiesUser
    {
        /// <summary>
        /// JSON Schema describing the profile. Every property needs a description. Send null to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Extra guidance for the extraction step. Send null to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequestEntitiesUser" /> class.
        /// </summary>
        /// <param name="schema">
        /// JSON Schema describing the profile. Every property needs a description. Send null to clear it.
        /// </param>
        /// <param name="customInstructions">
        /// Extra guidance for the extraction step. Send null to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsUpdateRequestEntitiesUser(
            object? schema,
            string? customInstructions)
        {
            this.Schema = schema;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateRequestEntitiesUser" /> class.
        /// </summary>
        public ProfilesSettingsUpdateRequestEntitiesUser()
        {
        }

    }
}