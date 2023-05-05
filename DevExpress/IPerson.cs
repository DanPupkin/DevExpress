using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    [ConsoleWriting]
    internal interface IPerson
    {
        string Name { get; }
        [NotPrintable] int Age { get; }
    }

    //[NotPrintable]
    //public class Age
    //{
    //    int age { set; get; }
    //    public Age(int age)
    //    { this.age = age; }
    //}
}
