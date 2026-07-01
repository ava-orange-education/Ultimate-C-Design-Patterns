using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class SummarizeCommand : IPromptCommand
    {
        private readonly string _text;

        public SummarizeCommand(string text)
        {
            _text = text;
        }

        public string Execute()
        {
            return $"Summarize the following:\n{_text}";
        }
    }
}
