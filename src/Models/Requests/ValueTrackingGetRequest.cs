using Konso.ValueTracking.Clients.Models.Enums;
using System.Collections.Generic;

namespace Konso.ValueTracking.Clients.Models
{
    public class ValueTrackingGetRequest
    {
        public int? EventId { get; set; }
        public byte? Type { get; set; }
        public string Query { get; set; }
        public string Custom { get; set; }
        public string ReferenceId { get; set; }
        public long? DateFrom { get; set; }
        public long? DateTo { get; set; }
        public SortingTypes Sort { get; set; }
        public string CorrelationId { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        public string EventName { get; set; }

        public List<string> Tags { get; set; }
    }
}
