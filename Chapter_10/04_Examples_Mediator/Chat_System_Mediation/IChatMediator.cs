using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Chat_System_Mediation
{
    public interface IChatMediator
    {
        void SendMessage(string message, Participant sender);
    }
}
