#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Members<br/>
        /// Retrieve a list of members for a specific project.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetProjectMembersResponse> GetProjectMembersAsync(
            string orgId,
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}