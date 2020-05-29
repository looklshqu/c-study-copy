using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Parameter
{
    class Program
    {
        //ref
        static double GetData(ref int a, ref double b)
        {
            return ++a * ++b;
        }

        //out
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        static void Main(string[] args)
        {
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);
            Console.WriteLine(ret);

            int c, d;
            bool bret = GetData(10, 20, out c, out d);
            Console.WriteLine(bret);
        }
    }
}
