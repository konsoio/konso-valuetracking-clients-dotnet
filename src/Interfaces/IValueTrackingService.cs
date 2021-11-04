using Konso.Clients.ValueTracking.Models;
using System.Threading.Tasks;

namespace Konso.Clients.ValueTracking.Interfaces
{
    public interface IValueTrackingService
    {
        Task<bool> CreateAsync(ValueTrackingCreateRequest request);
        Task<PagedResponse<ValueTrackingItem>> GetByAsync(ValueTrackingGetRequest request);
    }
}
