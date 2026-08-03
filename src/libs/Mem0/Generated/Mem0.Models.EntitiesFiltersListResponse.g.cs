
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntitiesFiltersListResponse
    {
        /// <summary>
        /// Event types that can be filtered on.<br/>
        /// Example: [ADD, UPDATE, DELETE, SEARCH, GET_ALL, GET, DELETE_ALL, DELETE_USER]
        /// </summary>
        /// <example>[ADD, UPDATE, DELETE, SEARCH, GET_ALL, GET, DELETE_ALL, DELETE_USER]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public global::System.Collections.Generic.IList<string>? EventType { get; set; }

        /// <summary>
        /// Memory categories that can be filtered on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<object>? Categories { get; set; }

        /// <summary>
        /// User IDs that can be filtered on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// Filter UI field definitions used by the Mem0 dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameter>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponse" /> class.
        /// </summary>
        /// <param name="eventType">
        /// Event types that can be filtered on.<br/>
        /// Example: [ADD, UPDATE, DELETE, SEARCH, GET_ALL, GET, DELETE_ALL, DELETE_USER]
        /// </param>
        /// <param name="categories">
        /// Memory categories that can be filtered on.
        /// </param>
        /// <param name="users">
        /// User IDs that can be filtered on.
        /// </param>
        /// <param name="parameters">
        /// Filter UI field definitions used by the Mem0 dashboard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesFiltersListResponse(
            global::System.Collections.Generic.IList<string>? eventType,
            global::System.Collections.Generic.IList<object>? categories,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameter>? parameters)
        {
            this.EventType = eventType;
            this.Categories = categories;
            this.Users = users;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesFiltersListResponse" /> class.
        /// </summary>
        public EntitiesFiltersListResponse()
        {
        }

    }
}