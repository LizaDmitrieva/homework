using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SamplingOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("random_numbers.txt"))
            {
                string st;
                List<int> numb = new List<int>();

                Console.WriteLine("Обрабатываю данные!");

                while ((st = sr.ReadLine()) != null)
                {
                    string[] s = st.Split(' ');     
                    
                    foreach (string ch in s)
                    {
                        numb.Add(int.Parse(ch));

                        Console.Write(".");
                    }                    
                }

                Console.WriteLine();

                numb.Sort();

                Console.WriteLine();
                Console.WriteLine("Обработка завершена!");
                Console.WriteLine();
                Console.WriteLine("Всего вариант: " + numb.Count().ToString());
                Console.WriteLine();

                foreach (int i in numb)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
