using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_03_Patterns_and_DevOps
{
    public static class ConfigFactory
    {
        public static DeploymentConfig Create(string env)
        {
            var builder = new DeploymentConfigBuilder();

            switch (env)
            {
                case "Dev":
                    return builder.SetEnvironment("Dev").SetLimits(1, 1024).Build();
                case "Staging":
                    return builder.SetEnvironment("Staging").SetLimits(2, 4096).Build();
                case "Production":
                    return builder.SetEnvironment("Production").SetLimits(4, 8192).Build();
                default:
                    throw new ArgumentException("Unknown environment");
            }
        }
    }
}
