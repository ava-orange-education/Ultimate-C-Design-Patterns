using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10_Examples_Notification_Systems
{
    public class UserSignupService
    {
        private readonly INotifier _notifier;

        public UserSignupService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void RegisterNewUser(string username)
        {
            Console.WriteLine($"User '{username}' registered.");
            _notifier.NotifyAll($"Welcome, {username}!");
        }
    }
}
