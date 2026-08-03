
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Returned when the schema is missing or invalid.
    /// </summary>
    public sealed partial class ExportsCreateResponseVariant1
    {
        /// <summary>
        /// Example: Schema is required and must be a valid object
        /// </summary>
        /// <example>Schema is required and must be a valid object</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponseVariant1" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Schema is required and must be a valid object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportsCreateResponseVariant1(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponseVariant1" /> class.
        /// </summary>
        public ExportsCreateResponseVariant1()
        {
        }

    }
}