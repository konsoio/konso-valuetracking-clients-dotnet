using Konso.Clients.ValueTracking.Models;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Text;
using Konso.Clients.ValueTracking.Interfaces;
using Konso.Clients.ValueTracking.Extensions;
using System.Text.Json;

namespace Konso.Clients.ValueTracking.Services
{
    public class ValueTrackingClient : IValueTrackingClient
    {
        private readonly IHttpClientFactory _clientFactory;

        private readonly ValueTrackingOptions _config;
        
        public ValueTrackingClient(ValueTrackingOptions config, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _config = config;
        }

        public ValueTrackingClient(string endpoint, string bucketId, string apiKey, IHttpClientFactory clientFactory)
        {
            _config = new ValueTrackingOptions();
            _config.Endpoint = endpoint;
            _config.BucketId = bucketId;
            _config.ApiKey = apiKey;
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> CreateAsync(ValueTrackingCreateRequest request)
        {
            var client = _clientFactory.CreateClient();
            
            if (string.IsNullOrEmpty(_config.Endpoint)) throw new Exception("Endpoint is not defined");
            if (string.IsNullOrEmpty(_config.BucketId)) throw new Exception("Bucket is not defined");
            if (string.IsNullOrEmpty(_config.ApiKey)) throw new Exception("API key is not defined");
            if (!client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", _config.ApiKey)) throw new Exception("Missing API key");

            request.TimeStamp = DateTime.UtcNow.ToEpoch();

            // serialize request as json
            var jsonStr = JsonSerializer.Serialize(request);

            // string content 
            var httpItem = new StringContent(jsonStr, Encoding.UTF8, "application/json");

            // call api
            try
            {
                var response = await client.PostAsync($"{_config.Endpoint}/v1/value_tracking/{_config.BucketId}", httpItem);
                response.EnsureSuccessStatusCode();
                var contents = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(contents)) return false;

                var result = JsonSerializer.Deserialize<KonsoGenericResponse<bool>>(contents);

                if (!result.Succeeded)
                    throw new Exception(string.Format("Error sending value tracking {0}", result.ValidationErrors[0].Message));
                return true;
            }
            catch (HttpRequestException ex)
            { 
                return false;
            }
        }

        public async Task<KonsoPagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request)
        {
            try
            {
                var client = new HttpClient();

                if (string.IsNullOrEmpty(_config.Endpoint)) throw new Exception("Endpoint is not defined");
                if (string.IsNullOrEmpty(_config.BucketId)) throw new Exception("Bucket is not defined");
                if (string.IsNullOrEmpty(_config.ApiKey)) throw new Exception("API key is not defined");
                if (!client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", _config.ApiKey)) throw new Exception("Missing API key");

                int sortNum = (int)request.Sort;
                var builder = new UriBuilder($"{_config.Endpoint}/v1/value_tracking/{_config.BucketId}")
                {
                    Port = -1
                };
                var query = HttpUtility.ParseQueryString(builder.Query);
                if (request.EventId.HasValue)
                    query["eventId"] = request.EventId.ToString();
                
                
                if(!string.IsNullOrEmpty(request.EventName))
                    query["eventname"] = request.EventName;

                if (request.DateFrom.HasValue)
                    query["fromDate"] = request.DateFrom.ToString();
                
                if(request.DateTo.HasValue)
                    query["toDate"] = request.DateTo.ToString();
                if(sortNum > 0)
                    query["sort"] = sortNum.ToString();
                query["from"] = request.From.ToString();
                query["to"] = request.To.ToString();
                query["referenceId"] = request.ReferenceId;
                query["correlationId"] = request.CorrelationId;
                if (request.Tags != null && request.Tags.Count > 0)
                {
                    query["tags"] = String.Join(",", request.Tags);
                }
                
                builder.Query = query.ToString();
                string url = builder.ToString();

                string responseBody = await client.GetStringAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                var responseObj = JsonSerializer.Deserialize<KonsoPagedResponse<ValueTrackingItem>>(responseBody, options);
                return responseObj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<KonsoPagedResponseWithAggs<ValueTrackingItem>> GetByWithAggsAsync(ValueTrackingGetRequest request)
        {
            try
            {
                var client = new HttpClient();

                if (string.IsNullOrEmpty(_config.Endpoint)) throw new Exception("Endpoint is not defined");
                if (string.IsNullOrEmpty(_config.BucketId)) throw new Exception("Bucket is not defined");
                if (string.IsNullOrEmpty(_config.ApiKey)) throw new Exception("API key is not defined");
                if (!client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", _config.ApiKey)) throw new Exception("Missing API key");

                int sortNum = (int)request.Sort;
                var builder = new UriBuilder($"{_config.Endpoint}/v1/value_tracking_with_aggs/{_config.BucketId}")
                {
                    Port = -1
                };
                var query = HttpUtility.ParseQueryString(builder.Query);
                if (request.EventId.HasValue)
                    query["eventId"] = request.EventId.ToString();


                if (!string.IsNullOrEmpty(request.EventName))
                    query["eventname"] = request.EventName;

                if (request.DateFrom.HasValue)
                    query["fromDate"] = request.DateFrom.ToString();

                if (request.DateTo.HasValue)
                    query["toDate"] = request.DateTo.ToString();
                if (sortNum > 0)
                    query["sort"] = sortNum.ToString();
                query["from"] = request.From.ToString();
                query["to"] = request.To.ToString();
                query["referenceId"] = request.ReferenceId;
                query["correlationId"] = request.CorrelationId;
                if (request.Tags != null && request.Tags.Count > 0)
                {
                    query["tags"] = String.Join(",", request.Tags);
                }

                builder.Query = query.ToString();
                string url = builder.ToString();

                string responseBody = await client.GetStringAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                var responseObj = JsonSerializer.Deserialize<KonsoPagedResponseWithAggs<ValueTrackingItem>>(responseBody, options);
                return responseObj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
