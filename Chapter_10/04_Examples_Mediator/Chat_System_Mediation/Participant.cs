using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Chat_System_Mediation
{
    public class Participant
    {
        private readonly IChatMediator mediator;
        public string Name { get; }

        public Participant(string name, IChatMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} received: {message}");
        }
    }
}
