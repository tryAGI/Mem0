
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamConfigResponseEntitlements
    {
        /// <summary>
        /// Resolved billing tier for the project (e.g. `free`, `pro`, `custom`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// How often synthesis runs for this plan, in days (Pro weekly, Enterprise daily).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reflection_interval_days")]
        public int? ReflectionIntervalDays { get; set; }

        /// <summary>
        /// Per-feature entitlement snapshot, keyed by Dream feature (e.g. `dream_reflection`, `dream_tab`, `dream_preview`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.Dictionary<string, global::Mem0.GetDreamConfigResponseEntitlementsFeatures2>? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamConfigResponseEntitlements" /> class.
        /// </summary>
        /// <param name="plan">
        /// Resolved billing tier for the project (e.g. `free`, `pro`, `custom`).
        /// </param>
        /// <param name="reflectionIntervalDays">
        /// How often synthesis runs for this plan, in days (Pro weekly, Enterprise daily).
        /// </param>
        /// <param name="features">
        /// Per-feature entitlement snapshot, keyed by Dream feature (e.g. `dream_reflection`, `dream_tab`, `dream_preview`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamConfigResponseEntitlements(
            string? plan,
            int? reflectionIntervalDays,
            global::System.Collections.Generic.Dictionary<string, global::Mem0.GetDreamConfigResponseEntitlementsFeatures2>? features)
        {
            this.Plan = plan;
            this.ReflectionIntervalDays = reflectionIntervalDays;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamConfigResponseEntitlements" /> class.
        /// </summary>
        public GetDreamConfigResponseEntitlements()
        {
        }

    }
}