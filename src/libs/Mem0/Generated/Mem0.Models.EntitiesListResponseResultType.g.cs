
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum EntitiesListResponseResultType
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
    public static class EntitiesListResponseResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesListResponseResultType value)
        {
            return value switch
            {
                EntitiesListResponseResultType.Agent => "agent",
                EntitiesListResponseResultType.App => "app",
                EntitiesListResponseResultType.Run => "run",
                EntitiesListResponseResultType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesListResponseResultType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntitiesListResponseResultType.Agent,
                "app" => EntitiesListResponseResultType.App,
                "run" => EntitiesListResponseResultType.Run,
                "user" => EntitiesListResponseResultType.User,
                _ => null,
            };
        }
    }
}