using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class DecisionNode : TreeNode
    {
        public string Feature { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public override void Accept(ITreeVisitor visitor)
        {
            visitor.Visit(this);
            Left.Accept(visitor);
            Right.Accept(visitor);
        }
    }
}
