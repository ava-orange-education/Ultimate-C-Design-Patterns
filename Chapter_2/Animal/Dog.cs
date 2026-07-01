using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Animal
{
    public class Dog : Animal1
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }
}
