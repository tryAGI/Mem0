#nullable enable

namespace Mem0
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// Generate profiles<br/>
        /// Start one generation. `operation` says what to build:<br/>
        /// - `sample` — up to 10 real entities, so a schema can be judged before it is used widely. These are real profiles: they are saved to those entities and count toward usage.<br/>
        /// - `trigger` — one entity, named by `entity_id`.<br/>
        /// Send an `Idempotency-Key` header. Replaying the same key returns the same job instead of charging twice. Poll `status_url` from the response until the status is terminal.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesCreateJobResponse> ProfilesCreateJobAsync(

            global::Mem0.ProfilesCreateJobRequest request,
            string? idempotencyKey = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate profiles<br/>
        /// Start one generation. `operation` says what to build:<br/>
        /// - `sample` — up to 10 real entities, so a schema can be judged before it is used widely. These are real profiles: they are saved to those entities and count toward usage.<br/>
        /// - `trigger` — one entity, named by `entity_id`.<br/>
        /// Send an `Idempotency-Key` header. Replaying the same key returns the same job instead of charging twice. Poll `status_url` from the response until the status is terminal.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::Mem0.ProfilesCreateJobResponse>> ProfilesCreateJobAsResponseAsync(

            global::Mem0.ProfilesCreateJobRequest request,
            string? idempotencyKey = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate profiles<br/>
        /// Start one generation. `operation` says what to build:<br/>
        /// - `sample` — up to 10 real entities, so a schema can be judged before it is used widely. These are real profiles: they are saved to those entities and count toward usage.<br/>
        /// - `trigger` — one entity, named by `entity_id`.<br/>
        /// Send an `Idempotency-Key` header. Replaying the same key returns the same job instead of charging twice. Poll `status_url` from the response until the status is terminal.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="operation">
        /// What to generate. Optional only when `entity_id` is set, which means `trigger`.
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="entityId">
        /// One entity, for `trigger`.
        /// </param>
        /// <param name="limit">
        /// How many entities to sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mem0.ProfilesCreateJobResponse> ProfilesCreateJobAsync(
            global::Mem0.ProfilesCreateJobRequestOperation operation,
            string? idempotencyKey = default,
            global::Mem0.ProfilesCreateJobRequestEntityType entityType = default,
            string? entityId = default,
            int? limit = default,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}