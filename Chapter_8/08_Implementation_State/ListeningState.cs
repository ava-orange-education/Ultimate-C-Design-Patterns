using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._08_Implementation_State
{
    class ListeningState : IBotState
    {
        public void Handle(ChatbotContext context)
        {
            Console.WriteLine("Listening... Waiting for user input.");
            context.State = new ThinkingState();
        }
    }
}
