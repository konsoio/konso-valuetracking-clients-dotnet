﻿using Konso.Clients.ValueTracking.Interfaces;
using Konso.Clients.ValueTracking.Models;
using Konso.Clients.ValueTracking.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Konso.Clients.ValueTracking.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddKonsoValueTracking(this IServiceCollection services, Action<ValueTrackingOptions> configureOptions)
        {
            services.AddOptions();
            
            // use httpclient factory
            services.AddHttpClient();
            services.AddSingleton<IValueTrackingClient, ValueTrackingClient>();

            // setup configuration
            services.Configure<ValueTrackingOptions>(configureOptions);
        }
    }
}
