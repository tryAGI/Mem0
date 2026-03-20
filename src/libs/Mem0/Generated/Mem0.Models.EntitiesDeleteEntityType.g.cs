
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitiesDeleteEntityType
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
    public static class EntitiesDeleteEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesDeleteEntityType value)
        {
            return value switch
            {
                EntitiesDeleteEntityType.User => "user",
                EntitiesDeleteEntityType.Agent => "agent",
                EntitiesDeleteEntityType.App => "app",
                EntitiesDeleteEntityType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesDeleteEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => EntitiesDeleteEntityType.User,
                "agent" => EntitiesDeleteEntityType.Agent,
                "app" => EntitiesDeleteEntityType.App,
                "run" => EntitiesDeleteEntityType.Run,
                _ => null,
            };
        }
    }
}