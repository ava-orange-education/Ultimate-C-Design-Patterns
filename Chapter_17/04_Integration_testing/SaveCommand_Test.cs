using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._04_Integration_testing
{
    internal class SaveCommand_Test
    {
        [Fact]
        public void Mediator_ShouldExecuteRegisteredCommand()
        {
            var command = new SaveCommand();
            var mediator = new Mediator();
            mediator.Register("save", command);

            mediator.Send("save");

            Assert.True(command.WasExecuted);
        }
    }
}
