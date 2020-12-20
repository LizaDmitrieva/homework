using System;

namespace homework9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());

            var myArray = new double[n];

            Random rnd = new Random();
            for (int i = 0; i < (n-1); i++) 
            {
                myArray[i] = rnd.Next(-10, 10) + rnd.NextDouble();
            }

            PrintArray(myArray);

            Console.WriteLine();

            ChangeArray(myArray);

            Console.WriteLine();

            CalcSquareRoot(myArray);

            Console.WriteLine("Введите число x: ");
            var x = int.Parse(Console.ReadLine());

            GetSinArray(myArray, x);

            Console.ReadKey();
        }

        static void PrintArray(double [] myArray) 
        {
            foreach (double x in myArray)
            {
                Console.Write(Math.Round(x, 3).ToString() + " "); 
            }
        }

        static void ChangeArray(double [] myArray) 
        { 
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (i % 2 == 0) 
                {
                    myArray[i] = Math.Abs(myArray[i]);
                }
            }

            PrintArray(myArray);
        } 

        static void CalcSquareRoot(double [] myArray) 
        {
            double z = 0;

            foreach (double x in myArray)
            {
                z = z + Math.Pow(x, 2);
            }

            Console.WriteLine(Math.Sqrt(z).ToString());
        }

        static void GetSinArray(double [] myArray, int x) 
        {
            var newArray = new double[myArray.Length];
            myArray.CopyTo(newArray, 0);

            double k; 
            for (int i = 0; i < newArray.Length; i++) 
            {
                k = Math.Truncate(newArray[i]);
                newArray[i] = Math.Sin(k * x);            
            }

            PrintArray(newArray);
        }
    }
}
