using Konso.ValueTracking.Clients.Models;
using System.Threading.Tasks;

namespace Konso.ValueTracking.Clients.Interfaces
{
    public interface IValueTrackingService
    {
        Task<bool> CreateAsync(ValueTrackingCreateRequest request, string userAgent);
        Task<PagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request);
        //Task<PagedResponseWithAggs<ValueTrackingItem>> GetWithAggsByAsync(ValueTrackingGetByFilter request);
    }
}
