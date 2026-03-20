#nullable enable

namespace Mem0
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a new User.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateUser> UsersCreateAsync(

            global::Mem0.CreateUser request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new User.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.CreateUser> UsersCreateAsync(
            string userId,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}