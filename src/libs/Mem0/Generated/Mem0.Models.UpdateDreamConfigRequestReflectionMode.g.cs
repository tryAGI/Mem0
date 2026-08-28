
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Synthesis execution mode.
    /// </summary>
    public enum UpdateDreamConfigRequestReflectionMode
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDreamConfigRequestReflectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDreamConfigRequestReflectionMode value)
        {
            return value switch
            {
                UpdateDreamConfigRequestReflectionMode.Batch => "batch",
                UpdateDreamConfigRequestReflectionMode.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDreamConfigRequestReflectionMode? ToEnum(string value)
        {
            return value switch
            {
                "batch" => UpdateDreamConfigRequestReflectionMode.Batch,
                "direct" => UpdateDreamConfigRequestReflectionMode.Direct,
                _ => null,
            };
        }
    }
}