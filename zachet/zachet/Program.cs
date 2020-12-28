using System;

namespace zachet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            StringConversion(str);

            Console.ReadKey();
        }

        static void StringConversion (string str)
        {
            int calcArraySize = 0;

            if (str.Length % 2 == 0)
                calcArraySize = str.Length / 2;
            else
                calcArraySize = str.Length / 2 + 1;

            char[] evenArray = new char[calcArraySize];
            char[] oddArray = new char[str.Length - calcArraySize];
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenArray[evenArray.Length - i / 2 - 1] = str[i];
                }
                else
                {
                    oddArray[i / 2] = str[i];
                }
            }
            Console.WriteLine();

            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.Write(evenArray[i]);
                Console.Write(oddArray[i]);
            }
            if (str.Length % 2 == 1)
            {
                Console.WriteLine(evenArray[evenArray.Length - 1]);
            }
        }
    }
}
