using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class ApproveLoanCommand : IExplainableCommand
    {
        public string Execute() => "Loan approved";

        public string Explain() => "User credit score > 700 and income > threshold";
    }
}
