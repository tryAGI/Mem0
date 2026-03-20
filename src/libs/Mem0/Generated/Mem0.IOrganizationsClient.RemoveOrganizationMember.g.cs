#nullable enable

namespace Mem0
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove a member from the organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.RemoveOrganizationMemberResponse> RemoveOrganizationMemberAsync(
            string orgId,

            global::Mem0.RemoveOrganizationMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a member from the organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="email">
        /// Email of the member to be removed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.RemoveOrganizationMemberResponse> RemoveOrganizationMemberAsync(
            string orgId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}