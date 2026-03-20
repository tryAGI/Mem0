#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Batch update multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesBatchUpdateResponse> MemoriesBatchUpdateAsync(

            global::Mem0.MemoriesBatchUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Batch update multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="memories"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesBatchUpdateResponse> MemoriesBatchUpdateAsync(
            global::System.Collections.Generic.IList<global::Mem0.MemoriesBatchUpdateRequestMemorie> memories,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}