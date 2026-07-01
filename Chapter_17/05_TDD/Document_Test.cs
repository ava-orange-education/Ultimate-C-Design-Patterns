using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Chapter_17._05_TDD
{
    internal class Document_Test
    {
        [Fact]
        public void Undo_ShouldRevertTextAddition()
        {
            var document = new Document();
            var command = new AddTextCommand(document, "Hello");

            command.Execute();
            command.Undo();

            Assert.Equal("", document.Content);
        }
    }
}
