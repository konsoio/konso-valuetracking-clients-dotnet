using System.Collections.Generic;

namespace Konso.Clients.ValueTracking.Models
{
    public class KonsoPagedResponseWithAggs<T> : KonsoPagedResponse<T>
    {
        public KonsoPagedResponseWithAggs() { }

        public KonsoPagedResponseWithAggs(KonsoPagedResponse<T> res)
        {
            this.List = res.List;
            this.Total = res.Total;
        }

        public Dictionary<string, List<AggItem>> Aggs { get; set; }
    }
}
