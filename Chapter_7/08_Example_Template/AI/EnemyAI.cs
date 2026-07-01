using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template
{
    abstract class EnemyAI
    {
        public void TakeTurn()
        {
            ScanArea();
            Move();
            Act();
        }

        protected abstract void ScanArea();
        protected abstract void Move();
        protected abstract void Act();
    }
}
