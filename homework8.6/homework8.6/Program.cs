using System;

namespace homework8._6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число a ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b ");
            var b = int.Parse(Console.ReadLine());

            int s = 0;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            s = s + j;
                        }
                    }
                }

                Console.WriteLine("Сумма делителей равна " + s.ToString());
            }
            else
            {
                Console.WriteLine("Значения b должно быть больше значения a!");
            }

            Console.ReadKey();
        }
    }
}
