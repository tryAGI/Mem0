
#nullable enable

namespace Mem0
{
    /// <summary>
    /// The newer memory that replaced this one (null for a merge with no single replacement).
    /// </summary>
    public sealed partial class GetDreamActivityResponseResultReplacedBy
    {
        /// <summary>
        /// ID of the newer memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Text of the newer memory (truncated).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResultReplacedBy" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the newer memory.
        /// </param>
        /// <param name="text">
        /// Text of the newer memory (truncated).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamActivityResponseResultReplacedBy(
            string? id,
            string? text)
        {
            this.Id = id;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResultReplacedBy" /> class.
        /// </summary>
        public GetDreamActivityResponseResultReplacedBy()
        {
        }

    }
}