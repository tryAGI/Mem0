
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebhookRequestEventType
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
    public static class CreateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookRequestEventType value)
        {
            return value switch
            {
                CreateWebhookRequestEventType.IngestJobCancelled => "ingest_job_cancelled",
                CreateWebhookRequestEventType.IngestJobCompleted => "ingest_job_completed",
                CreateWebhookRequestEventType.IngestJobFailed => "ingest_job_failed",
                CreateWebhookRequestEventType.IngestJobPartiallyCompleted => "ingest_job_partially_completed",
                CreateWebhookRequestEventType.MemoryAdd => "memory_add",
                CreateWebhookRequestEventType.MemoryCategorize => "memory_categorize",
                CreateWebhookRequestEventType.MemoryDelete => "memory_delete",
                CreateWebhookRequestEventType.MemoryUpdate => "memory_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "ingest_job_cancelled" => CreateWebhookRequestEventType.IngestJobCancelled,
                "ingest_job_completed" => CreateWebhookRequestEventType.IngestJobCompleted,
                "ingest_job_failed" => CreateWebhookRequestEventType.IngestJobFailed,
                "ingest_job_partially_completed" => CreateWebhookRequestEventType.IngestJobPartiallyCompleted,
                "memory_add" => CreateWebhookRequestEventType.MemoryAdd,
                "memory_categorize" => CreateWebhookRequestEventType.MemoryCategorize,
                "memory_delete" => CreateWebhookRequestEventType.MemoryDelete,
                "memory_update" => CreateWebhookRequestEventType.MemoryUpdate,
                _ => null,
            };
        }
    }
}