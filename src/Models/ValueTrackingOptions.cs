using System.ComponentModel.DataAnnotations;

namespace Konso.Clients.ValueTracking.Models
{
    public sealed class ValueTrackingOptions
    {
        [Required, Url]
        public string Endpoint { get; set; }

        [Required]
        public string BucketId { get; set; }

        [Required]
        public string ApiKey { get; set; }

        [Required]
        public string Protocol { get; set; } // grpc, rest

        [Required]
        public string AppName { get; set; }

    }
}
