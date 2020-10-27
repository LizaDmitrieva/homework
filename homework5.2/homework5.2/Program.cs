using System;

namespace homework5._2
{
    class Program
    {
        static void Main()
        {
            string word1 = "клоун";

            string word2 = word1.Substring(0, 1) + word1.Substring(3, 1) + word1.Substring(1, 2) + word1.Substring(4, 1);
            Console.WriteLine("Первое полученное слово:" + word2);

            string word3 = word1.Substring(0, 1) + word1.Substring(2, 1) + word1.Substring(1, 1) + word1.Substring(3);
            Console.WriteLine("Второе полученное слово:" + word3);

            Console.ReadKey();
        }
    }
}
