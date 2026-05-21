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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task EntitiesReadAsync(
            global::Mem0.EntitiesReadEntityType entityType,
            string entityId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse> EntitiesReadAsResponseAsync(
            global::Mem0.EntitiesReadEntityType entityType,
            string entityId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}