using Chapter_17._04_Integration_testing;
using System;

namespace Chapter_17._05_TDD
{
    public class AddTextCommand : ICommand
    {
        private readonly Document _document;
        private readonly string _text;

        public AddTextCommand(Document document, string text)
        {
            _document = document;
            _text = text;
        }

        public void Execute()
        {
            _document.AddText(_text);
        }

        public void Undo()
        {
            _document.RemoveText(_text);
        }
    }
}