#nullable enable

namespace Mem0
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// Get an entity's profile<br/>
        /// Return the memory profile for one user.<br/>
        /// Generation is asynchronous, so a known entity that has no profile yet is a normal 200 carrying a `status`. A 404 means only that no such entity exists.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesReadResponse> ProfilesReadAsync(
            global::Mem0.ProfilesReadEntityType entityType,
            string entityId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an entity's profile<br/>
        /// Return the memory profile for one user.<br/>
        /// Generation is asynchronous, so a known entity that has no profile yet is a normal 200 carrying a `status`. A 404 means only that no such entity exists.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.ProfilesReadResponse>> ProfilesReadAsResponseAsync(
            global::Mem0.ProfilesReadEntityType entityType,
            string entityId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}