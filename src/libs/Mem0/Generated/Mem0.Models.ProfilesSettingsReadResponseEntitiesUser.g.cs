
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSettingsReadResponseEntitiesUser
    {
        /// <summary>
        /// JSON Schema describing the profile. Every property needs a description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Extra guidance for the extraction step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsReadResponseEntitiesUser" /> class.
        /// </summary>
        /// <param name="schema">
        /// JSON Schema describing the profile. Every property needs a description.
        /// </param>
        /// <param name="customInstructions">
        /// Extra guidance for the extraction step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsReadResponseEntitiesUser(
            object? schema,
            string? customInstructions)
        {
            this.Schema = schema;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsReadResponseEntitiesUser" /> class.
        /// </summary>
        public ProfilesSettingsReadResponseEntitiesUser()
        {
        }

    }
}