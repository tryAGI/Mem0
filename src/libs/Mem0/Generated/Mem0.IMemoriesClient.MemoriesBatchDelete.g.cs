#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Batch delete multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesBatchDeleteResponse> MemoriesBatchDeleteAsync(

            global::Mem0.MemoriesBatchDeleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch delete multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="memoryIds">
        /// Array of memory IDs to delete.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesBatchDeleteResponse> MemoriesBatchDeleteAsync(
            global::System.Collections.Generic.IList<global::System.Guid> memoryIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}