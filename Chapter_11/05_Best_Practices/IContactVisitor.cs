using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._05_Best_Practices
{
    public interface IContactVisitor
    {
        void VisitLead(Lead lead);
        void VisitClient(Client client);
    }
}
