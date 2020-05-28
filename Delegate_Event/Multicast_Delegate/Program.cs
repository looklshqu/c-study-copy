﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    delegate void DelegateType();

    class A
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }

        public void PrintB()
        {
            Console.WriteLine("PrintB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelFunc = Test.PrintA;
            DelFunc += Test.PrintB;
            DelFunc();
            DelFunc -= Test.PrintB;
            DelFunc();
        }
    }
}
