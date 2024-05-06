using System;
using System.Collections.Generic;

namespace Konso.Clients.ValueTracking.Models
{
    public class ValueTrackingItem
    {
        public string? Browser { get; set; }
        public string? IP { get; set; }
        public string? Country { get; set; }
        public int EventId { get; set; }

        public string? EventName { get; set; }
        public string? ReferenceId { get; set; }
        public double? Value { get; set; }
        public string? Custom {  get; set; }
        public long TimeStamp { get; set; }
        public List<string> Tags { get; set; }
        public string? AppName { get; set; }
        public string? CorrelationId { get; set; }

        public string? User { get; set; }

        public required string Id { get; set;  }
    }
}
