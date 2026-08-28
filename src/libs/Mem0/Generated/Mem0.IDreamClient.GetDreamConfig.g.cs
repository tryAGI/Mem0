#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Get Dream configuration<br/>
        /// Retrieve the project's Dream (memory synthesis) configuration together with the plan entitlement snapshot. Dream automatically supersedes/merges memories on the add path; **Synthesis** (reflection) is the opt-in part controlled by `reflection_enabled`.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.GetDreamConfigResponse> GetDreamConfigAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dream configuration<br/>
        /// Retrieve the project's Dream (memory synthesis) configuration together with the plan entitlement snapshot. Dream automatically supersedes/merges memories on the add path; **Synthesis** (reflection) is the opt-in part controlled by `reflection_enabled`.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.GetDreamConfigResponse>> GetDreamConfigAsResponseAsync(
            string orgId,
            string projectId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}