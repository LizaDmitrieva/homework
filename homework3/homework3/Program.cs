using System;

namespace homework3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x: ");
            var x = double.Parse(Console.ReadLine());

            var y = F(x);

            Console.WriteLine("f(x)= " + y);
            Console.ReadKey();
        }

        static double F(double x) 
        {
            return (Math.Pow(x, 2) + 10) / (Math.Sqrt(Math.Pow(x, 2) + 1));
        }
    }
}
