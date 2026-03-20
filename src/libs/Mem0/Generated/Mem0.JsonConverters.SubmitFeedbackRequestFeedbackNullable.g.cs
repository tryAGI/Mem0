#nullable enable

namespace Mem0.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubmitFeedbackRequestFeedbackNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mem0.SubmitFeedbackRequestFeedback?>
    {
        /// <inheritdoc />
        public override global::Mem0.SubmitFeedbackRequestFeedback? Read(
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
                        return global::Mem0.SubmitFeedbackRequestFeedbackExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mem0.SubmitFeedbackRequestFeedback)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mem0.SubmitFeedbackRequestFeedback?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mem0.SubmitFeedbackRequestFeedback? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mem0.SubmitFeedbackRequestFeedbackExtensions.ToValueString(value.Value));
            }
        }
    }
}
