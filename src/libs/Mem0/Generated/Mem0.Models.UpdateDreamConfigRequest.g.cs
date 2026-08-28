
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDreamConfigRequest
    {
        /// <summary>
        /// Turn background synthesis on or off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_enabled")]
        public bool? ReflectionEnabled { get; set; }

        /// <summary>
        /// Synthesis execution mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.UpdateDreamConfigRequestReflectionModeJsonConverter))]
        public global::Mem0.UpdateDreamConfigRequestReflectionMode? ReflectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigRequest" /> class.
        /// </summary>
        /// <param name="reflectionEnabled">
        /// Turn background synthesis on or off.
        /// </param>
        /// <param name="reflectionMode">
        /// Synthesis execution mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDreamConfigRequest(
            bool? reflectionEnabled,
            global::Mem0.UpdateDreamConfigRequestReflectionMode? reflectionMode)
        {
            this.ReflectionEnabled = reflectionEnabled;
            this.ReflectionMode = reflectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigRequest" /> class.
        /// </summary>
        public UpdateDreamConfigRequest()
        {
        }

    }
}