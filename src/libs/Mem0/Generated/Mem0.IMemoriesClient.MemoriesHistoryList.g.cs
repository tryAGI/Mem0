#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Retrieve the history of a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>> MemoriesHistoryListAsync(
            global::System.Guid memoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}