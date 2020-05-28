using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_access
{
    class A
    {
        private void PrintPrivate()
        {
            Console.WriteLine("private");
        }

        protected void PrintProtected()
        {
            Console.WriteLine("Protected");
        }

        public void PrintPublic()
        {
            Console.WriteLine("public");
        }
    }

    class B : A
    {
        public void Print()
        {
            //PrintPrivate();
            PrintProtected();
            PrintPublic();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintPublic();
        }
    }
}
