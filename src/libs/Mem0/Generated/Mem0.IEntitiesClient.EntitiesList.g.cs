#nullable enable

namespace Mem0
{
    public partial interface IEntitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.EntitiesListResponseItem>> EntitiesListAsync(
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}