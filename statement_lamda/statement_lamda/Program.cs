using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x =>

            {
                if (x < 0)
                {
                    Console.WriteLine("input is negative , converting to positive ");
                    x= Math.Abs(x);
                }

                int result = x * x;
                return result;

            };

            int result = square(-5);
            Console.WriteLine($"the square of -5 is:  {result}");

        }
    }
}