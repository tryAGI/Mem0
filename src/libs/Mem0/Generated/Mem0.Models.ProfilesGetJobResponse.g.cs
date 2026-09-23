
#nullable enable

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesGetJobResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::Mem0.ProfilesGetJobResponseJob? Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesGetJobResponse" /> class.
        /// </summary>
        /// <param name="job"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilesGetJobResponse(
            global::Mem0.ProfilesGetJobResponseJob? job)
        {
            this.Job = job;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesGetJobResponse" /> class.
        /// </summary>
        public ProfilesGetJobResponse()
        {
        }

    }
}