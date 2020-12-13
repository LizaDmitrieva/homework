using System;

namespace homework8._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число административных единиц:");
            var n = int.Parse(Console.ReadLine());

            double countryArea = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите количество жителей в регионе " + i.ToString() + " (тыс.чел):");
                var citizen = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите плотность населения в  регионе " + i.ToString() + " (тыс.чел/кв.км):");
                var density = double.Parse(Console.ReadLine());

                countryArea = countryArea + citizen / density;
            }

            Console.WriteLine("Общая площадь страны: " + Math.Round(countryArea, 2).ToString() + " кв.км");

            Console.ReadKey();
        }
    }
}
