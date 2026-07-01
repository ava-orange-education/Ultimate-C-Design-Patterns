using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Creature
{
    public class Lion : Carnivore
    {
        public override void Move() => Console.WriteLine("Lion moves");
        public override void Eat() => Console.WriteLine("Lion eats");
        public override void Hunt() => Console.WriteLine("Lion hunts");
    }
}
