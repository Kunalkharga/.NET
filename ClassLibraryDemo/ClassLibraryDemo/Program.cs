using System;

namespace ClassLibraryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = EnglishToNepaliNumber.EngToNepali.English_Nepali("123456");

            
            Console.WriteLine(a);
        }
    }
}
