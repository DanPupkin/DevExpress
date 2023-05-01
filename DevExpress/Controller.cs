using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    public class Controller
    {
        IReporting Reporting { get; set; } = new ConsoleReportig();
        public string Name { get; set; } = "Cont";
        public Controller() 
        
        {
            Reporting = new ConsoleReportig();
        
        }
        public string GetReport(object[] objects, bool vertical)
        {
            return Reporting.GetReport(objects, vertical);
        }
        public string GetReport(List<object> objects, bool vertical)
        {
            return Reporting.GetReport(objects, vertical);
        }


    }
}
