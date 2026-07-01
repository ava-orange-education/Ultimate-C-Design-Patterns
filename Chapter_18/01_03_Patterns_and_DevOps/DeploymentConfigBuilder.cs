using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_03_Patterns_and_DevOps
{
    public class DeploymentConfigBuilder
    {
        private readonly DeploymentConfig _config = new DeploymentConfig();

        public DeploymentConfigBuilder SetEnvironment(string env)
        {
            _config.Environment = env;
            return this;
        }

        public DeploymentConfigBuilder SetLimits(int cpu, int memory)
        {
            _config.CpuLimit = cpu;
            _config.MemoryLimit = memory;
            return this;
        }

        public DeploymentConfigBuilder AddFeatureFlag(string key, string value)
        {
            if (_config.FeatureFlags == null)
                _config.FeatureFlags = new Dictionary<string, string>();

            _config.FeatureFlags[key] = value;
            return this;
        }

        public DeploymentConfig Build() => _config;
    }
}
