
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Synthesis execution mode.
    /// </summary>
    public enum GetDreamConfigResponseConfigReflectionMode
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
    public static class GetDreamConfigResponseConfigReflectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDreamConfigResponseConfigReflectionMode value)
        {
            return value switch
            {
                GetDreamConfigResponseConfigReflectionMode.Batch => "batch",
                GetDreamConfigResponseConfigReflectionMode.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDreamConfigResponseConfigReflectionMode? ToEnum(string value)
        {
            return value switch
            {
                "batch" => GetDreamConfigResponseConfigReflectionMode.Batch,
                "direct" => GetDreamConfigResponseConfigReflectionMode.Direct,
                _ => null,
            };
        }
    }
}