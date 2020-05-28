using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_2
{
    class MyClass
    {
        string message;

        public MyClass(string Inputmessage)
        {
            message = Inputmessage;
        }

        public void Printmessage()
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass("Happy");
            test.Printmessage();
        }
    }
}
