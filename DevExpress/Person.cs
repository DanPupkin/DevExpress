﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    [ConsoleWriting]
    internal class Person:IPerson
    {

        public string Name { get; set; }
        [NotPrintable] public int Age { get; set; }
    }
}
