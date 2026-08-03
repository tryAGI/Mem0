
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Field-keyed validation errors. Each key is a request field name; the value is an array of message strings or a nested object of messages.<br/>
    /// Example: {"name":["This field is required."]}
    /// </summary>
    public sealed partial class UpdateWebhookResponse2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}