using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class RunningState : IQuantumState
    {
        public void Handle(QuantumJob job)
        {
            Console.WriteLine("Job is running. Awaiting results...");
            job.SetState(new CompletedState());
        }
    }
}
