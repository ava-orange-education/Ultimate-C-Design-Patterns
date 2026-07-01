using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ComposableLion
{
    public class Lion1 : IMovable, IEater, IHunter
    {
        public void Move() => Console.WriteLine("Lion moves");
        public void Eat() => Console.WriteLine("Lion eats");
        public void Hunt() => Console.WriteLine("Lion hunts");
    }
}
