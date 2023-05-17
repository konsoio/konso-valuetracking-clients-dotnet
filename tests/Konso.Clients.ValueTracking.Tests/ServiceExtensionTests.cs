using Konso.Clients.ValueTracking.Extensions;
using Konso.Clients.ValueTracking.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Konso.Clients.ValueTracking.Tests
{
    public class ServiceExtensionTests
    {
        [Fact]
        public void register_ValueTracking()
        {
            var services = new ServiceCollection();

            services.AddKonsoValueTracking(options =>
            {
                options.Endpoint = "https://apis.konso.io";
                options.BucketId = "<your bucket>";
                options.ApiKey = "<bucket's access key>";
            });


            var provider = services.BuildServiceProvider();

            var restService = provider.GetRequiredService<IValueTrackingClient>();
        }
    }
}
