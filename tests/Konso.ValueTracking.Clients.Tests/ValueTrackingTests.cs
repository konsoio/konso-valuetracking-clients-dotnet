using FluentAssertions;
using Konso.ValueTracking.Clients.Models;
using Konso.ValueTracking.Clients.Services;
using Konso.ValueTracking.Clients.Tests;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace InDevLabs.Infra.Activity.Tests
{
    public class ValueTrackingTests
    {
        private const string apiUrl = "https://devapis.konso.io/v1/value_tracking";
        private const string bucketId = "cab6ff8d";
        private const string apiKey = "IL84eTnxvn5mtlZNH3sSnMqE8V6E5hNm3Synx9E+XeU=";


        [Fact]
        public async Task Create_SimpleRequest()
        {
            var service = new ValueTrackingService(apiUrl, 
                bucketId,
                apiKey, 
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1 };

            var response = await service.CreateAsync(o, "test browser");

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleRequestFresh()
        {
            var service = new ValueTrackingService(apiUrl,
                bucketId,
                apiKey,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1 };

            var response = await service.CreateAsync(o, "test browser");

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleRequestFresh2()
        {
            var service = new ValueTrackingService(apiUrl,
                bucketId,
                apiKey,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1 };

            var response = await service.CreateAsync(o, "test browser");

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleWithTag()
        {
            var service = new ValueTrackingService(apiUrl,
                bucketId,
                apiKey,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Tags = new List<string>() { "test" } };

            var response = await service.CreateAsync(o, "test browser");

            // 
            response.Should().BeTrue();
        }


        [Fact]
        public async Task CreateAndGet_SimpleWithTag()
        {
            // arrange
            var service = new ValueTrackingService(apiUrl,
                bucketId,
                apiKey,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Tags = new List<string>() { "test" } };

            var response = await service.CreateAsync(o, "test browser");

            // act
            var res = await service.GetByAsync(new ValueTrackingGetRequest() { Tags = new List<string>() { "test" }, From = 0, To = 10 });


            // assert
            foreach (var item in res.List)
            {
                item.Tags.Should().Contain("test");
            }
        }
    }
}
