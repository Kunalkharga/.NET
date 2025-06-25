using System;
using System.Linq;

namespace Static_class
{
    class Program
    {
        static void Main()
        {
            // MathUtilities usage
            int sum = MathUtilities.Add(2, 4);
            Console.WriteLine($"Sum: {sum}");

            // Configuration usage
            Console.WriteLine($"Application Name: {Configuration.ApplicationName}");
            Console.WriteLine($"Max Users: {Configuration.MaxUsers}");

            // StringExtensions usage
            string example = "hello, world";
            string reversed = example.Reverse();
            Console.WriteLine($"Reversed: {reversed}");
        }
    }

    public static class MathUtilities
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public static class Configuration
    {
        public static string ApplicationName { get; }
        public static int MaxUsers { get; }

        static Configuration()
        {
            ApplicationName = "My Application";
            MaxUsers = 10;
        }
    }

    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}