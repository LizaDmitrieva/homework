using System;

namespace homework8._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите вещественное число a: ");
            var a = double.Parse(Console.ReadLine());

            int n = 1;

            if (1 < a && a < 2)
            {
                while (a <= (1 + (1.0 / n)))
                {
                    n++;
                }

                Console.WriteLine("1 + 1/" + n.ToString());
            }
            else 
            {
                Console.WriteLine("Введенное значение некорректно");
            }

            Console.ReadKey();
        }
    }
}
