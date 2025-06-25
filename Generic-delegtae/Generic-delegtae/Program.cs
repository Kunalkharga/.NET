using System;

namespace Generic_delegtae
{

    public delegate T MyGenericDelegate<T>(T parameter);
    public class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<int> square = Square;
            Console.WriteLine(square(5));

            MyGenericDelegate<string> reverse = Reverse;
            Console.WriteLine(reverse("Hello"));
        }

        static int Square(int x)
        {
            return x * x;
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
