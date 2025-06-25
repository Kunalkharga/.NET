using System;

namespace Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;


            Subb subb1 = new Subb();
            Subb subb2 = new Subb();
            Subb subb3 = new Subb();


            result = subb1.subb(1, 2);
            Console.WriteLine(result);

            result = subb2.subb(3, 4);
            Console.WriteLine(result);

            result = subb3.subb(5, 6);
            Console.WriteLine(result);
        }
    }

    public class Subb
    {

        public int subb(int a, int b)
        {
            return a - b;
        }
    }
}