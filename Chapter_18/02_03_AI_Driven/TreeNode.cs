using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public abstract class TreeNode
    {
        public abstract void Accept(ITreeVisitor visitor);
    }
}
