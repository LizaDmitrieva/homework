using System;

namespace homework8._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n");
            var n = int.Parse(Console.ReadLine());

            if (1000 < n)
            {
                Console.Write("Полученное значение: ");
                MakeNewNumber(n);
            }
            else 
            {
                Console.WriteLine("Введенное значение некорректно!");
            }

            Console.ReadKey();
        }

        static void MakeNewNumber(int n)
        {
            if (n == 0) return;
            var result = n % 10;
            MakeNewNumber(n / 10);

            if (n % 2 != 0)
            {
                Console.Write(result);
            }
        }
    }
}
