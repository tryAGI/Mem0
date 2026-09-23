
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesCreateJobRequestEntityType
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesCreateJobRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesCreateJobRequestEntityType value)
        {
            return value switch
            {
                ProfilesCreateJobRequestEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesCreateJobRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ProfilesCreateJobRequestEntityType.User,
                _ => null,
            };
        }
    }
}