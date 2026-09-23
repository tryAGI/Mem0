
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesReadEntityType
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesReadEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesReadEntityType value)
        {
            return value switch
            {
                ProfilesReadEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesReadEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ProfilesReadEntityType.User,
                _ => null,
            };
        }
    }
}