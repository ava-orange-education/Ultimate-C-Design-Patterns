using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._01_Introduction_Iterator
{
    class SensorDataNavigator : DataNavigator
    {
        private readonly DataCluster _cluster;
        private int _position;

        public SensorDataNavigator(DataCluster cluster)
        {
            _cluster = cluster;
            _position = 0;
        }

        public override object First()
        {
            return _cluster[0];
        }

        public override object Next()
        {
            object nextItem = null;
            _position++;

            if (_position < _cluster.Length)
            {
                nextItem = _cluster[_position];
            }

            return nextItem;
        }

        public override object CurrentItem()
        {
            return _cluster[_position];
        }

        public override bool IsFinished()
        {
            return _position >= _cluster.Length;
        }
    }
}
