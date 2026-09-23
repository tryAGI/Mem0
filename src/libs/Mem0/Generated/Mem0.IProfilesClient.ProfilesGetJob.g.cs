#nullable enable

namespace Mem0
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// Read a generation job<br/>
        /// The job nests under `job`. `total` is null until `enumeration_complete`, and `completed` is `succeeded + failed + skipped`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesGetJobResponse> ProfilesGetJobAsync(
            string jobId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read a generation job<br/>
        /// The job nests under `job`. `total` is null until `enumeration_complete`, and `completed` is `succeeded + failed + skipped`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.ProfilesGetJobResponse>> ProfilesGetJobAsResponseAsync(
            string jobId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}