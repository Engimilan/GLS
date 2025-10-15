using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glsfutar
{
    internal class Program
    {
        List<Data> datas = new List<Data>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("GLS.txt");

            while (sr.Peek() >-1)
            {
                Data data = new Data(sr.ReadLine());
                datas.Add(data);
            }
            sr.Close();

            Console.WriteLine($"Az autó használatában töltött napjainak száma: {datas.Count}");
        }
    }
}
