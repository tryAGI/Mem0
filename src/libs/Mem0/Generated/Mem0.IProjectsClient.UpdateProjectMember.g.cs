#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project member role<br/>
        /// Update the role of a member in a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectMemberResponse> UpdateProjectMemberAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateProjectMemberRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project member role<br/>
        /// Update the role of a member in a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="email">
        /// Email of the member to be updated
        /// </param>
        /// <param name="role">
        /// New role of the member in the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectMemberResponse> UpdateProjectMemberAsync(
            string orgId,
            string projectId,
            string email,
            string role,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}