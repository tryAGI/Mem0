#nullable enable

namespace Mem0
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Retrieve details of a specific event by its ID.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.EventReadResponse> EventReadAsync(
            global::System.Guid eventId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}