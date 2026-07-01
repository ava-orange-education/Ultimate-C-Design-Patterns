using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.PlayerCharacter
{
    public class PlayerCharacter : IMovable, IDamageable
    {
        public void Move()
        {
            Console.WriteLine("Character moves.");
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"Character takes {damage} damage.");
        }
    }
}
