using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    internal interface IReporting
    {
        public string GetReport(object[] objects);
        public string GetReport(List<object> objects);
    }
}
