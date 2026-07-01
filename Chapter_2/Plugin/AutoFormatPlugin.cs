using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Plugin
{
    public class AutoFormatPlugin : IPlugin
    {
        public string Name => "Auto Formatter";

        public void Execute()
        {
            Console.WriteLine("Formatting code...");
        }
    }
}
