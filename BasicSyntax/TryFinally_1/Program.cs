using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFinally_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                Console.WriteLine("try문에서 예외 발생시킵니다");
                array[3] = 10;
            }
            finally
            {
                Console.WriteLine("finally 구문입니다");
            }
            foreach (var m in array)
            {
                Console.WriteLine("{0}", m);
            }
        }
    }
}
