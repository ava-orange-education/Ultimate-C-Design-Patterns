using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.PrtinterClasses
{
    public class PrinterAdapter : IModernPrinter
    {
        private readonly LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }

        public void Print()
        {
            _legacyPrinter.PrintLegacy();
        }
    }
}
