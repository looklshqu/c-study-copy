using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_unboxing2
{
    class A
    {
        public void PrintA()
        {
            Console.WriteLine("Hello");
        }
    }

    class B : A
    {
        public void PrintB()
        {
            Console.WriteLine("World");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B test1 = new B();
            object obj = test1;
            A test2 = (A)obj;
            test2.PrintA();
            test1.PrintB();
        }
    }
}
