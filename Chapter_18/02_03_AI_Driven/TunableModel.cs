using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class TunableModel : MLModel, ICloneableModel
    {
        public TunableModel(ModelArchitecture architecture, double[] weights)
            : base(architecture, weights) { }

        public MLModel Clone()
        {
            var clonedWeights = (double[])Weights.Clone();
            return new TunableModel(Architecture, clonedWeights);
        }
    }
}
