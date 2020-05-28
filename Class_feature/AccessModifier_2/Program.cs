using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_2
{
    class Date
    {
        public int Year;
        protected int Month;
        int Day;

        void Print() // private가 생략되어있음
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
