
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSettingsUpdateResponseCapabilities
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public bool? Jobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimates")]
        public bool? Estimates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public bool? Samples { get; set; }

        /// <summary>
        /// Whether a project-wide rebuild (regenerate/backfill) is available. Currently false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_rebuild")]
        public bool? FullRebuild { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateResponseCapabilities" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        /// <param name="estimates"></param>
        /// <param name="samples"></param>
        /// <param name="fullRebuild">
        /// Whether a project-wide rebuild (regenerate/backfill) is available. Currently false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesSettingsUpdateResponseCapabilities(
            bool? jobs,
            bool? estimates,
            bool? samples,
            bool? fullRebuild)
        {
            this.Jobs = jobs;
            this.Estimates = estimates;
            this.Samples = samples;
            this.FullRebuild = fullRebuild;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesSettingsUpdateResponseCapabilities" /> class.
        /// </summary>
        public ProfilesSettingsUpdateResponseCapabilities()
        {
        }

    }
}