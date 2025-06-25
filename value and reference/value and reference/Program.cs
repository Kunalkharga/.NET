using System;

namespace value_and_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //valuetype
            int a = 5;
            int b = a;

            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //int[] a = { 1, 2, 3, 4, 5, };
            //int[] b = a;
            //b[0] = 2;
            //Console.WriteLine(a[0]);
            //Console.WriteLine(b[0]);
        }
    }
}
