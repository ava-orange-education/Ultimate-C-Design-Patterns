using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._08_Implementation_State
{
    class ReplyingState : IBotState
    {
        public void Handle(ChatbotContext context)
        {
            Console.WriteLine("Here's your answer!");
            context.State = new ListeningState(); // Loop back to start
        }
    }
}
