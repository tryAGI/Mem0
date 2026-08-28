
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamRunMemoriesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResult>? Results { get; set; }

        /// <summary>
        /// Cursor for the next page, or null when there are no more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunMemoriesResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null when there are no more.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamRunMemoriesResponse(
            global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResult>? results,
            string? nextCursor)
        {
            this.Results = results;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamRunMemoriesResponse" /> class.
        /// </summary>
        public GetDreamRunMemoriesResponse()
        {
        }

    }
}