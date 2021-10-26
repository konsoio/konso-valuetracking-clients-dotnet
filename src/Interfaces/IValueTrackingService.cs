using Konso.ValueTracking.Clients.Models;
using System.Threading.Tasks;

namespace Konso.ValueTracking.Clients.Interfaces
{
    public interface IValueTrackingService
    {
        Task<bool> CreateAsync(ValueTrackingCreateRequest request);
        Task<PagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request);
    }
}
