﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_feat
{
    class MyClass
    {
        public int number;
        public MyClass(int number)
        {
            this.number = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass(12);
            Console.WriteLine(MyTest.number);
        }
    }
}
