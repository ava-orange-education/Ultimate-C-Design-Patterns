using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._02_Common_Antipatterns
{
    public interface IConfigRepository
    {
        string GetSetting(string key);
    }
}
