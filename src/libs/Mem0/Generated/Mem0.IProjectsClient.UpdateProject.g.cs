#nullable enable

namespace Mem0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Update a specific project's settings.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateProjectRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update a specific project's settings.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.UpdateProjectResponse>> UpdateProjectAsResponseAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateProjectRequest request,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update a specific project's settings.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="customInstructions">
        /// Custom instructions for memory processing in this project
        /// </param>
        /// <param name="agentCustomInstructions">
        /// Extraction instructions for agent-scoped memories. Falls back to `custom_instructions` when unset. Send an empty string to clear it.
        /// </param>
        /// <param name="customCategories">
        /// List of custom categories to be used for memory categorization.
        /// </param>
        /// <param name="multilingual">
        /// Whether to use the input language for memory storage and retrieval.
        /// </param>
        /// <param name="memoryDepth">
        /// Memory extraction depth setting for this project.
        /// </param>
        /// <param name="decay">
        /// Whether memory decay is enabled for this project.
        /// </param>
        /// <param name="enableGraph">
        /// Whether graph memory is enabled for this project.
        /// </param>
        /// <param name="version">
        /// API version used by this project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? customInstructions = default,
            string? agentCustomInstructions = default,
            global::System.Collections.Generic.IList<object>? customCategories = default,
            bool? multilingual = default,
            string? memoryDepth = default,
            bool? decay = default,
            bool? enableGraph = default,
            string? version = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}