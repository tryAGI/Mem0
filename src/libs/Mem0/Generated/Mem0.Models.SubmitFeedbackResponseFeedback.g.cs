
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Type of feedback
    /// </summary>
    public enum SubmitFeedbackResponseFeedback
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
    public static class SubmitFeedbackResponseFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitFeedbackResponseFeedback value)
        {
            return value switch
            {
                SubmitFeedbackResponseFeedback.Positive => "POSITIVE",
                SubmitFeedbackResponseFeedback.Negative => "NEGATIVE",
                SubmitFeedbackResponseFeedback.VeryNegative => "VERY_NEGATIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitFeedbackResponseFeedback? ToEnum(string value)
        {
            return value switch
            {
                "POSITIVE" => SubmitFeedbackResponseFeedback.Positive,
                "NEGATIVE" => SubmitFeedbackResponseFeedback.Negative,
                "VERY_NEGATIVE" => SubmitFeedbackResponseFeedback.VeryNegative,
                _ => null,
            };
        }
    }
}