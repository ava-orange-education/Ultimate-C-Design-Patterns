using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class ApproveDocumentCommand : ICommand
    {
        private readonly Guid _documentId;

        public ApproveDocumentCommand(Guid documentId)
        {
            _documentId = documentId;
        }

        public async Task ExecuteAsync()
        {
            Console.WriteLine($"Document {_documentId} approved.");
        }
    }
}
