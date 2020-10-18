using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y1:");
            int y1 = int.Parse(Console.ReadLine());




            Console.WriteLine("введите x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y2:");
            int y2 = int.Parse(Console.ReadLine());


            Console.WriteLine("введите x3:");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y3:");
            int y3 = int.Parse(Console.ReadLine());


            double vec1 = (Math.Sqrt(Math.Pow(y1 - y2, 2) + Math.Pow(x1 - x2, 2)));
            double vec2 = (Math.Sqrt(Math.Pow(y2 - y3, 2) + Math.Pow(x2 - x3, 2)));
            double vec3 = (Math.Sqrt(Math.Pow(y3 - y1, 2) + Math.Pow(x3 - x1, 2)));

            double P = vec1 + vec2 + vec3;
            Console.WriteLine("P=" + P);

            double pp = P / 2;

            double S = Math.Sqrt(pp * (pp - vec1) * (pp - vec2) * (pp - vec3));
            Console.WriteLine("S=" + S);

            Console.ReadKey();
        }
    }
}
