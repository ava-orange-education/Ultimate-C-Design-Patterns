using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.UI_Design
{
    internal class Dynamic_UI_Factories
    {
    }

    public interface IDashboardFactory
    {
        IChart CreateChart();
        IReportViewer CreateReportViewer();
    }

    public class FinanceDashboardFactory : IDashboardFactory
    {
        public IChart CreateChart() => new FinanceChart();
        public IReportViewer CreateReportViewer() => new FinanceReportViewer();
    }

    public class HRDashboardFactory : IDashboardFactory
    {
        public IChart CreateChart() => new HRChart();
        public IReportViewer CreateReportViewer() => new HRReportViewer();
    }
}
