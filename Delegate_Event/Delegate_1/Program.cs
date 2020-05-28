using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1
{
    delegate void DelegateType(string str);

    class A
    { 
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            DelegateType DelMethod1 = new DelegateType(test.Print); // c# 1.0이상에서 사용
            DelMethod1("Hello World");

            DelegateType DelMethod2 = test.Print;
            DelMethod2("Hello World"); 
        }
    }
}
