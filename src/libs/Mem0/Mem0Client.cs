namespace Mem0;

public sealed partial class Mem0Client
{
    /// <summary>
    /// Mem0 uses "Token" prefix instead of "Bearer" for API key authentication.
    /// This override converts the Authorization header from "Bearer {key}" to "Token {key}".
    /// </summary>
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer" } auth)
        {
            request.Headers.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: "Token",
                    parameter: auth.Parameter);
        }
    }
}
