using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample1
{
    class Program
    {
        static int[] Get2DigitOddPositiveNumbers(int[] array, int cut)
        {
            return (int[])array
                .Skip(cut - 1)
                .Where(x => x > 9 && x < 100 && x % 2 != 0)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
        }
        static void Main(string[] args)
        {
            int[] mass1 = new int[] { -1000 - 234, -17, 0, 1, 4, 7, 11, 81, 60, 81, 60, 97, 123, 2345, 45678 };

            Console.Write("Введите номер элемента массива: ");
            int cut = int.Parse(Console.ReadLine());

            int[] mass2 = Get2DigitOddPositiveNumbers(mass1, cut);

            if (mass2.Count() > 0)
            {
                foreach (int num in mass2)
                {
                    Console.WriteLine(num.ToString());
                }
            }
            else
                Console.WriteLine("Нет чисел, подходящих под условие ");

            Console.ReadKey();
        }
    }
}
