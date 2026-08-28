
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DreamPreviewResponse
    {
        /// <summary>
        /// Total active memories in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_total")]
        public int? ActiveTotal { get; set; }

        /// <summary>
        /// How many recent memories the preview aggregated over (capped).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanned")]
        public int? Scanned { get; set; }

        /// <summary>
        /// The scan cap applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cap")]
        public int? Cap { get; set; }

        /// <summary>
        /// Users with enough memories to benefit from synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eligible_users")]
        public int? EligibleUsers { get; set; }

        /// <summary>
        /// Human-readable note about the preview scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamPreviewResponse" /> class.
        /// </summary>
        /// <param name="activeTotal">
        /// Total active memories in the project.
        /// </param>
        /// <param name="scanned">
        /// How many recent memories the preview aggregated over (capped).
        /// </param>
        /// <param name="cap">
        /// The scan cap applied.
        /// </param>
        /// <param name="eligibleUsers">
        /// Users with enough memories to benefit from synthesis.
        /// </param>
        /// <param name="note">
        /// Human-readable note about the preview scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DreamPreviewResponse(
            int? activeTotal,
            int? scanned,
            int? cap,
            int? eligibleUsers,
            string? note)
        {
            this.ActiveTotal = activeTotal;
            this.Scanned = scanned;
            this.Cap = cap;
            this.EligibleUsers = eligibleUsers;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamPreviewResponse" /> class.
        /// </summary>
        public DreamPreviewResponse()
        {
        }

    }
}