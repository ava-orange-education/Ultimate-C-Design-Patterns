using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._08_Implementation_State
{
    class ThinkingState : IBotState
    {
        public void Handle(ChatbotContext context)
        {
            Console.WriteLine("Processing the input...");
            context.State = new ReplyingState();
        }
    }
}
