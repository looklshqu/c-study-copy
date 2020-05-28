using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_destructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("A생성자");
        }

        ~A()
        {
            Console.WriteLine("A소멸자");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B생성자");
        }

        ~B()
        {
            Console.WriteLine("B소멸자");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
        }
    }
}
