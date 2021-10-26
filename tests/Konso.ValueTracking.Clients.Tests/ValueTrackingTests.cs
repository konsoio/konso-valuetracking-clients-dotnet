using FluentAssertions;
using Konso.ValueTracking.Clients.Models;
using Konso.ValueTracking.Clients.Services;
using Konso.ValueTracking.Clients.Tests;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace InDevLabs.Infra.Activity.Tests
{
    public class ValueTrackingTests
    {
        private const string apiUrl = "https://apis.konso.io/v1/value_tracking";
        private const string bucketId = "<your bucket>";
        private const string apiKey = "<bucket's access key>";


        [Fact]
        public async Task Create_SimpleRequest()
        {
            var service = new ValueTrackingService(apiUrl, 
                bucketId,
                apiKey, 
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

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

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

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

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

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

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser", Tags = new List<string>() { "test" } };

            var response = await service.CreateAsync(o);

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

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Tags = new List<string>() { "test" }, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

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
