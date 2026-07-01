using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Animal
{
    public abstract class Animal
    {
        public string Name { get; set; }

        // Shared behavior
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // Abstract behavior
        public abstract void MakeSound();
    }
}
