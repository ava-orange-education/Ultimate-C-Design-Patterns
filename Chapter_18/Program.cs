using Chapter_18._01_03_Patterns_and_DevOps;
using Chapter_18._02_01_Cloud_Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18
{
    internal class Program
    {
        private Mediator _mediator;
        private string email;
        private string password;

        static void Main(string[] args)
        {
            //to the 01_03
            var prodConfig = new DeploymentConfigBuilder()
    .SetEnvironment("Production")
    .SetLimits(4, 8192)
    .AddFeatureFlag("EnableCaching", "true")
    .Build();

            //to the 01_03
            var monitor = new DeploymentMonitor();
            monitor.Attach(new EmailNotifier());
            monitor.Attach(new SlackNotifier());
            monitor.StartDeployment();

            
        }

    }
}
