#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// Delete a specific project and its related data.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.DeleteProjectResponse> DeleteProjectAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Project<br/>
        /// Delete a specific project and its related data.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.DeleteProjectResponse>> DeleteProjectAsResponseAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}