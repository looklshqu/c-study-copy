using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("소멸자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass Test1 = new MyClass();
        }
    }
}
