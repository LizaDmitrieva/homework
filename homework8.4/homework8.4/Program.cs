using System;

namespace homework8._4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число k: ");
            var k = int.Parse(Console.ReadLine());

            int mult = 1;
            int x = 1;

            if (1 <= k && k <= 8 && 0 < n)
            {
                while (1 < n)
                {
                    x = n % 10;

                    if (k < x)
                    {
                        mult = mult * x;
                    }
                    n = n / 10;
                }

                Console.WriteLine("Произведение цифр равно " + mult.ToString());
            }
            else 
            {
                Console.WriteLine("Введенные значения некорректны!");
            }

            Console.ReadKey();
        }
    }
}
