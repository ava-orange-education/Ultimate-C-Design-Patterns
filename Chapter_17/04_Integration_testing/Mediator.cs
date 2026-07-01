using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._04_Integration_testing
{
    public class Mediator
    {
        private readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        public void Register(string key, ICommand command)
        {
            _commands[key] = command;
        }

        public void Send(string key)
        {
            if (_commands.TryGetValue(key, out var command))
            {
                command.Execute();
            }
        }
    }
}
