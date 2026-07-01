using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class LeafNode : TreeNode
    {
        public string Label { get; set; }

        public override void Accept(ITreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
