using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_03_Patterns_and_DevOps
{
    public class DeploymentConfig
    {
        public string Environment { get; set; }
        public int CpuLimit { get; set; }
        public int MemoryLimit { get; set; }
        public Dictionary<string, string> FeatureFlags { get; set; }
    }
}
