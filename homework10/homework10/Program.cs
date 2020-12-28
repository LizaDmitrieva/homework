using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            var tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Введите число строк (m)");
                var input = Console.ReadLine();

                if (int.TryParse(input, out m) && m >= 5 && m <= 20)
                {
                    while (true)
                    {
                        Console.WriteLine("Введите число столбцов (n)");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out n) && n >= 5 && n <= 20)
                        {
                            tryAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода\n");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
            }

            var rnd = new Random();

            var table = new int[m, n];

            for (var i = 0; i < table.GetLength(0); i++)
                for (var j = 0; j < table.GetLength(1); j++)
                    table[i, j] = rnd.Next(0, 100);

            PrintTable(table);

            Console.WriteLine();

            GetElementsInDescendingOrder(table);

            Console.WriteLine();

            GetDifferenceOfTheSums(table);

            Console.ReadKey();
        }

        static void PrintTable(int[,] t)
        {
            for (var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }
        }

        static void GetElementsInDescendingOrder(int[,] t) 
        {
            for(int i = 0; i < t.GetLength(0); i++)
            {
                 for (int j = 0; j < t.GetLength(1); j++)
                 {
                    if (j > 0)
                    {
                        if (t[i, j] >= t[i, j-1])
                        {
                            Console.Write($"{t[i, j],2} ");
                        }
                    }
                 }

                 Console.WriteLine();
            }      
        }

        static void GetDifferenceOfTheSums(int[,] t)
        {
            int sEven = 0;
            int sOdd = 0;
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                        sEven = sEven + t[i, j];
                    else
                        sOdd = sOdd + t[i, j];
                }

                Console.WriteLine($"{i+1,2}: {sEven - sOdd, 3} ");

                sEven=0;
                sOdd=0;
            }
        }
    }
}