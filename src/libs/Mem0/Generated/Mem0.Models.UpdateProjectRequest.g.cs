
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
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
        /// Custom instructions for memory processing in this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public global::System.Collections.Generic.IList<string>? CustomInstructions { get; set; }

        /// <summary>
        /// Extraction instructions for agent-scoped memories. Falls back to `custom_instructions` when unset. Send an empty string to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_custom_instructions")]
        public string? AgentCustomInstructions { get; set; }

        /// <summary>
        /// List of custom categories to be used for memory categorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_categories")]
        public global::System.Collections.Generic.IList<object>? CustomCategories { get; set; }

        /// <summary>
        /// Whether to use the input language for memory storage and retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multilingual")]
        public bool? Multilingual { get; set; }

        /// <summary>
        /// Memory extraction depth setting for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_depth")]
        public string? MemoryDepth { get; set; }

        /// <summary>
        /// Whether memory decay is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decay")]
        public bool? Decay { get; set; }

        /// <summary>
        /// Whether graph memory is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_graph")]
        public bool? EnableGraph { get; set; }

        /// <summary>
        /// API version used by this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="customInstructions">
        /// Custom instructions for memory processing in this project
        /// </param>
        /// <param name="agentCustomInstructions">
        /// Extraction instructions for agent-scoped memories. Falls back to `custom_instructions` when unset. Send an empty string to clear it.
        /// </param>
        /// <param name="customCategories">
        /// List of custom categories to be used for memory categorization.
        /// </param>
        /// <param name="multilingual">
        /// Whether to use the input language for memory storage and retrieval.
        /// </param>
        /// <param name="memoryDepth">
        /// Memory extraction depth setting for this project.
        /// </param>
        /// <param name="decay">
        /// Whether memory decay is enabled for this project.
        /// </param>
        /// <param name="enableGraph">
        /// Whether graph memory is enabled for this project.
        /// </param>
        /// <param name="version">
        /// API version used by this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? customInstructions,
            string? agentCustomInstructions,
            global::System.Collections.Generic.IList<object>? customCategories,
            bool? multilingual,
            string? memoryDepth,
            bool? decay,
            bool? enableGraph,
            string? version)
        {
            this.Name = name;
            this.Description = description;
            this.CustomInstructions = customInstructions;
            this.AgentCustomInstructions = agentCustomInstructions;
            this.CustomCategories = customCategories;
            this.Multilingual = multilingual;
            this.MemoryDepth = memoryDepth;
            this.Decay = decay;
            this.EnableGraph = enableGraph;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }

    }
}