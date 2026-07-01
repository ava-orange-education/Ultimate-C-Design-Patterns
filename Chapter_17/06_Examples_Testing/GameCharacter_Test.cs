using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._06_Examples_Testing
{
    internal class GameCharacter_Test
    {
        [Fact]
        public void Character_ShouldActAccordingToState()
        {
            var character = new GameCharacter(new IdleState());
            Assert.Equal("Standing still", character.PerformAction());

            character.SetState(new AttackState());
            Assert.Equal("Swinging sword", character.PerformAction());
        }
    }
}
