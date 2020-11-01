using System;

namespace homework_5._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string lineRus = Console.ReadLine();

            string lineEng = Transliteration(lineRus);
            Console.WriteLine(lineEng);

            Console.ReadKey();

        }
        static string Transliteration(string str)
        {
            str = str.Replace("А", "A");
            str = str.Replace("Б", "B");
            str = str.Replace("В", "V");
            str = str.Replace("Г", "G");
            str = str.Replace("Д", "D");
            str = str.Replace("Е", "E");
            str = str.Replace("Ё", "E");
            str = str.Replace("Ж", "ZH");
            str = str.Replace("З", "Z");
            str = str.Replace("И", "I");
            str = str.Replace("Й", "I");
            str = str.Replace("К", "K");
            str = str.Replace("Л", "L");
            str = str.Replace("М", "M");
            str = str.Replace("Н", "N");
            str = str.Replace("О", "O");
            str = str.Replace("П", "P");
            str = str.Replace("Р", "R");
            str = str.Replace("С", "S");
            str = str.Replace("Т", "T");
            str = str.Replace("У", "U");
            str = str.Replace("Ф", "F");
            str = str.Replace("Х", "KH");
            str = str.Replace("Ц", "TS");
            str = str.Replace("Ч", "CH");
            str = str.Replace("Ш", "SH");
            str = str.Replace("Щ", "SHCH");
            str = str.Replace("Ъ", "IE");
            str = str.Replace("Ы", "Y");
            str = str.Replace("Э", "E");
            str = str.Replace("Ю", "IU");
            str = str.Replace("Я", "IA");

            str = str.Replace("а", "a");
            str = str.Replace("б", "b"); 
            str = str.Replace("в", "v"); 
            str = str.Replace("г", "g"); 
            str = str.Replace("д", "d"); 
            str = str.Replace("е", "e"); 
            str = str.Replace("ё", "e"); 
            str = str.Replace("ж", "zh");
            str = str.Replace("з", "z");
            str = str.Replace("и", "i");
            str = str.Replace("й", "i");
            str = str.Replace("к", "k");
            str = str.Replace("л", "l");
            str = str.Replace("м", "m");
            str = str.Replace("н", "n");
            str = str.Replace("о", "o");
            str = str.Replace("п", "p");
            str = str.Replace("р", "r");
            str = str.Replace("с", "s");
            str = str.Replace("т", "t");
            str = str.Replace("у", "u");
            str = str.Replace("ф", "f");
            str = str.Replace("х", "kh");
            str = str.Replace("ц", "tc");
            str = str.Replace("ч", "ch");
            str = str.Replace("ш", "sh");
            str = str.Replace("щ", "shch");
            str = str.Replace("ъ", "ie");
            str = str.Replace("ы", "y");
            str = str.Replace("э", "e");
            str = str.Replace("ю", "iu");
            str = str.Replace("я", "ia");
           
            return str;
        }
    }
}


