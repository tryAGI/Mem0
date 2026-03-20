#nullable enable

namespace Mem0
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get or Update or delete a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesUpdateResponse> MemoriesUpdateAsync(
            global::System.Guid memoryId,

            global::Mem0.MemoriesUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get or Update or delete a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="text">
        /// The updated text content of the memory
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.MemoriesUpdateResponse> MemoriesUpdateAsync(
            global::System.Guid memoryId,
            string? text = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}