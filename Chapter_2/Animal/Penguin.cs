using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Animal
{
    public class Penguin : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Squawk!");
        }
    }
}
