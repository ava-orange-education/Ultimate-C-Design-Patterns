using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_01_Cloud_Native
{
    public class DashboardFacade
    {
        private readonly IUserService _userService;
        private readonly IBillingService _billingService;
        private readonly IActivityService _activityService;

        public DashboardFacade(IUserService userService, IBillingService billingService, IActivityService activityService)
        {
            _userService = userService;
            _billingService = billingService;
            _activityService = activityService;
        }

        public async Task<DashboardDto> GetDashboardAsync(Guid userId)
        {
            UserDto user = await _userService.GetUserAsync(userId);
            BillingDto billing = await _billingService.GetBillingAsync(userId);
            ActivityDto activity = await _activityService.GetRecentActivityAsync(userId);

            return new DashboardDto(user, billing, activity);
        }
    }
}
