using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Date
    {
        int Day; // 접근한정자 private가 생략된거임
        public int Year, Month;

        void Print()
        {
            Console.WriteLine("{0} {1} {2}", Year, Month, Day);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date Test = new Date();
        }
    }
}
