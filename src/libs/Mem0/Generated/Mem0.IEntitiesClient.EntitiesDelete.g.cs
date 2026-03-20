#nullable enable

namespace Mem0
{
    public partial interface IEntitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.EntitiesDeleteResponse> EntitiesDeleteAsync(
            global::Mem0.EntitiesDeleteEntityType entityType,
            string entityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}