using System;
using System.Collections.Generic;

namespace Chapter_14._04_Examples_File_System
{
    class FolderItem : FileSystemEntry
    {
        private List<FileSystemEntry> entries = new List<FileSystemEntry>();

        public FolderItem(string name)
            : base(name)
        { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "[Folder: " + name + "]");
            foreach (var entry in entries)
            {
                entry.Display(indent + 2);
            }
        }

        public override void Add(FileSystemEntry entry)
        {
            entries.Add(entry);
        }

        public override void Remove(FileSystemEntry entry)
        {
            entries.Remove(entry);
        }
    }
}
