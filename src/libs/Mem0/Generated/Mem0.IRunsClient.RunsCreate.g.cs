#nullable enable

namespace Mem0
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Create a new Agent Run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateRun> RunsCreateAsync(

            global::Mem0.CreateRun request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Agent Run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateRun> RunsCreateAsync(
            string runId,
            string? name = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}