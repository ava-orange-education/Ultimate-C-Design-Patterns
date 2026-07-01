using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.Service
{
    public class ServiceFactory
    {
        public static IService CreateService() => new EmailService();
    }
}
