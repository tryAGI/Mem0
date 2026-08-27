
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PingReadResponse2
    {
        /// <summary>
        /// Example: Invalid API key. You can find your API key on https://app.mem0.ai/dashboard/api-keys.
        /// </summary>
        /// <example>Invalid API key. You can find your API key on https://app.mem0.ai/dashboard/api-keys.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PingReadResponse2" /> class.
        /// </summary>
        /// <param name="detail">
        /// Example: Invalid API key. You can find your API key on https://app.mem0.ai/dashboard/api-keys.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PingReadResponse2(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingReadResponse2" /> class.
        /// </summary>
        public PingReadResponse2()
        {
        }

    }
}