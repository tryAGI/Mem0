
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamConfigResponseEntitlementsFeatures2
    {
        /// <summary>
        /// Whether the plan is entitled to the feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitled")]
        public bool? Entitled { get; set; }

        /// <summary>
        /// Whether the feature is globally disabled by a kill switch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("killed")]
        public bool? Killed { get; set; }

        /// <summary>
        /// Effective state: entitled AND not killed AND turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamConfigResponseEntitlementsFeatures2" /> class.
        /// </summary>
        /// <param name="entitled">
        /// Whether the plan is entitled to the feature.
        /// </param>
        /// <param name="killed">
        /// Whether the feature is globally disabled by a kill switch.
        /// </param>
        /// <param name="enabled">
        /// Effective state: entitled AND not killed AND turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamConfigResponseEntitlementsFeatures2(
            bool? entitled,
            bool? killed,
            bool? enabled)
        {
            this.Entitled = entitled;
            this.Killed = killed;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamConfigResponseEntitlementsFeatures2" /> class.
        /// </summary>
        public GetDreamConfigResponseEntitlementsFeatures2()
        {
        }

    }
}