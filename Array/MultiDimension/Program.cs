using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2];
            array1[0, 0] = 1;
            array1[0, 1] = 2;
            array1[1, 0] = 3;
            array1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array1[i, j] + " ");
                }
            }
            Console.Write('\n');

            int[,] array2 = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
            }
            Console.Write('\n');
            string[,,] array3 =
            {
                {{"ab","cd"}, {"ef","gh"} },
                {{"ij","kl"},{"mn","op"} }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(array3[i, j, k] + " ");
                    }
                }
            }
        }
    }
}
