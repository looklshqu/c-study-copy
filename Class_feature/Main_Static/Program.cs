using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Static
{
    class Program
    {
        static string message = "Hello World!";
        static void Print()
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
