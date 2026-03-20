
#nullable enable

namespace Mem0
{
    /// <summary>
    /// The role of the speaker in the conversation
    /// </summary>
    public enum MemoriesHistoryListResponseItemInputItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesHistoryListResponseItemInputItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesHistoryListResponseItemInputItemRole value)
        {
            return value switch
            {
                MemoriesHistoryListResponseItemInputItemRole.User => "user",
                MemoriesHistoryListResponseItemInputItemRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesHistoryListResponseItemInputItemRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => MemoriesHistoryListResponseItemInputItemRole.User,
                "assistant" => MemoriesHistoryListResponseItemInputItemRole.Assistant,
                _ => null,
            };
        }
    }
}