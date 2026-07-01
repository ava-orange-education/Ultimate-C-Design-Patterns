using System.Collections.Generic;

namespace Chapter_17._05_TDD
{
    public class Document
    {
        public string Content { get; private set; } = "";

        public void AddText(string text)
        {
            Content += text;
        }

        public void RemoveText(string text)
        {
            if (Content.EndsWith(text))
            {
                Content = Content.Substring(0, Content.Length - text.Length);
            }
        }
    }
}