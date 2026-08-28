
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamMemorySourcesResponse
    {
        /// <summary>
        /// The memory's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        public string? MemoryId { get; set; }

        /// <summary>
        /// Whether this memory was produced by synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesized")]
        public bool? Synthesized { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamMemorySourcesResponseSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamMemorySourcesResponse" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The memory's ID.
        /// </param>
        /// <param name="synthesized">
        /// Whether this memory was produced by synthesis.
        /// </param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamMemorySourcesResponse(
            string? memoryId,
            bool? synthesized,
            global::System.Collections.Generic.IList<global::Mem0.GetDreamMemorySourcesResponseSource>? sources)
        {
            this.MemoryId = memoryId;
            this.Synthesized = synthesized;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamMemorySourcesResponse" /> class.
        /// </summary>
        public GetDreamMemorySourcesResponse()
        {
        }

    }
}