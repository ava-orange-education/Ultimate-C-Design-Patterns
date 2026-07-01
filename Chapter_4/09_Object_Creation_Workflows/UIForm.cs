using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._09_Object_Creation_Workflows
{
    public class UIForm
    {
        public string Title { get; }
        public List<string> Fields { get; }
        public bool HasSubmitButton { get; }

        private UIForm(Builder builder)
        {
            Title = builder.Title;
            Fields = builder.Fields;
            HasSubmitButton = builder.HasSubmitButton;
        }

        public class Builder
        {
            public string Title;
            public List<string> Fields = new List<string>();
            public bool HasSubmitButton;

            public Builder WithTitle(string title) { Title = title; return this; }
            public Builder AddField(string field) { Fields.Add(field); return this; }
            public Builder WithSubmitButton(bool hasButton) { HasSubmitButton = hasButton; return this; }

            public UIForm Build() => new UIForm(this);
        }
    }
}
