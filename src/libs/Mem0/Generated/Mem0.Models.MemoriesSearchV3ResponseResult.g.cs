
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesSearchV3ResponseResult
    {
        /// <summary>
        /// Unique memory identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The extracted memory fact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// User the memory is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Combined multi-signal relevance score in [0, 1] (search responses only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Per-signal breakdown of the relevance score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_breakdown")]
        public global::Mem0.MemoriesSearchV3ResponseResultScoreBreakdown? ScoreBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Run/session the memory is scoped to. Note: this endpoint returns this field as `run_id`, while `POST /v3/memories/` returns the same value as `session_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Date after which the memory is hidden from search unless `show_expired` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// User-supplied metadata attached to the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3ResponseResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique memory identifier.
        /// </param>
        /// <param name="memory">
        /// The extracted memory fact.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="userId">
        /// User the memory is scoped to.
        /// </param>
        /// <param name="score">
        /// Combined multi-signal relevance score in [0, 1] (search responses only).
        /// </param>
        /// <param name="scoreBreakdown">
        /// Per-signal breakdown of the relevance score.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId">
        /// Run/session the memory is scoped to. Note: this endpoint returns this field as `run_id`, while `POST /v3/memories/` returns the same value as `session_id`.
        /// </param>
        /// <param name="expirationDate">
        /// Date after which the memory is hidden from search unless `show_expired` is true.
        /// </param>
        /// <param name="metadata">
        /// User-supplied metadata attached to the memory.
        /// </param>
        /// <param name="categories"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchV3ResponseResult(
            global::System.Guid id,
            string memory,
            global::System.DateTime createdAt,
            string? userId,
            float? score,
            global::Mem0.MemoriesSearchV3ResponseResultScoreBreakdown? scoreBreakdown,
            string? agentId,
            string? appId,
            string? runId,
            global::System.DateTime? expirationDate,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.UserId = userId;
            this.Score = score;
            this.ScoreBreakdown = scoreBreakdown;
            this.AgentId = agentId;
            this.AppId = appId;
            this.RunId = runId;
            this.ExpirationDate = expirationDate;
            this.Metadata = metadata;
            this.Categories = categories;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV3ResponseResult" /> class.
        /// </summary>
        public MemoriesSearchV3ResponseResult()
        {
        }

    }
}