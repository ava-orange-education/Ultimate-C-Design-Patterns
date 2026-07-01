using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._07_Implementation_Template.ReportGenerator
{
    class DialogueScriptReport : ReportGenerator
    {
        protected override string FetchData()
        {
            Console.WriteLine("Loading NPC dialogue tree from story module...");
            return "NPC:Guard\n1: Halt! Who goes there?\n2: You may pass.\n";
        }

        protected override string FormatData(string rawData)
        {
            Console.WriteLine("Formatting script for game engine syntax...");
            return $"[SCRIPT_START]\n{rawData}\n[SCRIPT_END]";
        }

        protected override void Export(string formattedContent)
        {
            Console.WriteLine("Exporting dialogue to: /scripts/guard_dialogue.dlg");
            Console.WriteLine($"Script Output:\n{formattedContent}\n");
        }
    }
}
