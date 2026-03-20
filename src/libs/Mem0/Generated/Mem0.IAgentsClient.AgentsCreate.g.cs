#nullable enable

namespace Mem0
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create a new Agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateAgent> AgentsCreateAsync(

            global::Mem0.CreateAgent request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new Agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateAgent> AgentsCreateAsync(
            string agentId,
            string? name = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}