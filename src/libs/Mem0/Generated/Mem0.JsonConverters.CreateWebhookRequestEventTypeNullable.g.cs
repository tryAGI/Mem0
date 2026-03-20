#nullable enable

namespace Mem0.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWebhookRequestEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mem0.CreateWebhookRequestEventType?>
    {
        /// <inheritdoc />
        public override global::Mem0.CreateWebhookRequestEventType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Mem0.CreateWebhookRequestEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mem0.CreateWebhookRequestEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mem0.CreateWebhookRequestEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mem0.CreateWebhookRequestEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mem0.CreateWebhookRequestEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
