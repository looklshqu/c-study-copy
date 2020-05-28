using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    interface IA
    {
        void Print();
    }

    class B : IA
    {
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
        }
    }
}
