
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesSearchV3Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV3ResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3Response" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchV3Response(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV3ResponseResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3Response" /> class.
        /// </summary>
        public MemoriesSearchV3Response()
        {
        }
    }
}