
#nullable enable

namespace Mem0
{
    public partial class MemoriesClient
    {


        private static readonly global::Mem0.EndPointSecurityRequirement s_MemoriesHistoryListSecurityRequirement0 =
            new global::Mem0.EndPointSecurityRequirement
            {
                Authorizations = new global::Mem0.EndPointAuthorizationRequirement[]
                {                    new global::Mem0.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Mem0.EndPointSecurityRequirement[] s_MemoriesHistoryListSecurityRequirements =
            new global::Mem0.EndPointSecurityRequirement[]
            {                s_MemoriesHistoryListSecurityRequirement0,
            };
        partial void PrepareMemoriesHistoryListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid memoryId);
        partial void PrepareMemoriesHistoryListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid memoryId);
        partial void ProcessMemoriesHistoryListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoriesHistoryListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve the history of a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>> MemoriesHistoryListAsync(
            global::System.Guid memoryId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await MemoriesHistoryListAsResponseAsync(
                memoryId: memoryId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Retrieve the history of a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mem0.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mem0.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>>> MemoriesHistoryListAsResponseAsync(
            global::System.Guid memoryId,
            global::Mem0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMemoriesHistoryListArguments(
                httpClient: HttpClient,
                memoryId: ref memoryId);


            var __authorizations = global::Mem0.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MemoriesHistoryListSecurityRequirements,
                operationName: "MemoriesHistoryListAsync");

            using var __timeoutCancellationTokenSource = global::Mem0.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Mem0.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Mem0.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Mem0.PathBuilder(
                                path: $"/v1/memories/{memoryId}/history/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Mem0.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::Mem0.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareMemoriesHistoryListRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    memoryId: memoryId!);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Mem0.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Mem0.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesHistoryList",
                                methodName: "MemoriesHistoryListAsync",
                                pathTemplate: "$\"/v1/memories/{memoryId}/history/\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Mem0.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Mem0.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mem0.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesHistoryList",
                                methodName: "MemoriesHistoryListAsync",
                                pathTemplate: "$\"/v1/memories/{memoryId}/history/\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mem0.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Mem0.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Mem0.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Mem0.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mem0.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesHistoryList",
                                methodName: "MemoriesHistoryListAsync",
                                pathTemplate: "$\"/v1/memories/{memoryId}/history/\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mem0.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessMemoriesHistoryListResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Mem0.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Mem0.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesHistoryList",
                                methodName: "MemoriesHistoryListAsync",
                                pathTemplate: "$\"/v1/memories/{memoryId}/history/\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Mem0.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mem0.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesHistoryList",
                                methodName: "MemoriesHistoryListAsync",
                                pathTemplate: "$\"/v1/memories/{memoryId}/history/\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessMemoriesHistoryListResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Mem0.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Mem0.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Mem0.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = (global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Mem0.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Mem0.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Mem0.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}