
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitiesListResponseItemType
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
    public static class EntitiesListResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesListResponseItemType value)
        {
            return value switch
            {
                EntitiesListResponseItemType.User => "user",
                EntitiesListResponseItemType.Agent => "agent",
                EntitiesListResponseItemType.App => "app",
                EntitiesListResponseItemType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesListResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "user" => EntitiesListResponseItemType.User,
                "agent" => EntitiesListResponseItemType.Agent,
                "app" => EntitiesListResponseItemType.App,
                "run" => EntitiesListResponseItemType.Run,
                _ => null,
            };
        }
    }
}