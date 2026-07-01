using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._04_Examples_File_System
{
    abstract class FileSystemEntry
    {
        protected string name;

        public FileSystemEntry(string name)
        {
            this.name = name;
        }

        public abstract void Display(int indent = 0);
        public abstract void Add(FileSystemEntry entry);
        public abstract void Remove(FileSystemEntry entry);
    }
}
