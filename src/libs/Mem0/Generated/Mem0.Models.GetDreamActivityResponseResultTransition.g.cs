
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Lifecycle transition.
    /// </summary>
    public enum GetDreamActivityResponseResultTransition
    {
        /// <summary>
        ///
        /// </summary>
        Merged,
        /// <summary>
        ///
        /// </summary>
        Superseded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDreamActivityResponseResultTransitionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDreamActivityResponseResultTransition value)
        {
            return value switch
            {
                GetDreamActivityResponseResultTransition.Merged => "merged",
                GetDreamActivityResponseResultTransition.Superseded => "superseded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDreamActivityResponseResultTransition? ToEnum(string value)
        {
            return value switch
            {
                "merged" => GetDreamActivityResponseResultTransition.Merged,
                "superseded" => GetDreamActivityResponseResultTransition.Superseded,
                _ => null,
            };
        }
    }
}