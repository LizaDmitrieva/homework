using System;

namespace homework_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи ");
            string whiteRook = Console.ReadLine();

            Console.WriteLine("Введите позицию черного короля ");
            string blackKing = Console.ReadLine();

            int wx, wy, bx, by;

            GetCoordinates(whiteRook, out wx, out wy);
            GetCoordinates(blackKing, out bx, out by);

            string result = "Нет, не может.";

            if (whiteRook != blackKing &&
                wx != bx &&
                wy != by &&
                (1 < Math.Abs(wx - bx) || 1 < Math.Abs(wy - by)))
            {
                Console.WriteLine("Введите новую позицию белой ладьи ");
                string newRook = Console.ReadLine();
                int wx1, wy1;
                GetCoordinates(newRook, out wx1, out wy1);
                if (CheckNewPosition(bx, by, wx1, wy1))
                {
                    result = "Да, может.";
                }
            }

            Console.WriteLine("Ответ: " + result);

            Console.ReadKey();
        }

        static void GetCoordinates(string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;
            y = int.Parse(position[1].ToString());
        }

        static bool CheckNewPosition(int bx, int by, int wx1, int wy1)
        {
            return  wx1 != bx &&
                    wy1 != by &&
                    (1 < Math.Abs(wx1 - bx) || 1 < Math.Abs(wy1 - by));
        }


    }
}
