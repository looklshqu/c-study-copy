using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOfArray2
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 배열복사
            int[] nArray1 = { 1, 2, 3, 4 };
            int[] nCloneArray = (int[])nArray1.Clone();

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();

            foreach (int m in nCloneArray)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();

            string[] Days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] DaysClone = (string[])Days.Clone();
            foreach (string m in DaysClone)
            {
                Console.Write("{0} ", m);
            }
        }
        #endregion 배열복사
    }
}
