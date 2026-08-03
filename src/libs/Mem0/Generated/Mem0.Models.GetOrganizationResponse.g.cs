
#nullable enable

namespace Mem0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationResponse
    {
        /// <summary>
        /// Organization's unique string identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp of when the organization was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the organization was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Members belonging to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Mem0.GetOrganizationResponseMember>? Members { get; set; }

        /// <summary>
        /// Whether this is the caller's default organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Whether bring-your-own-key is enabled for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_enabled")]
        public bool? ByokEnabled { get; set; }

        /// <summary>
        /// Pending invitations for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitations")]
        public global::System.Collections.Generic.IList<object>? Invitations { get; set; }

        /// <summary>
        /// Pricing plan of the organization owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_pricing_plan")]
        public string? OwnerPricingPlan { get; set; }

        /// <summary>
        /// Whether the caller owns the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// The caller's role within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public string? UserRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        /// <param name="orgId">
        /// Organization's unique string identifier.
        /// </param>
        /// <param name="name">
        /// Name of the organization.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the organization was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the organization was last updated.
        /// </param>
        /// <param name="members">
        /// Members belonging to the organization.
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the caller's default organization.
        /// </param>
        /// <param name="byokEnabled">
        /// Whether bring-your-own-key is enabled for the organization.
        /// </param>
        /// <param name="invitations">
        /// Pending invitations for the organization.
        /// </param>
        /// <param name="ownerPricingPlan">
        /// Pricing plan of the organization owner.
        /// </param>
        /// <param name="isOwner">
        /// Whether the caller owns the organization.
        /// </param>
        /// <param name="userRole">
        /// The caller's role within the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationResponse(
            string? orgId,
            string? name,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::Mem0.GetOrganizationResponseMember>? members,
            bool? isDefault,
            bool? byokEnabled,
            global::System.Collections.Generic.IList<object>? invitations,
            string? ownerPricingPlan,
            bool? isOwner,
            string? userRole)
        {
            this.OrgId = orgId;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Members = members;
            this.IsDefault = isDefault;
            this.ByokEnabled = byokEnabled;
            this.Invitations = invitations;
            this.OwnerPricingPlan = ownerPricingPlan;
            this.IsOwner = isOwner;
            this.UserRole = userRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        public GetOrganizationResponse()
        {
        }

    }
}