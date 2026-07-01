using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.FileProcessor
{
    public class FileProcessor
    {
        public virtual string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
