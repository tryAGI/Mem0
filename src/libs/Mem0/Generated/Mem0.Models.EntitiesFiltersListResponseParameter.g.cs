
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntitiesFiltersListResponseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameterOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponseParameter" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="type"></param>
        /// <param name="placeholder"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesFiltersListResponseParameter(
            string? name,
            string? label,
            string? type,
            string? placeholder,
            global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameterOption>? options)
        {
            this.Name = name;
            this.Label = label;
            this.Type = type;
            this.Placeholder = placeholder;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponseParameter" /> class.
        /// </summary>
        public EntitiesFiltersListResponseParameter()
        {
        }

    }
}