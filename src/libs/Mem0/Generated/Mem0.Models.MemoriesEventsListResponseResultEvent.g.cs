
#nullable enable

namespace Mem0
{
    /// <summary>
    /// The type of event that occurred
    /// </summary>
    public enum MemoriesEventsListResponseResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesEventsListResponseResultEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesEventsListResponseResultEvent value)
        {
            return value switch
            {
                MemoriesEventsListResponseResultEvent.Add => "ADD",
                MemoriesEventsListResponseResultEvent.Delete => "DELETE",
                MemoriesEventsListResponseResultEvent.Update => "UPDATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesEventsListResponseResultEvent? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => MemoriesEventsListResponseResultEvent.Add,
                "DELETE" => MemoriesEventsListResponseResultEvent.Delete,
                "UPDATE" => MemoriesEventsListResponseResultEvent.Update,
                _ => null,
            };
        }
    }
}