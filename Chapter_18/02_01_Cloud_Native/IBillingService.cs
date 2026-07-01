using System;
using System.Threading.Tasks;

namespace Chapter_18._02_01_Cloud_Native
{
    public interface IBillingService
    {
        Task<BillingDto> GetBillingAsync(Guid userId);
    }
}