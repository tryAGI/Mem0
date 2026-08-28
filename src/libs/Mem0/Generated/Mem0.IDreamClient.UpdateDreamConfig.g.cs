#nullable enable

namespace Mem0
{
    public partial interface IDreamClient
    {
        /// <summary>
        /// Update Dream configuration<br/>
        /// Enable or disable Synthesis (reflection) for the project, or change the reflection mode. Requires a Pro or Enterprise (CUSTOM) plan and organization-owner permission. Synthesis is forward-only: after enabling, it only synthesizes memories added from that point on.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateDreamConfigResponse> UpdateDreamConfigAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateDreamConfigRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dream configuration<br/>
        /// Enable or disable Synthesis (reflection) for the project, or change the reflection mode. Requires a Pro or Enterprise (CUSTOM) plan and organization-owner permission. Synthesis is forward-only: after enabling, it only synthesizes memories added from that point on.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.UpdateDreamConfigResponse>> UpdateDreamConfigAsResponseAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateDreamConfigRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dream configuration<br/>
        /// Enable or disable Synthesis (reflection) for the project, or change the reflection mode. Requires a Pro or Enterprise (CUSTOM) plan and organization-owner permission. Synthesis is forward-only: after enabling, it only synthesizes memories added from that point on.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="reflectionEnabled">
        /// Turn background synthesis on or off.
        /// </param>
        /// <param name="reflectionMode">
        /// Synthesis execution mode.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateDreamConfigResponse> UpdateDreamConfigAsync(
            string orgId,
            string projectId,
            bool? reflectionEnabled = default,
            global::Mem0.UpdateDreamConfigRequestReflectionMode? reflectionMode = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}