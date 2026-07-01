using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class QuantumJob
    {
        private IQuantumState _state;

        public QuantumJob()
        {
            _state = new QueuedState();
        }

        public void SetState(IQuantumState state)
        {
            _state = state;
        }

        public void Execute()
        {
            _state.Handle(this);
        }
    }
}
