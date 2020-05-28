using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Program
    {
        abstract class A
        {
            int number = 3;
            public abstract void Print();
            public void PrintNumber()
            {
                Console.WriteLine(number);
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("abstract class");
            }
        }
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            test.PrintNumber();
        }
    }
}
