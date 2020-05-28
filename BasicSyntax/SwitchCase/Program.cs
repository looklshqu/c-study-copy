using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nNum = 1;
            //switch (nNum)
            //{
            //    case 1:
            //        Console.WriteLine("1입니다");
            //        break;
            //    case 2:
            //        Console.WriteLine("2입니다");
            //        break;
            //}

            string str = "yes";
            switch (str)
            {
                case "no":
                    Console.WriteLine("no입니다");
                    break;
                case "yes":
                    Console.WriteLine("yes입니다");
                    break;
            }
        }
    }
}
