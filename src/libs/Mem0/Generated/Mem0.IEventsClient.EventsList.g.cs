#nullable enable

namespace Mem0
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Retrieve all events for current organization and project.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.EventsListResponse> EventsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}