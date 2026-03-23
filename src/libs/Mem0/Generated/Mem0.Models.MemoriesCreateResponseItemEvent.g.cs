
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
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
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
                MemoriesCreateResponseItemEvent.Delete => "DELETE",
                MemoriesCreateResponseItemEvent.Update => "UPDATE",
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
                "DELETE" => MemoriesCreateResponseItemEvent.Delete,
                "UPDATE" => MemoriesCreateResponseItemEvent.Update,
                _ => null,
            };
        }
    }
}