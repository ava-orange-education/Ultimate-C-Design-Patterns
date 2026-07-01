using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.FileProcessor
{
    public class SecureFileProcessor : FileProcessor
    {
        public override string ReadFile(string filePath)
        {
            throw new UnauthorizedAccessException("Access denied!");
        }
    }
}
