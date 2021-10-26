using System.Net.Http;

namespace Konso.ValueTracking.Clients.Tests
{
    public sealed class DefaultHttpClientFactory : IHttpClientFactory
    {
        public HttpClient CreateClient(string name) => new HttpClient();
    }
}
