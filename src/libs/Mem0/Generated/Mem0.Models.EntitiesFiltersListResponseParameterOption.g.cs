
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntitiesFiltersListResponseParameterOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponseParameterOption" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesFiltersListResponseParameterOption(
            string? value,
            string? label)
        {
            this.Value = value;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponseParameterOption" /> class.
        /// </summary>
        public EntitiesFiltersListResponseParameterOption()
        {
        }

    }
}