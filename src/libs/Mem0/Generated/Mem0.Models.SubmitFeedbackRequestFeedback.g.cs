
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Type of feedback
    /// </summary>
    public enum SubmitFeedbackRequestFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        Positive,
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        VeryNegative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitFeedbackRequestFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitFeedbackRequestFeedback value)
        {
            return value switch
            {
                SubmitFeedbackRequestFeedback.Positive => "POSITIVE",
                SubmitFeedbackRequestFeedback.Negative => "NEGATIVE",
                SubmitFeedbackRequestFeedback.VeryNegative => "VERY_NEGATIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitFeedbackRequestFeedback? ToEnum(string value)
        {
            return value switch
            {
                "POSITIVE" => SubmitFeedbackRequestFeedback.Positive,
                "NEGATIVE" => SubmitFeedbackRequestFeedback.Negative,
                "VERY_NEGATIVE" => SubmitFeedbackRequestFeedback.VeryNegative,
                _ => null,
            };
        }
    }
}