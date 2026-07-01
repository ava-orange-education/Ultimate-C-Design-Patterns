using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Plugin
{
    public class SpellCheckPlugin : IPlugin
    {
        public string Name => "Spell Checker";

        public void Execute()
        {
            Console.WriteLine("Running spell check...");
        }
    }
}
