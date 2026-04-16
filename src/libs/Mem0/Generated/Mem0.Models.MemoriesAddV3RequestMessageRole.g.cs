
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoriesAddV3RequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesAddV3RequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesAddV3RequestMessageRole value)
        {
            return value switch
            {
                MemoriesAddV3RequestMessageRole.Assistant => "assistant",
                MemoriesAddV3RequestMessageRole.System => "system",
                MemoriesAddV3RequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesAddV3RequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MemoriesAddV3RequestMessageRole.Assistant,
                "system" => MemoriesAddV3RequestMessageRole.System,
                "user" => MemoriesAddV3RequestMessageRole.User,
                _ => null,
            };
        }
    }
}