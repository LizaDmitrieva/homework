using System;

namespace homework4
{
    class Program
    {
        static void Main()
        {
            var x = GetValue();

            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }

        static double GetValue()
        {
            return F(2, 3) + F(5, 7) + F(11, 13);
        }

        static double F(double a, double b)
        {
            return (Math.Sin(a) + Math.Sin(b)) / (a + b);
        }
    }
}
