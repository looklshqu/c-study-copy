﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotBool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bFlag = false;
            Console.WriteLine("{0} {1} {2}", !bFlag, !true, !false); 
        }
    }
}
