﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableArray_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for (int i = 0; i < array.Length; i++) // array.Length: 행의 개수
            {
                for (int j = 0; j < array[i].Length; j++) // array[i].Length: 열의 개수
                {
                    Console.Write(array[i][j] + " ");
                }
            }
        }
    }
}
