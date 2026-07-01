using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public abstract class AgentHandler
    {
        protected AgentHandler Next;

        public void SetNext(AgentHandler next) => Next = next;

        public abstract string Handle(string input);
    }

    public class TranslationAgent : AgentHandler
    {
        public override string Handle(string input)
        {
            if (input.Contains("translate"))
                return "Translated text";
            return Next?.Handle(input);
        }
    }
}
