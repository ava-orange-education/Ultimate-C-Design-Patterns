using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._04_Examples_File_System
{
    class FileItem : FileSystemEntry
    {
        public FileItem(string name)
            : base(name)
        { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "- File: " + name);
        }

        public override void Add(FileSystemEntry entry)
        {
            throw new NotImplementedException("Cannot add to a file.");
        }

        public override void Remove(FileSystemEntry entry)
        {
            throw new NotImplementedException("Cannot remove from a file.");
        }
    }
}
