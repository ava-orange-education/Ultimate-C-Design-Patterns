using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_11._05_Best_Practices
{
    public interface IReportVisitor
    {
        void VisitContact(Contact contact);
        void VisitProject(Project project);
        void VisitComment(Comment comment);
    }

    public class DefaultReportVisitor : IReportVisitor
    {
        public void VisitContact(Contact contact) { /*...*/ }
        public void VisitProject(Project project) { /*...*/ }

        public void VisitComment(Comment comment)
        {
            Console.WriteLine("Default comment handling.");
        }
    }
}
