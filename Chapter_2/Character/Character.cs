using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Character
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public abstract void Attack();
    }
}
