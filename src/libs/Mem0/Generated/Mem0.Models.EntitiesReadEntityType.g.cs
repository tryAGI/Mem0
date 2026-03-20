
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitiesReadEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntitiesReadEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesReadEntityType value)
        {
            return value switch
            {
                EntitiesReadEntityType.User => "user",
                EntitiesReadEntityType.Agent => "agent",
                EntitiesReadEntityType.App => "app",
                EntitiesReadEntityType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesReadEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => EntitiesReadEntityType.User,
                "agent" => EntitiesReadEntityType.Agent,
                "app" => EntitiesReadEntityType.App,
                "run" => EntitiesReadEntityType.Run,
                _ => null,
            };
        }
    }
}