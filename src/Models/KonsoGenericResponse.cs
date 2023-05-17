
using Konso.Clients.ValueTracking.Models.Requests;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Konso.Clients.ValueTracking.Models
{
    public class KonsoGenericResponse<T> where T : notnull
    {
        /// <summary>
        /// Returns errors in case of failure
        /// </summary>
        public List<ErrorItem> Errors { get; set; }

        /// <summary>
        /// Return validation errors
        /// </summary>
        public List<ValidationErrorItem> ValidationErrors { get; set; }


        public T Result { get; set; }


        [JsonIgnore]
        public bool Succeeded
        {
            get
            {
                var errors = Errors == null;
                if (!errors)
                {
                    errors = (Errors.Count == 0);
                }

                var validationErrors = ValidationErrors == null;
                if (!validationErrors)
                {
                    validationErrors = ValidationErrors.Count == 0;
                }

                return errors && validationErrors;
            }
                 
        }
    }
}
