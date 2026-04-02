
#nullable enable

namespace Mem0
{
    public sealed partial class Mem0Client
    {
        /// <inheritdoc cref="Mem0Client(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Mem0.EndPointAuthorization}?, bool)"/>
        public Mem0Client(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mem0.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}