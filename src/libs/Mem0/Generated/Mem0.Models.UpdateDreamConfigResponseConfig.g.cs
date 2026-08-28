
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDreamConfigResponseConfig
    {
        /// <summary>
        /// Whether background synthesis (reflection) is enabled for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_enabled")]
        public bool? ReflectionEnabled { get; set; }

        /// <summary>
        /// When synthesis was last enabled. Synthesis only considers memories created on or after this time (forward-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_enabled_at")]
        public global::System.DateTime? ReflectionEnabledAt { get; set; }

        /// <summary>
        /// Synthesis execution mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.UpdateDreamConfigResponseConfigReflectionModeJsonConverter))]
        public global::Mem0.UpdateDreamConfigResponseConfigReflectionMode? ReflectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigResponseConfig" /> class.
        /// </summary>
        /// <param name="reflectionEnabled">
        /// Whether background synthesis (reflection) is enabled for the project.
        /// </param>
        /// <param name="reflectionEnabledAt">
        /// When synthesis was last enabled. Synthesis only considers memories created on or after this time (forward-only).
        /// </param>
        /// <param name="reflectionMode">
        /// Synthesis execution mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDreamConfigResponseConfig(
            bool? reflectionEnabled,
            global::System.DateTime? reflectionEnabledAt,
            global::Mem0.UpdateDreamConfigResponseConfigReflectionMode? reflectionMode)
        {
            this.ReflectionEnabled = reflectionEnabled;
            this.ReflectionEnabledAt = reflectionEnabledAt;
            this.ReflectionMode = reflectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigResponseConfig" /> class.
        /// </summary>
        public UpdateDreamConfigResponseConfig()
        {
        }

    }
}