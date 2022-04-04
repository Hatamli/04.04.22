using System;

namespace AzeToEng
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Ölü, Əli, Şah, Çağır";
            text = text.ToLower();
            Console.WriteLine(AzeToEngConverter(text));
        }

        public static string AzeToEngConverter(string text)
        {
            text = text.Replace('ö', 'o');
            text = text.Replace('ü', 'u');
            text = text.Replace('ğ', 'g');
            text = text.Replace('ş', 's');
            text = text.Replace('ı', 'i');
            text = text.Replace('ç', 'c');
            text = text.Replace('ə', 'e');

            return text;
        }
    }
}
