
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Source memory lifecycle state.
    /// </summary>
    public enum GetDreamMemorySourcesResponseSourceLifecycleState
    {
        /// <summary>
        ///
        /// </summary>
        Active,
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
    public static class GetDreamMemorySourcesResponseSourceLifecycleStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDreamMemorySourcesResponseSourceLifecycleState value)
        {
            return value switch
            {
                GetDreamMemorySourcesResponseSourceLifecycleState.Active => "active",
                GetDreamMemorySourcesResponseSourceLifecycleState.Merged => "merged",
                GetDreamMemorySourcesResponseSourceLifecycleState.Superseded => "superseded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDreamMemorySourcesResponseSourceLifecycleState? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetDreamMemorySourcesResponseSourceLifecycleState.Active,
                "merged" => GetDreamMemorySourcesResponseSourceLifecycleState.Merged,
                "superseded" => GetDreamMemorySourcesResponseSourceLifecycleState.Superseded,
                _ => null,
            };
        }
    }
}