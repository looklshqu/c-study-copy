using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
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
            A test1 = new B();
            test1.Print();

            // cast형을 이용한 참조
            B test2 = new B();
            A test3 = (A)test2;
            test3.Print();
        }
    }
}
