using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_set
{
    [Serializable]
    struct Data
    {
        public int var1;
        public float var2;
        public string str1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data[] Data = new Data[2];
            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5F;
            Data[1].str1 = "Test2";

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            Data[] ResultData;

            using(FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (Data[])bf2.Deserialize(fs2);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str1);
            }
        }
    }
}
