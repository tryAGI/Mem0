
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesEntityReadResponse3
    {
        /// <summary>
        /// Example: Invalid page.
        /// </summary>
        /// <example>Invalid page.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponse3" /> class.
        /// </summary>
        /// <param name="detail">
        /// Example: Invalid page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesEntityReadResponse3(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesEntityReadResponse3" /> class.
        /// </summary>
        public MemoriesEntityReadResponse3()
        {
        }

    }
}