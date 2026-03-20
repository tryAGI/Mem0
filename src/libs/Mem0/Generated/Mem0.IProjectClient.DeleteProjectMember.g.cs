#nullable enable

namespace Mem0
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete Project Member
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.DeleteProjectMemberResponse> DeleteProjectMemberAsync(
            string orgId,
            string projectId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}