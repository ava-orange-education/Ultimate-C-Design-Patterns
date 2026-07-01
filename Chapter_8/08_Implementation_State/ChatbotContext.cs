using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._08_Implementation_State
{
    class ChatbotContext
    {
        public IBotState State { get; set; }

        public ChatbotContext(IBotState initialState)
        {
            this.State = initialState;
        }

        public void Receive()
        {
            State.Handle(this);
        }
    }
}
