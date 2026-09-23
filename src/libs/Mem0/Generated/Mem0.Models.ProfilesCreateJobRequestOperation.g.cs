
#nullable enable

namespace Mem0
{
    /// <summary>
    /// What to generate. Optional only when `entity_id` is set, which means `trigger`.
    /// </summary>
    public enum ProfilesCreateJobRequestOperation
    {
        /// <summary>
        ///
        /// </summary>
        Sample,
        /// <summary>
        ///
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesCreateJobRequestOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesCreateJobRequestOperation value)
        {
            return value switch
            {
                ProfilesCreateJobRequestOperation.Sample => "sample",
                ProfilesCreateJobRequestOperation.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesCreateJobRequestOperation? ToEnum(string value)
        {
            return value switch
            {
                "sample" => ProfilesCreateJobRequestOperation.Sample,
                "trigger" => ProfilesCreateJobRequestOperation.Trigger,
                _ => null,
            };
        }
    }
}