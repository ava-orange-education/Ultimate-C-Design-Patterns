using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._06_Examples_Testing
{
    public class GameCharacter
    {
        private ICharacterState _state;

        public GameCharacter(ICharacterState initialState)
        {
            _state = initialState;
        }

        public void SetState(ICharacterState state)
        {
            _state = state;
        }

        public string PerformAction()
        {
            return _state.Act();
        }
    }
}
