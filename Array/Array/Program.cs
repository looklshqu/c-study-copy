using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write('\n');

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write('\n');

            foreach (int m in array)
            {
                Console.Write("{0} ", m);
            }
            Console.Write('\n');

            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (string str in Days)
            {
                Console.Write(str + " ");
            }
        }
    }
}
