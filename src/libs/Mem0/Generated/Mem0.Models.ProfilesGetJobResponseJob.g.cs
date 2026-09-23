
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesGetJobResponseJob
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mem0.JsonConverters.ProfilesGetJobResponseJobStatusJsonConverter))]
        public global::Mem0.ProfilesGetJobResponseJobStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enumeration_complete")]
        public bool? EnumerationComplete { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public int? Completed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        public int? Succeeded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public int? Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesGetJobResponseJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="operation"></param>
        /// <param name="entityType"></param>
        /// <param name="status"></param>
        /// <param name="total"></param>
        /// <param name="enumerationComplete"></param>
        /// <param name="completed"></param>
        /// <param name="succeeded"></param>
        /// <param name="failed"></param>
        /// <param name="skipped"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesGetJobResponseJob(
            string? id,
            string? operation,
            string? entityType,
            global::Mem0.ProfilesGetJobResponseJobStatus? status,
            int? total,
            bool? enumerationComplete,
            int? completed,
            int? succeeded,
            int? failed,
            int? skipped)
        {
            this.Id = id;
            this.Operation = operation;
            this.EntityType = entityType;
            this.Status = status;
            this.Total = total;
            this.EnumerationComplete = enumerationComplete;
            this.Completed = completed;
            this.Succeeded = succeeded;
            this.Failed = failed;
            this.Skipped = skipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesGetJobResponseJob" /> class.
        /// </summary>
        public ProfilesGetJobResponseJob()
        {
        }

    }
}