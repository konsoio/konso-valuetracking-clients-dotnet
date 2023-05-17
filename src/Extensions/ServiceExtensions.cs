using Konso.Clients.ValueTracking.Interfaces;
using Konso.Clients.ValueTracking.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Konso.Clients.ValueTracking.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddKonsoValueTracking(this IServiceCollection services)
        {
            // use httpclient factory
            services.AddHttpClient();
            services.AddSingleton<IValueTrackingClient, ValueTrackingClient>();
        }
    }
}
