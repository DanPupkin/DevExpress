using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    public class ConsoleReportig:IReporting
    {
        public string GetReport(object[] objects, bool vertical)
        {
            string s = "";
            string perenos = " | ";
            if (vertical)
            {
                perenos = "\n";
            }
            foreach(object x in objects)
            { 
                if (x != null) 
                { 
                Type MyType = x.GetType();
                    s += $"ClassName: {MyType.Name} {perenos} Interfaces: {MyType?.GetInterfaces().ToString()} {perenos} Properties: {String.Join(", ", MyType?.GetProperties().Select(p => p.Name))}" +
                        $"{perenos} Fields: {String.Join(", ", MyType?.GetFields().Select(p => p.Name))}{"\n"}";
                    //MyType.GetProperties().Select(p => p.Name)
                }
            }

            return s;
        }

        public string GetReport(List<object> objects, bool vertical)
        {
            return GetReport(objects.ToArray(), vertical);
        }
    }
}
