using System;


namespace homework2._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int z, y, m, c;
            int x = int.Parse(Console.ReadLine());
            z = x % 100 / 10 * 100; //сотни
            y = x / 100 * 10;       //десятки
            m = x % 10;              //единицы
            c = z + y + m;
            Console.WriteLine("Полученное число: " + c);

            Console.ReadKey();

        }
    }
}