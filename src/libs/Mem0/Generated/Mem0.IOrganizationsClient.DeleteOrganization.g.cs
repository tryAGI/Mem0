#nullable enable

namespace Mem0
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Delete an organization by its ID.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.DeleteOrganizationResponse> DeleteOrganizationAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}