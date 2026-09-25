#nullable enable

namespace Mem0
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// Update profile settings<br/>
        /// Update the project's profile settings. Only the fields present in the body are written, so one setting can change without re-sending the others.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesSettingsUpdateResponse> ProfilesSettingsUpdateAsync(

            global::Mem0.ProfilesSettingsUpdateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update profile settings<br/>
        /// Update the project's profile settings. Only the fields present in the body are written, so one setting can change without re-sending the others.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.ProfilesSettingsUpdateResponse>> ProfilesSettingsUpdateAsResponseAsync(

            global::Mem0.ProfilesSettingsUpdateRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update profile settings<br/>
        /// Update the project's profile settings. Only the fields present in the body are written, so one setting can change without re-sending the others.
        /// </summary>
        /// <param name="enabled">
        /// Whether profile generation runs for this project. Project-wide.
        /// </param>
        /// <param name="entities">
        /// Settings for user profiles, under `user`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesSettingsUpdateResponse> ProfilesSettingsUpdateAsync(
            bool? enabled = default,
            global::Mem0.ProfilesSettingsUpdateRequestEntities? entities = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}