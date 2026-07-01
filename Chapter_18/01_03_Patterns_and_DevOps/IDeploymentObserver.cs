using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_03_Patterns_and_DevOps
{
    public interface IDeploymentObserver
    {
        void Update(string status);
    }
}
