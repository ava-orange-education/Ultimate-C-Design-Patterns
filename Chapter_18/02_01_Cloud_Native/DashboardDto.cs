namespace Chapter_18._02_01_Cloud_Native
{
    public class DashboardDto
    {
        private object user;
        private object billing;
        private object activity;

        public DashboardDto(object user, object billing, object activity)
        {
            this.user = user;
            this.billing = billing;
            this.activity = activity;
        }
    }
}