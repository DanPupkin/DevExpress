using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    public class ConsoleReportig:IReporting
    {
        public string GetReport(object[] objects)
        {
            string s = "";
            string perenos = " | ";
            bool vertical = false;

            foreach (object x in objects)
            {
                
                if (x != null) 
                {
                    
                    
                    Type MyType = x.GetType();
                    var attributes = MyType.GetCustomAttributes(false);
                    
                    //по умолчанию
                    
                    foreach(var attr in attributes)
                    {
                        
                        if (attr is ConsoleWritingAttribute)
                        {
                            vertical =true; break;
                         
                        }
                        else
                        {
                            vertical = false;
                        }
                    }
                    if (vertical) { perenos = "\n"; }
                    else { perenos = " | "; }
                    s += $"ClassName: {MyType.Name} {perenos} Interfaces: {String.Join(", ",MyType?.GetInterfaces().Select(p=> p.Name))} {perenos} Properties: {String.Join(", ", MyType?.GetProperties().Where(p=> IsNotPrint(p)).Select(p => p.Name))}" +
                        $"{perenos} Fields: {String.Join(", ", MyType?.GetFields().Select(p => p.Name))}{"\n"}";
                    //MyType.GetProperties().Select(p => p.Name)
                }
            }

            return s;
        }

        public string GetReport(List<object> objects)
        {
            return GetReport(objects.ToArray());
        }
        static bool IsNotPrint(PropertyInfo prop)
        {
            

            var attributes =  prop.GetCustomAttributes();
            
            
            foreach (var attr in attributes)
            {
               
                return !(attr is NotPrintableAttribute);
            }
            return true;
        }
    }
}
