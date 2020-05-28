using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            if (nValue is float)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환안됨");
            }
            if (nValue is object) // boxing 호환
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안됨");
            }

            object obj = nValue; // unboxing 호환
            if (obj is int)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안됨");
            }
        }
    }
}
