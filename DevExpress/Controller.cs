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
        public string GetReport(object[] objects)
        {
            return Reporting.GetReport(objects);
        }
        public string GetReport(List<object> objects)
        {
            return Reporting.GetReport(objects);
        }


    }
}
