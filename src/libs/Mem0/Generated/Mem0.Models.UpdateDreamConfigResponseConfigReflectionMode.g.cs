
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Synthesis execution mode.
    /// </summary>
    public enum UpdateDreamConfigResponseConfigReflectionMode
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
    public static class UpdateDreamConfigResponseConfigReflectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDreamConfigResponseConfigReflectionMode value)
        {
            return value switch
            {
                UpdateDreamConfigResponseConfigReflectionMode.Batch => "batch",
                UpdateDreamConfigResponseConfigReflectionMode.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDreamConfigResponseConfigReflectionMode? ToEnum(string value)
        {
            return value switch
            {
                "batch" => UpdateDreamConfigResponseConfigReflectionMode.Batch,
                "direct" => UpdateDreamConfigResponseConfigReflectionMode.Direct,
                _ => null,
            };
        }
    }
}