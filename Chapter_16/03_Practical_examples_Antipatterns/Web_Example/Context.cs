using Chapter_16._02_Common_Antipatterns;
using System;
using System.Collections.Generic;

namespace Chapter_16._03_Practical_examples_Antipatterns.Web_Example
{
    internal class Context
    {
        public List<User> Users { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}