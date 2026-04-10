#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create a new project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateProjectResponse> CreateProjectAsync(
            string orgId,

            global::Mem0.CreateProjectRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="name">
        /// Name of the project to be created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateProjectResponse> CreateProjectAsync(
            string orgId,
            string name,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}