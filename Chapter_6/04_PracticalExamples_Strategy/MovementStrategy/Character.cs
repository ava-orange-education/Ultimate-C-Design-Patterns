using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.MovementStrategy
{
    public class Character
    {
        private IMovementStrategy _movement;
        public string Name { get; set; }

        public Character(string name, IMovementStrategy movement)
        {
            Name = name;
            _movement = movement;
        }

        public void SetMovementStrategy(IMovementStrategy movement)
        {
            _movement = movement;
        }

        public void Move()
        {
            _movement.Move(Name);
        }
    }
}
