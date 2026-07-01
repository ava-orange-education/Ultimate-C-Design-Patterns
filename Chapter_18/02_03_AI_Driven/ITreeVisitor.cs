using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public interface ITreeVisitor
    {
        void Visit(DecisionNode node);
        void Visit(LeafNode node);
    }
}
