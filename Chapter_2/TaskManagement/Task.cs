using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.TaskManagement
{
    public abstract class Task
    {
        public string Title { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Title} started.");
        }

        public abstract void Execute();
    }
}
