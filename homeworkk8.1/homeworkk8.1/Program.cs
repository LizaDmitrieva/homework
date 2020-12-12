using System;

namespace homework8._1
{
    class Program
    {
        static char horizontalLine = (char)0x2500;
        static char topLeftCorner = (char)0x250C;
        static char topRightCorner = (char)0x2510;
        static char bottomLeftCorner = (char)0x2514;
        static char bottomRightCorner = (char)0x2518;
        static char verticalLeft = (char)0x2524;
        static char verticalRight = (char)0x251C;
        static char horizontalDown = (char)0x252C;
        static char horizontalUp = (char)0x2534;
        static char verticalHorizontal = (char)0x253C;

        static void Main()
        {
            Console.WriteLine("Введите курс доллара: ");
            var course = double.Parse(Console.ReadLine());

            Console.WriteLine();

            PrintTable(course);

            Console.ReadKey();
        }

        static void PrintTable(double course)
        {
            int size = 25;

            PrintLine(size, horizontalLine, topLeftCorner, topRightCorner, horizontalDown);
            var header = String.Format("  | {0,-10} | {1,-10} |", "USD", "РУБ");
            Console.WriteLine(header);

            for (int i = 10; i <= 1000; i++)
            {
                if (i % 10 == 0)
                {
                    PrintLine(size, horizontalLine, verticalRight, verticalLeft, verticalHorizontal);
                    var str = String.Format("  | {0,-10} | {1,-10} |", i, i * course);
                    Console.WriteLine(str);
                }
            }

            PrintLine(size, horizontalLine, bottomLeftCorner, bottomRightCorner, horizontalUp);

            Console.WriteLine();
        }

        static void PrintLine(int size, char line, char firstCorner, char lastCorner, char middleSymbole)
        {
            var str = new string(' ', size.ToString().Length) + firstCorner
                + new string(line, size - 13) + middleSymbole
                + new string(line, size - 13) + lastCorner;
            Console.WriteLine(str);
        }
    }
}