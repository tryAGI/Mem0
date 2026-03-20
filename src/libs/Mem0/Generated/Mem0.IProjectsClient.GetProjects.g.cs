#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get projects<br/>
        /// Retrieve a list of projects for a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItem>> GetProjectsAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}