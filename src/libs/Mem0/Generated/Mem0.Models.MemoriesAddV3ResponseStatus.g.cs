
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoriesAddV3ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
    public static class MemoriesAddV3ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesAddV3ResponseStatus value)
        {
            return value switch
            {
                MemoriesAddV3ResponseStatus.Failed => "FAILED",
                MemoriesAddV3ResponseStatus.Pending => "PENDING",
                MemoriesAddV3ResponseStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesAddV3ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => MemoriesAddV3ResponseStatus.Failed,
                "PENDING" => MemoriesAddV3ResponseStatus.Pending,
                "SUCCEEDED" => MemoriesAddV3ResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}