
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesEntityReadResponse2
    {
        /// <summary>
        /// Example: Invalid entity type
        /// </summary>
        /// <example>Invalid entity type</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Invalid entity type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesEntityReadResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponse2" /> class.
        /// </summary>
        public MemoriesEntityReadResponse2()
        {
        }

    }
}