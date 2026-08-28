
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDreamMemorySourcesResponseSource
    {
        /// <summary>
        /// Source memory ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Source memory text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Source memory lifecycle state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.GetDreamMemorySourcesResponseSourceLifecycleStateJsonConverter))]
        public global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState? LifecycleState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamMemorySourcesResponseSource" /> class.
        /// </summary>
        /// <param name="id">
        /// Source memory ID.
        /// </param>
        /// <param name="text">
        /// Source memory text.
        /// </param>
        /// <param name="lifecycleState">
        /// Source memory lifecycle state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDreamMemorySourcesResponseSource(
            string? id,
            string? text,
            global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState? lifecycleState)
        {
            this.Id = id;
            this.Text = text;
            this.LifecycleState = lifecycleState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDreamMemorySourcesResponseSource" /> class.
        /// </summary>
        public GetDreamMemorySourcesResponseSource()
        {
        }

    }
}