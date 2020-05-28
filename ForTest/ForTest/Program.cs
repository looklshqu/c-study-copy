using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            for (int num = 0; num < 1000; num++)
            {
                
                int k, e, m = num;
                Random rnd = new Random();
                k = rnd.Next(0, 100); // 국어점수
                e = rnd.Next(0, 100); // 영어점수
                m = rnd.Next(0, 100); // 수학점수

                Dictionary<string, int> dict = new Dictionary<string, int>();
                string[] subject = { "Kor", "Eng", "Math" };
                for (int j = 0; j < 1000; j++)
                {
                    dict.Add(subject[0], k);
                    dict.Add(subject[1], e);
                    dict.Add(subject[2], m);
                }
            }
        }
    }
}
