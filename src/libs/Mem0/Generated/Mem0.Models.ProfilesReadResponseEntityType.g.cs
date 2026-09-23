
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesReadResponseEntityType
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesReadResponseEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesReadResponseEntityType value)
        {
            return value switch
            {
                ProfilesReadResponseEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesReadResponseEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ProfilesReadResponseEntityType.User,
                _ => null,
            };
        }
    }
}