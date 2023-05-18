
# Konso ValueTracking .Net Client

The Konso Value Tracking .NET Client Library is a powerful tool designed to help businesses capture and track valuable business events in their applications. With this library, developers can easily integrate value tracking capabilities into their .NET applications, allowing them to gain valuable insights into user behavior, product usage, and overall business performance.

## Features

**Event Capture**: The library provides a simple and intuitive API for capturing business events in your application. Whether it's a user action, a transaction, or any other significant event, the library makes it easy to record and track these events for analysis.

**Flexible Tracking**: Konso Value Tracking supports flexible event tracking, allowing you to define custom event properties and parameters that are relevant to your business. This flexibility enables you to capture and analyze the specific data points that matter most to your organization.

**Real-time Analytics**: By integrating the Konso Value Tracking library, you can gain access to real-time analytics and reporting. Monitor and visualize event data in a comprehensive dashboard, empowering you to make data-driven decisions and optimize your business processes.

**Data Privacy and Security**: Konso prioritizes data privacy and security. The library provides robust mechanisms to ensure the protection of sensitive customer data, adhering to industry-standard security practices and compliance regulations.

## Getting Started

To start using the Konso Value Tracking .NET Client Library, simply follow the steps below:

⚠️ Prerequisites: *Konso account and created bucket*

### Install the library via NuGet or by manually referencing the assembly in your project

```

NuGet\Install-Package Konso.Clients.ValueTracking -Version 1.2.1

```

### Initialize the library with your API credentials and configuration settings

Add config to `appsettings.json`:

```json
"Konso": {
    "ValueTracking": {
        "Endpoint": "https://apis.konso.io",
        "BucketId": "<your bucket id>",
        "ApiKey": "<bucket's access key>"
    }
}
```

in `startup.cs`:

```csharp
builder.Services.AddKonsoValueTracking(options =>
{
    options.Endpoint = builder.Configuration.GetValue<string>("Konso:ValueTracking:Endpoint");
    options.BucketId = builder.Configuration.GetValue<string>("Konso:ValueTracking:BucketId");
    options.ApiKey = builder.Configuration.GetValue<string>("Konso:ValueTracking:ApiKey");
});
```

### Begin capturing business events using the provided API methods, specifying relevant event properties and parameters

Resolve the service in class constructor:

```csharp
private readonly IValueTrackingClient _valueTrackingService;
public SomeClass(IValueTrackingClient valueTrackingService)
{
    _valueTrackingService = valueTrackingService;
}
```

To track business event add:

```csharp
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

### Leverage the real-time analytics and reporting features to gain actionable insights from your captured event data with [Konso](https://app.konso.io)

For detailed documentation and additional examples, refer to the [Konso API Reference](https://docs.konso.io/).

## Requirements

- .NET 5 or higher
- Konso BucketId and API key

## Support and Feedback

If you encounter any issues or have any questions or feedback, please reach out to our support team at <support at konso.io>. We are here to assist you and continually improve the Konso Value Tracking .NET Client Library to meet your business needs.

✅ Developed / Developing by [InDevLabs](https://indevlabs.de)
