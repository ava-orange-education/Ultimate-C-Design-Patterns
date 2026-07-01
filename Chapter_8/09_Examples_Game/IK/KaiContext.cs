using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    class KaiContext
    {
        public IKaiState State { get; set; }
        public int Energy { get; set; } = 100;
        private readonly Random _rand = new Random();

        public KaiContext(IKaiState initialState)
        {
            this.State = initialState;
        }

        public void Update()
        {
            State.Handle(this);
        }

        public bool IsEnemyNearby()
        {
            return _rand.NextDouble() < 0.3;
        }

        public bool ShouldRun()
        {
            return _rand.NextDouble() < 0.6;
        }

        public bool ShouldJump()
        {
            return _rand.NextDouble() < 0.5;
        }
    }

}
