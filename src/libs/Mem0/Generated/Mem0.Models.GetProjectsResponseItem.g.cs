
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectsResponseItem
    {
        /// <summary>
        /// Unique string identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Timestamp of when the project was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the project was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// List of members belonging to the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItemMember>? Members { get; set; }

        /// <summary>
        /// Configured use case for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usecase")]
        public string? Usecase { get; set; }

        /// <summary>
        /// Memory extraction depth setting for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_depth")]
        public string? MemoryDepth { get; set; }

        /// <summary>
        /// Custom prompt describing what should be included when extracting memories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inclusion_prompt")]
        public string? InclusionPrompt { get; set; }

        /// <summary>
        /// Custom prompt describing what should be excluded when extracting memories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusion_prompt")]
        public string? ExclusionPrompt { get; set; }

        /// <summary>
        /// List of custom categories configured for memory categorization in this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_categories")]
        public global::System.Collections.Generic.IList<object>? CustomCategories { get; set; }

        /// <summary>
        /// Custom instructions for memory processing in this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Custom instructions applied when updating existing memories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_custom_instructions")]
        public string? UpdateCustomInstructions { get; set; }

        /// <summary>
        /// Custom instructions applied when generating summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_custom_instructions")]
        public string? SummaryCustomInstructions { get; set; }

        /// <summary>
        /// Number of items processed per batch when generating summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_batch_size")]
        public int? SummaryBatchSize { get; set; }

        /// <summary>
        /// Maximum tokens allowed in a generated summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_max_tokens")]
        public int? SummaryMaxTokens { get; set; }

        /// <summary>
        /// Default expiration date applied to memories created in this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// Whether graph memory is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_graph")]
        public bool? EnableGraph { get; set; }

        /// <summary>
        /// Whether to use the input language for memory storage and retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multilingual")]
        public bool? Multilingual { get; set; }

        /// <summary>
        /// API version used by this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Whether this is the organization's default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Identifier of the active prompt profile for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_prompt_profile")]
        public string? ActivePromptProfile { get; set; }

        /// <summary>
        /// Whether memory decay is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decay")]
        public bool? Decay { get; set; }

        /// <summary>
        /// Role of the requesting user within this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public string? UserRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseItem" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique string identifier of the project
        /// </param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the project was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the project was last updated
        /// </param>
        /// <param name="members">
        /// List of members belonging to the project
        /// </param>
        /// <param name="usecase">
        /// Configured use case for the project.
        /// </param>
        /// <param name="memoryDepth">
        /// Memory extraction depth setting for this project.
        /// </param>
        /// <param name="inclusionPrompt">
        /// Custom prompt describing what should be included when extracting memories.
        /// </param>
        /// <param name="exclusionPrompt">
        /// Custom prompt describing what should be excluded when extracting memories.
        /// </param>
        /// <param name="customCategories">
        /// List of custom categories configured for memory categorization in this project.
        /// </param>
        /// <param name="customInstructions">
        /// Custom instructions for memory processing in this project.
        /// </param>
        /// <param name="updateCustomInstructions">
        /// Custom instructions applied when updating existing memories.
        /// </param>
        /// <param name="summaryCustomInstructions">
        /// Custom instructions applied when generating summaries.
        /// </param>
        /// <param name="summaryBatchSize">
        /// Number of items processed per batch when generating summaries.
        /// </param>
        /// <param name="summaryMaxTokens">
        /// Maximum tokens allowed in a generated summary.
        /// </param>
        /// <param name="expirationDate">
        /// Default expiration date applied to memories created in this project.
        /// </param>
        /// <param name="enableGraph">
        /// Whether graph memory is enabled for this project.
        /// </param>
        /// <param name="multilingual">
        /// Whether to use the input language for memory storage and retrieval.
        /// </param>
        /// <param name="version">
        /// API version used by this project.
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the organization's default project.
        /// </param>
        /// <param name="activePromptProfile">
        /// Identifier of the active prompt profile for this project.
        /// </param>
        /// <param name="decay">
        /// Whether memory decay is enabled for this project.
        /// </param>
        /// <param name="userRole">
        /// Role of the requesting user within this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseItem(
            string? projectId,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItemMember>? members,
            string? usecase,
            string? memoryDepth,
            string? inclusionPrompt,
            string? exclusionPrompt,
            global::System.Collections.Generic.IList<object>? customCategories,
            string? customInstructions,
            string? updateCustomInstructions,
            string? summaryCustomInstructions,
            int? summaryBatchSize,
            int? summaryMaxTokens,
            string? expirationDate,
            bool? enableGraph,
            bool? multilingual,
            string? version,
            bool? isDefault,
            string? activePromptProfile,
            bool? decay,
            string? userRole)
        {
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Members = members;
            this.Usecase = usecase;
            this.MemoryDepth = memoryDepth;
            this.InclusionPrompt = inclusionPrompt;
            this.ExclusionPrompt = exclusionPrompt;
            this.CustomCategories = customCategories;
            this.CustomInstructions = customInstructions;
            this.UpdateCustomInstructions = updateCustomInstructions;
            this.SummaryCustomInstructions = summaryCustomInstructions;
            this.SummaryBatchSize = summaryBatchSize;
            this.SummaryMaxTokens = summaryMaxTokens;
            this.ExpirationDate = expirationDate;
            this.EnableGraph = enableGraph;
            this.Multilingual = multilingual;
            this.Version = version;
            this.IsDefault = isDefault;
            this.ActivePromptProfile = activePromptProfile;
            this.Decay = decay;
            this.UserRole = userRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseItem" /> class.
        /// </summary>
        public GetProjectsResponseItem()
        {
        }

    }
}