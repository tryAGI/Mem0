
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWebhookRequestEventType
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
    public static class UpdateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookRequestEventType value)
        {
            return value switch
            {
                UpdateWebhookRequestEventType.Memory_add => "memory:add",
                UpdateWebhookRequestEventType.Memory_update => "memory:update",
                UpdateWebhookRequestEventType.Memory_delete => "memory:delete",
                UpdateWebhookRequestEventType.Memory_categorize => "memory:categorize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "memory:add" => UpdateWebhookRequestEventType.Memory_add,
                "memory:update" => UpdateWebhookRequestEventType.Memory_update,
                "memory:delete" => UpdateWebhookRequestEventType.Memory_delete,
                "memory:categorize" => UpdateWebhookRequestEventType.Memory_categorize,
                _ => null,
            };
        }
    }
}