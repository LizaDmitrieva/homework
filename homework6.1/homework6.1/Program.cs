using System;

namespace homework6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetNumber("k");
            var b = GetNumber("m");
            var c = GetNumber("n");

            string answer = "Нет.";

            if (EvaluateLogicalExpression(a, b, c))
                answer = "Да.";

            Console.WriteLine("Верно ли, что только одно из чисел k, m или n кратно пяти? " + 
                answer);

            Console.ReadKey();
        }
        static bool EvaluateLogicalExpression(int k, int m, int n)
        {
            return ((k % 5 == 0 && m % 5 != 0 && n % 5 != 0) || (m % 5 == 0 && k % 5 != 0 && n % 5 != 0)|| (n % 5 == 0 && k % 5 != 0 && m% 5 != 0));
        }
        static int GetNumber(string numberName)
        {
            Console.WriteLine("Введите число " + numberName);
            return int.Parse(Console.ReadLine());
        }
    }
}
