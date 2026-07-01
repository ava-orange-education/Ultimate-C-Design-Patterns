using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._01_Introduction_Iterator
{
    class ExplorerApp
    {
        public void Run()
        {
            DataCluster cluster = new SensorDataCluster();
            DataNavigator navigator = cluster.CreateNavigator();

            object point = navigator.First();

            while (!navigator.IsFinished())
            {
                Console.WriteLine($"Reading: {point}");
                point = navigator.Next();
            }
        }
    }
}
