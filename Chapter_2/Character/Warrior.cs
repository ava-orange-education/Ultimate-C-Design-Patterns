using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Character
{
    public class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Swinging sword!");
        }
    }
}
