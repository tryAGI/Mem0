
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateWebhookRequestEventType
    {
        /// <summary>
        ///
        /// </summary>
        IngestJobCancelled,
        /// <summary>
        ///
        /// </summary>
        IngestJobCompleted,
        /// <summary>
        ///
        /// </summary>
        IngestJobFailed,
        /// <summary>
        ///
        /// </summary>
        IngestJobPartiallyCompleted,
        /// <summary>
        ///
        /// </summary>
        MemoryAdd,
        /// <summary>
        ///
        /// </summary>
        MemoryCategorize,
        /// <summary>
        ///
        /// </summary>
        MemoryDelete,
        /// <summary>
        ///
        /// </summary>
        MemoryUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookRequestEventType value)
        {
            return value switch
            {
                UpdateWebhookRequestEventType.IngestJobCancelled => "ingest_job_cancelled",
                UpdateWebhookRequestEventType.IngestJobCompleted => "ingest_job_completed",
                UpdateWebhookRequestEventType.IngestJobFailed => "ingest_job_failed",
                UpdateWebhookRequestEventType.IngestJobPartiallyCompleted => "ingest_job_partially_completed",
                UpdateWebhookRequestEventType.MemoryAdd => "memory_add",
                UpdateWebhookRequestEventType.MemoryCategorize => "memory_categorize",
                UpdateWebhookRequestEventType.MemoryDelete => "memory_delete",
                UpdateWebhookRequestEventType.MemoryUpdate => "memory_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "ingest_job_cancelled" => UpdateWebhookRequestEventType.IngestJobCancelled,
                "ingest_job_completed" => UpdateWebhookRequestEventType.IngestJobCompleted,
                "ingest_job_failed" => UpdateWebhookRequestEventType.IngestJobFailed,
                "ingest_job_partially_completed" => UpdateWebhookRequestEventType.IngestJobPartiallyCompleted,
                "memory_add" => UpdateWebhookRequestEventType.MemoryAdd,
                "memory_categorize" => UpdateWebhookRequestEventType.MemoryCategorize,
                "memory_delete" => UpdateWebhookRequestEventType.MemoryDelete,
                "memory_update" => UpdateWebhookRequestEventType.MemoryUpdate,
                _ => null,
            };
        }
    }
}