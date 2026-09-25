
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Generation state. Branch on this rather than on an empty profile.
    /// </summary>
    public enum ProfilesReadResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InsufficientData,
        /// <summary>
        ///
        /// </summary>
        NotEnabled,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesReadResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesReadResponseStatus value)
        {
            return value switch
            {
                ProfilesReadResponseStatus.Failed => "failed",
                ProfilesReadResponseStatus.InsufficientData => "insufficient_data",
                ProfilesReadResponseStatus.NotEnabled => "not_enabled",
                ProfilesReadResponseStatus.Pending => "pending",
                ProfilesReadResponseStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesReadResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ProfilesReadResponseStatus.Failed,
                "insufficient_data" => ProfilesReadResponseStatus.InsufficientData,
                "not_enabled" => ProfilesReadResponseStatus.NotEnabled,
                "pending" => ProfilesReadResponseStatus.Pending,
                "succeeded" => ProfilesReadResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}