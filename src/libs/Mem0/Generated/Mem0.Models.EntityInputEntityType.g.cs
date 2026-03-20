
#nullable enable

namespace Mem0
{
    /// <summary>
    /// The type of the entity
    /// </summary>
    public enum EntityInputEntityType
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
        Run,
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityInputEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityInputEntityType value)
        {
            return value switch
            {
                EntityInputEntityType.User => "user",
                EntityInputEntityType.Agent => "agent",
                EntityInputEntityType.Run => "run",
                EntityInputEntityType.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityInputEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => EntityInputEntityType.User,
                "agent" => EntityInputEntityType.Agent,
                "run" => EntityInputEntityType.Run,
                "app" => EntityInputEntityType.App,
                _ => null,
            };
        }
    }
}