
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PingReadResponse
    {
        /// <summary>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PingReadResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: ok
        /// </param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="userEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PingReadResponse(
            string? status,
            string? orgId,
            string? projectId,
            string? userEmail)
        {
            this.Status = status;
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.UserEmail = userEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingReadResponse" /> class.
        /// </summary>
        public PingReadResponse()
        {
        }

    }
}