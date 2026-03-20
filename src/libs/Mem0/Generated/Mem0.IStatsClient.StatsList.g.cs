#nullable enable

namespace Mem0
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Retrieve memory-related statistics for the authenticated user.<br/>
        /// This endpoint returns the following statistics:<br/>
        /// - Total number of memories created<br/>
        /// - Total number of search events<br/>
        /// - Total number of add events
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task StatsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}