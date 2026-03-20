
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoriesCreateResponseItemEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesCreateResponseItemEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesCreateResponseItemEvent value)
        {
            return value switch
            {
                MemoriesCreateResponseItemEvent.Add => "ADD",
                MemoriesCreateResponseItemEvent.Update => "UPDATE",
                MemoriesCreateResponseItemEvent.Delete => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesCreateResponseItemEvent? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => MemoriesCreateResponseItemEvent.Add,
                "UPDATE" => MemoriesCreateResponseItemEvent.Update,
                "DELETE" => MemoriesCreateResponseItemEvent.Delete,
                _ => null,
            };
        }
    }
}