using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int m;
            int m = 0;
            try
            {
                m = 12;
                Console.WriteLine("try문 출력: {0}", m);
            }
            catch 
            {
                Console.WriteLine("예외 발생");
            }
            Console.WriteLine("try문 밖에서 변수 출력 {0}", m);
        }
    }
}
