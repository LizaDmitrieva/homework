using System;

namespace homework_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var  whiteRookPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного короля");
            var blackKingPosition = Console.ReadLine();

        
            if (CheckPosition(whiteRookPosition, blackKingPosition))
            {
                Console.WriteLine("Введите ход белой ладьи");
                var whiteRookMove = Console.ReadLine();
                if (CanRookMakeSafeMove(whiteRookPosition, whiteRookMove, blackKingPosition))
                    Console.WriteLine("Ладья может ходить");
                else
                    Console.WriteLine("Ладья не может ходить");
            }
            else
                Console.WriteLine("Введенные позиции некорректны");

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

        static bool CanRookMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return (startX == endX && startY != endY) || (startY == endY && startX != endX);
        }

        static bool CanKingMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return Math.Abs(endX - startX) <= 1 && Math.Abs(endY - startY) <= 1;
        }
        static bool CheckPosition(string whitePos, string blackPos)
        {
            return whitePos != blackPos && !CanRookMakeMove(whitePos, blackPos) && !CanKingMakeMove(whitePos, blackPos);
        }
         
        static bool CanRookMakeSafeMove(string rookStartPos, string rookEndPos, string kingPos)
        {
            return CanRookMakeMove(rookStartPos, rookEndPos) && !CanKingMakeMove(kingPos, rookEndPos);
        }


    }
}
