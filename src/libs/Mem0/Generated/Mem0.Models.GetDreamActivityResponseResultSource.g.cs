
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamActivityResponseResultSource
    {
        /// <summary>
        /// Source memory ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Source memory text (truncated).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResultSource" /> class.
        /// </summary>
        /// <param name="id">
        /// Source memory ID.
        /// </param>
        /// <param name="text">
        /// Source memory text (truncated).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamActivityResponseResultSource(
            string? id,
            string? text)
        {
            this.Id = id;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamActivityResponseResultSource" /> class.
        /// </summary>
        public GetDreamActivityResponseResultSource()
        {
        }

    }
}