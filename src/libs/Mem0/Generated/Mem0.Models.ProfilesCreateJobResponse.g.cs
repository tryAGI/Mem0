
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesCreateJobResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Poll this. Building the path yourself breaks on a route change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_url")]
        public string? StatusUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// Entities reserved against usage for this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_count_reserved")]
        public int? EntityCountReserved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// True when an Idempotency-Key returned an existing job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replayed")]
        public bool? Replayed { get; set; }

        /// <summary>
        /// `sample` only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampled")]
        public int? Sampled { get; set; }

        /// <summary>
        /// `sample` only: the entity ids picked. Read each with `GET /v2/entities/user/{entity_id}/profile/`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_ids")]
        public global::System.Collections.Generic.IList<string>? EntityIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesCreateJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="statusUrl">
        /// Poll this. Building the path yourself breaks on a route change.
        /// </param>
        /// <param name="operation"></param>
        /// <param name="entityType"></param>
        /// <param name="entityCountReserved">
        /// Entities reserved against usage for this job.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="replayed">
        /// True when an Idempotency-Key returned an existing job.
        /// </param>
        /// <param name="sampled">
        /// `sample` only.
        /// </param>
        /// <param name="entityIds">
        /// `sample` only: the entity ids picked. Read each with `GET /v2/entities/user/{entity_id}/profile/`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesCreateJobResponse(
            string? jobId,
            string? status,
            string? statusUrl,
            string? operation,
            string? entityType,
            int? entityCountReserved,
            string? eventId,
            bool? replayed,
            int? sampled,
            global::System.Collections.Generic.IList<string>? entityIds)
        {
            this.JobId = jobId;
            this.Status = status;
            this.StatusUrl = statusUrl;
            this.Operation = operation;
            this.EntityType = entityType;
            this.EntityCountReserved = entityCountReserved;
            this.EventId = eventId;
            this.Replayed = replayed;
            this.Sampled = sampled;
            this.EntityIds = entityIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesCreateJobResponse" /> class.
        /// </summary>
        public ProfilesCreateJobResponse()
        {
        }

    }
}