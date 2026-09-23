
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetJobResponseJobStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        PartiallySucceeded,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesGetJobResponseJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetJobResponseJobStatus value)
        {
            return value switch
            {
                ProfilesGetJobResponseJobStatus.Cancelled => "CANCELLED",
                ProfilesGetJobResponseJobStatus.Failed => "FAILED",
                ProfilesGetJobResponseJobStatus.PartiallySucceeded => "PARTIALLY_SUCCEEDED",
                ProfilesGetJobResponseJobStatus.Queued => "QUEUED",
                ProfilesGetJobResponseJobStatus.Running => "RUNNING",
                ProfilesGetJobResponseJobStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetJobResponseJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ProfilesGetJobResponseJobStatus.Cancelled,
                "FAILED" => ProfilesGetJobResponseJobStatus.Failed,
                "PARTIALLY_SUCCEEDED" => ProfilesGetJobResponseJobStatus.PartiallySucceeded,
                "QUEUED" => ProfilesGetJobResponseJobStatus.Queued,
                "RUNNING" => ProfilesGetJobResponseJobStatus.Running,
                "SUCCEEDED" => ProfilesGetJobResponseJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}