using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.NewsPublisherClasses
{
    public interface IObserver
    {
        void Update(string news);
    }
}
