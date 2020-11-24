using System;

namespace homework7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Значение функции равно " + CalcFunctionResult(x));

            Console.ReadKey();
        }

        public static double CalcFunctionResult(double x)        
        {
            if (2 < x)
            {
                return 2;
            }
            else 
            {
                if (-2 <= x && x <= 2)
                {
                    return x;
                }
                else
                {
                    return -2;

                }
            } 
         
        }
    }
    
}
