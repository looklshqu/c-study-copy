using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_unboxing
{
    struct DATA
    {
        public string name;
        public int number;

        public DATA(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            object obj = num;
            int result = (int)obj;
            Console.WriteLine("{0} {1}", num, result);

            // -----------------------------------------

            DATA test = new DATA("test", 3);
            object obj1 = test;
            DATA test1 = (DATA)obj1;
            Console.WriteLine("{0}, {1}", test1.name, test.number);
        }
    }
}
