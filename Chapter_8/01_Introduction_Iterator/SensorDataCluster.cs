using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._01_Introduction_Iterator
{
    class SensorDataCluster : DataCluster
    {
        private readonly ArrayList _dataPoints = new ArrayList();

        public override DataNavigator CreateNavigator()
        {
            return new SensorDataNavigator(this);
        }

        public override int Length
        {
            get { return _dataPoints.Count; }
            protected set { }
        }

        public override object this[int index]
        {
            get { return _dataPoints[index]; }
            set { _dataPoints.Insert(index, value); }
        }
    }
}
