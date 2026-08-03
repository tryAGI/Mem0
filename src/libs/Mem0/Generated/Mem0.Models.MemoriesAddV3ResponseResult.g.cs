
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesAddV3ResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Mem0.MemoriesAddV3ResponseResultData? Data { get; set; }

        /// <summary>
        /// Example: ADD
        /// </summary>
        /// <example>ADD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3ResponseResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="event">
        /// Example: ADD
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesAddV3ResponseResult(
            global::System.Guid? id,
            global::Mem0.MemoriesAddV3ResponseResultData? data,
            string? @event)
        {
            this.Id = id;
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesAddV3ResponseResult" /> class.
        /// </summary>
        public MemoriesAddV3ResponseResult()
        {
        }

    }
}