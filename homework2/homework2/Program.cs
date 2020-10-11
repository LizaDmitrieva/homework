using System;

namespace homework2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int startNumber = int.Parse(Console.ReadLine());
            ChangeTheNumber(startNumber);
        }

        static void ChangeTheNumber(int mNumber)
       {            
            string x = mNumber.ToString();

            Console.WriteLine(x.Substring (1,1) + x.Substring(0, 1) + x.Substring(2, 1));

            Console.ReadKey();
       
       }

    }
}
