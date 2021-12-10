using Konso.Clients.ValueTracking.Models;
using System.Threading.Tasks;

namespace Konso.Clients.ValueTracking.Interfaces
{
    public interface IValueTrackingClient
    {
        Task<bool> CreateAsync(ValueTrackingCreateRequest request);
        Task<PagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request);

        Task<PagedResponseWithAggs<ValueTrackingItem>> GetByWithAggsAsync(ValueTrackingGetRequest request);
    }
}
