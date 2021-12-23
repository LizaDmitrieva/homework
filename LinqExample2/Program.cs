using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample2
{
    class Program
    {
        public struct Record
        {
            public int ClientID; // идентификационный номер клиента
            public int Year;     // год
            public int Month;    // номер месяца
            public int Duration; // продолжительность занятий в данном месяце данного года (в часах)
        }

        static void Main(string[] args)
        {
            Record[] Visits = new Record[10];

            // Клиент 1 
            Visits[0].ClientID = 111;
            Visits[0].Year = 2020;
            Visits[0].Month = 2;
            Visits[0].Duration = 6;

            Visits[1].ClientID = 111;
            Visits[1].Year = 2020;
            Visits[1].Month = 4;
            Visits[1].Duration = 12;

            Visits[2].ClientID = 111;
            Visits[2].Year = 2020;
            Visits[2].Month = 7;
            Visits[2].Duration = 11;

            Visits[3].ClientID = 111;
            Visits[3].Year = 2021;
            Visits[3].Month = 9;
            Visits[3].Duration = 9;

            Visits[4].ClientID = 111;
            Visits[4].Year = 2021;
            Visits[4].Month = 8;
            Visits[4].Duration = 17;

            // Клиент 2 
            Visits[5].ClientID = 222;
            Visits[5].Year = 2020;
            Visits[5].Month = 3;
            Visits[5].Duration = 12;

            Visits[6].ClientID = 222;
            Visits[6].Year = 2020;
            Visits[6].Month = 9;
            Visits[6].Duration = 7;

            Visits[7].ClientID = 222;
            Visits[7].Year = 2021;
            Visits[7].Month = 12;
            Visits[7].Duration = 8;

            Visits[8].ClientID = 222;
            Visits[8].Year = 2021;
            Visits[8].Month = 1;
            Visits[8].Duration = 6;

            Visits[9].ClientID = 222;
            Visits[9].Year = 2021;
            Visits[9].Month = 9;
            Visits[9].Duration = 14;

            var lines = Visits
                .GroupBy(r => r.Month)
                .Select(g => (g.Key, g.Sum(d => d.Duration)))
                .OrderByDescending(y => y.Item2)
                .ThenBy(x => x.Key);

            if (lines.Count() > 0)
            {
                Console.WriteLine("Продолжительность посещений фитнес-центра в разрезе по месяцам");
                foreach (var line in lines)
                    Console.WriteLine($"{line.Item2} дней в месяце {line.Key}");
            }
            else
                Console.WriteLine($"Нет данных.");

            Console.ReadKey();
        }
    }
}
