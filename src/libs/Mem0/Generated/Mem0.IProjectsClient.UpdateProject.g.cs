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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,

            global::Mem0.UpdateProjectRequest request,
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
        /// <param name="customCategories">
        /// List of custom categories to be used for memory categorization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? customInstructions = default,
            global::System.Collections.Generic.IList<object>? customCategories = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}