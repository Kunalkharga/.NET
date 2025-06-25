using System;

namespace execptionhandleing
{
    class Program
    {
        public class MyCustomException : Exception
        {
            public MyCustomException(string message) : base(message) { }
        }
        static void ProcessData(int divisor)
        {
            try
            {
                Console.WriteLine("data processing...");
                if (divisor == 0)
                {
                    throw new DivideByZeroException("Divisor cannot be zero.");
                }
                else if (divisor < 0)
                {
                    throw new MyCustomException("Divsor cannot be negative");
                }
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("caught dividedbyzeroexcep" + ex.Message);
                throw;
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("caught custom:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }


        static void Main(string[] args)
        {
            try
            {
                ProcessData(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception caught in main" + ex.Message);
            }
            try
            {
                ProcessData(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception caught in main" + ex.Message);
            }
            try
            {
                ProcessData(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception caught in main" + ex.Message);
            }
        }
    }
}