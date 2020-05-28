using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_1
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();

            A test1 = test;
            test1.Print();
        }
    }
}
