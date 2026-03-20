
#nullable enable

namespace Mem0
{
    /// <summary>
    /// The current status of the event.
    /// </summary>
    public enum EventReadResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventReadResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventReadResponseStatus value)
        {
            return value switch
            {
                EventReadResponseStatus.Pending => "PENDING",
                EventReadResponseStatus.Running => "RUNNING",
                EventReadResponseStatus.Failed => "FAILED",
                EventReadResponseStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventReadResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => EventReadResponseStatus.Pending,
                "RUNNING" => EventReadResponseStatus.Running,
                "FAILED" => EventReadResponseStatus.Failed,
                "SUCCEEDED" => EventReadResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}