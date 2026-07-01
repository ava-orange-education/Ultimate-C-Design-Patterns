using Chapter_6._04_PracticalExamples_Strategy.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.AttackStrategy
{
    public class BattleUnit
    {
        private IMovementStrategy _movement;
        private IAttackStrategy _attack;
        public string Name { get; set; }

        public BattleUnit(string name, IMovementStrategy movement, IAttackStrategy attack)
        {
            Name = name;
            _movement = movement;
            _attack = attack;
        }

        public void SetMovementStrategy(IMovementStrategy movement)
        {
            _movement = movement;
        }

        public void SetAttackStrategy(IAttackStrategy attack)
        {
            _attack = attack;
        }

        public void Move() => _movement.Move(Name);
        public void Attack() => _attack.Attack(Name);
    }
}
