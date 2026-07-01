using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.FileProcessor
{
    public class SecureFileProcessor1 : FileProcessor
    {
        public bool HasAccess { get; set; } = false;

        public override string ReadFile(string filePath)
        {
            if (!HasAccess)
            {
                return "Access Denied: Restricted File";
            }

            return base.ReadFile(filePath);
        }
    }
}
