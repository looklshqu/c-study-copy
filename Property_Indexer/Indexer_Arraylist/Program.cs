using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Arraylist
{
    class Program
    {
        class A
        {
            ArrayList List = new ArrayList();
            List<string> ll = new List<string>();
            
            public string this[int index]
            {
                get
                {
                    if (index >=0 && index < List.Count)
                    {
                        return (string)List[index];
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    if (index >= 0 && index < List.Count)
                    {
                        List[index] = value;
                    }else if(index == List.Count){
                        List.Add(value);
                    }

                }
            }

            public void Print()
            {
                List.Add("asfd");
                List.Add(123123);
                foreach (string m in List)
                {
                    Console.WriteLine(m);
                }
            }
        }

        static void Main(string[] args)
        {
            A test = new A();
            test[0] = "A";
            test[1] = "B";
            test[2] = "C";
            test[3] = "D";
            test[4] = "E";

            test.Print();
            test[1] = "Hello World!";
            test.Print();
        }
    }
}
