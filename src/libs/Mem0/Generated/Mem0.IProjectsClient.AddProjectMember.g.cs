#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add member to project<br/>
        /// Add a new member to a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AddProjectMemberResponse> AddProjectMemberAsync(
            string orgId,
            string projectId,

            global::Mem0.AddProjectMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add member to project<br/>
        /// Add a new member to a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="email">
        /// Email of the member to be added.
        /// </param>
        /// <param name="role">
        /// Role of the member in the project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AddProjectMemberResponse> AddProjectMemberAsync(
            string orgId,
            string projectId,
            string email,
            string role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}