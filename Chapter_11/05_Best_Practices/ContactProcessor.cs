using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._05_Best_Practices
{
    public class ContactProcessor
    {
        private readonly IContactVisitor visitor;

        public ContactProcessor(IContactVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void Process(IContact contact)
        {
            contact.Accept(visitor);
        }
    }
}
