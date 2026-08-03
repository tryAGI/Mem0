
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoriesEntityReadEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesEntityReadEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesEntityReadEntityType value)
        {
            return value switch
            {
                MemoriesEntityReadEntityType.Agent => "agent",
                MemoriesEntityReadEntityType.App => "app",
                MemoriesEntityReadEntityType.Run => "run",
                MemoriesEntityReadEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesEntityReadEntityType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => MemoriesEntityReadEntityType.Agent,
                "app" => MemoriesEntityReadEntityType.App,
                "run" => MemoriesEntityReadEntityType.Run,
                "user" => MemoriesEntityReadEntityType.User,
                _ => null,
            };
        }
    }
}