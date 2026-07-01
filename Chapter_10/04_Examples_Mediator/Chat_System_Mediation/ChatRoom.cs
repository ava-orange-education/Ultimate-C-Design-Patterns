using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Chat_System_Mediation
{
    public class ChatRoom : IChatMediator
    {
        private readonly List<Participant> participants = new List<Participant>();

        public void Register(Participant p)
        {
            participants.Add(p);
        }

        public void SendMessage(string message, Participant sender)
        {
            foreach (var participant in participants)
            {
                if (participant != sender)
                    participant.Receive(message);
            }
        }
    }
}
