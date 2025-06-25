using System;

namespace strings
{
    public static class Program
{
    static void Main(string[] args)

            //Character Conversion
    {
            string s = "Hello";
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());

            //string Concatenation

            string str1 = "Hello";
            string str2 = "World";
            string result = str1 + " " + str2;

            //Composite Formatting

            //string a = Console.ReadLine();
            int a = 10;
            int b = 20;
            int c = 5;
            Console.WriteLine("Hello {0} {1} {2}", a, b, c);

            Console.WriteLine("Hello {1} {0} {2}", "Ram", a, 9);

            //string Interpolation
            string name = "Kunal";
            int age = 23;
            string message = $"my name is {name} and i am {age} years old.";
            Console.WriteLine(message);

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Hello I am {name} and I am {age} years old.");

                
            }


        }
}

}
