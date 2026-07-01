using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class MLModel
    {
        public ModelArchitecture Architecture { get; }
        public double[] Weights { get; }

        public MLModel(ModelArchitecture architecture, double[] weights)
        {
            Architecture = architecture;
            Weights = weights;
        }
    }
}
