

# Konso ValueTracking .Net Client

A .NET 5 Open Source Client Library for [KonsoApp](https://app.konso.io)

✅ Developed / Developing by [InDevLabs](https://indevlabs.de)


### Installation

⚠️ Prerequisites: *Konso account and created bucket* 

In order to use this library, you need reference it in your project.

Add config to `appsettings.json`:
```
"Konso": {
    "ValueTracking": {
        "Endpoint": "https://apis.konso.io",
        "BucketId": "<your bucket id>",
        "ApiKey": "<bucket's access key>"
    }
}
```


It uses `HttpClientFactory`:

```
public void ConfigureServices(IServiceCollection services)
{
    // use httpclient factory
    services.AddHttpClient();
    services.AddSingleton<IValueTrackingClient, ValueTrackingClient>();
}
```

Resolve the service in class constractor:
```
private readonly IValueTrackingClient _valueTrackingService;
public SomeClass(IValueTrackingClient valueTrackingService)
{
    _valueTrackingService = valueTrackingService;
}
```

To track business event add:
```
await _valueTrackingService.CreateAsync(new ValueTrackingCreateRequest() 
{ 
    AppName = "string", // (optional) application name  
    Country = "string", // (optional) 2 letters country code
    Value = double, // (optional) value of the event  
    EventId = int, // id of event by project's enumeration 
    Tags = new List<string>(), // (optional) list of tags associated with the event 
    Browser = "string", // (optional) user agent details
    User = "string", // (optional) user's details
    IP = "string", // (optional) user's ip address
    ReferenceId, // (optional) any related id to the event
    Custom, // (optional) custom field 
    CorrelationId, (optional) id to correlate with metrics and logs
});
```
