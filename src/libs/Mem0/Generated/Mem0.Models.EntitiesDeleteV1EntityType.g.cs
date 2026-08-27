
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum EntitiesDeleteV1EntityType
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
    public static class EntitiesDeleteV1EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesDeleteV1EntityType value)
        {
            return value switch
            {
                EntitiesDeleteV1EntityType.Agent => "agent",
                EntitiesDeleteV1EntityType.App => "app",
                EntitiesDeleteV1EntityType.Run => "run",
                EntitiesDeleteV1EntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesDeleteV1EntityType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntitiesDeleteV1EntityType.Agent,
                "app" => EntitiesDeleteV1EntityType.App,
                "run" => EntitiesDeleteV1EntityType.Run,
                "user" => EntitiesDeleteV1EntityType.User,
                _ => null,
            };
        }
    }
}