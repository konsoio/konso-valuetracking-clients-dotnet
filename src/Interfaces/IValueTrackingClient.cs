using Konso.Clients.ValueTracking.Models;
using System.Threading.Tasks;

namespace Konso.Clients.ValueTracking.Interfaces
{
    public interface IValueTrackingClient
    {
        Task<bool> CreateAsync(ValueTrackingCreateRequest request);
        Task<KonsoPagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request);

        Task<KonsoPagedResponseWithAggs<ValueTrackingItem>> GetByWithAggsAsync(ValueTrackingGetRequest request);
    }
}
