
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDreamConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Mem0.UpdateDreamConfigResponseConfig? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::Mem0.UpdateDreamConfigResponseEntitlements? Entitlements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigResponse" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDreamConfigResponse(
            global::Mem0.UpdateDreamConfigResponseConfig? config,
            global::Mem0.UpdateDreamConfigResponseEntitlements? entitlements)
        {
            this.Config = config;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDreamConfigResponse" /> class.
        /// </summary>
        public UpdateDreamConfigResponse()
        {
        }

    }
}