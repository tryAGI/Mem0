#nullable enable

namespace Mem0
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Add organization member<br/>
        /// Add a new member to a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AddOrganizationMemberResponse> AddOrganizationMemberAsync(
            string orgId,

            global::Mem0.AddOrganizationMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add organization member<br/>
        /// Add a new member to a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="email">
        /// Email of the member to be added.
        /// </param>
        /// <param name="role">
        /// Role of the member in the organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AddOrganizationMemberResponse> AddOrganizationMemberAsync(
            string orgId,
            string email,
            string role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}