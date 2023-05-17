using FluentAssertions;
using Konso.Clients.ValueTracking.Models;
using Konso.Clients.ValueTracking.Services;
using Konso.Clients.ValueTracking.Tests;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace InDevLabs.Infra.Activity.Tests
{
    public class ValueTrackingTests
    {
        private readonly ValueTrackingOptions config = new ValueTrackingOptions() { Endpoint = "https://apis.konso.io", ApiKey = "<bucket's access key>", BucketId = "<your bucket>" };
      
        [Fact]
        public async Task Create_SimpleRequest()
        {
            var service = new ValueTrackingClient(config,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleRequestFresh()
        {
            var service = new ValueTrackingClient(config,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleRequestFresh2()
        {
            var service = new ValueTrackingClient(config,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

            // 
            response.Should().BeTrue();
        }

        [Fact]
        public async Task Create_SimpleWithTag()
        {
            var service = new ValueTrackingClient(config,
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
            var service = new ValueTrackingClient(config,
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

        [Fact]
        public async Task CreateAndGetWithAggs()
        {
            // arrange
            var service = new ValueTrackingClient(config,
                new DefaultHttpClientFactory());

            var o = new ValueTrackingCreateRequest() { AppName = "test", Country = "UK", Value = 49.00, EventId = 1, Tags = new List<string>() { "test" }, Browser = "Test Browser" };

            var response = await service.CreateAsync(o);

            // act
            var res = await service.GetByWithAggsAsync(new ValueTrackingGetRequest() { Tags = new List<string>() { "test" }, From = 0, To = 10 });


            // assert
            res.Aggs.Count.Should().BeGreaterThan(0);
        }

    }
}
