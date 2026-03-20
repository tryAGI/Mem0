
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebhookRequestEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Memory_add,
        /// <summary>
        /// 
        /// </summary>
        Memory_update,
        /// <summary>
        /// 
        /// </summary>
        Memory_delete,
        /// <summary>
        /// 
        /// </summary>
        Memory_categorize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookRequestEventType value)
        {
            return value switch
            {
                CreateWebhookRequestEventType.Memory_add => "memory:add",
                CreateWebhookRequestEventType.Memory_update => "memory:update",
                CreateWebhookRequestEventType.Memory_delete => "memory:delete",
                CreateWebhookRequestEventType.Memory_categorize => "memory:categorize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "memory:add" => CreateWebhookRequestEventType.Memory_add,
                "memory:update" => CreateWebhookRequestEventType.Memory_update,
                "memory:delete" => CreateWebhookRequestEventType.Memory_delete,
                "memory:categorize" => CreateWebhookRequestEventType.Memory_categorize,
                _ => null,
            };
        }
    }
}