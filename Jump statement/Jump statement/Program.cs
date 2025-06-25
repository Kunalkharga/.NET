using System;
using System.Collections.Generic;
namespace Jump_statement
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("starting Main method");

            Console.WriteLine("\nUsing goto statement:");
            UseGoto();

            Console.WriteLine("\nUsing break statement:");
            UseBreak();

            Console.WriteLine("\nUsing return statement:");
            UseReturn();

            Console.WriteLine("Ending Main method");

            List<string> list = new List<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UseGoto()
        {
            int x = 5;

            if (x == 5)
            {
                goto skip;
            }

            Console.WriteLine("This will not be printed because x= 0");

        skip:
            Console.WriteLine("Excited the conditional block using g");
        }

        static void UseBreak()
        {
            int y = 5;

            switch (y)
            {
                case 1:
                    Console.WriteLine("y is 1");
                    break;
                case 5:
                    Console.WriteLine("y is 5");
                    break;

                default:
                    Console.WriteLine("y is not 1 or 5");
                    break;

            }

            Console.WriteLine("Excited the switch block using break");
        }

        static void UseReturn()
        {
            int z = 5;

            if (z == 5)
            {
                return;
            }
            Console.WriteLine("This will not be printed because z= ");

            Console.WriteLine("This line will never");

        }
    }

}
