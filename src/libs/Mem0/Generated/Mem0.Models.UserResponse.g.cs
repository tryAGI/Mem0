
#nullable enable

namespace Mem0
{
    /// <summary>
    /// Response returned after creating a User.
    /// </summary>
    public sealed partial class UserResponse
    {
        /// <summary>
        /// Internal numeric identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Graph entities linked to this record, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_entities")]
        public object? GraphEntities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Internal numeric identifier of the project this record belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Internal numeric identifier.
        /// </param>
        /// <param name="userId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="graphEntities">
        /// Graph entities linked to this record, if any.
        /// </param>
        /// <param name="isDeleted"></param>
        /// <param name="project">
        /// Internal numeric identifier of the project this record belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserResponse(
            int? id,
            string? userId,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            object? graphEntities,
            bool? isDeleted,
            int? project)
        {
            this.Id = id;
            this.UserId = userId;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.GraphEntities = graphEntities;
            this.IsDeleted = isDeleted;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        public UserResponse()
        {
        }

    }
}