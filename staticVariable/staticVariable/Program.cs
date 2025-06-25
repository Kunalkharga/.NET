using System;

namespace staticVariable
{
    public class Test
    {
        public int a = 10;
        public static int b=20;
        public void TestMethod()
        {
            Console.WriteLine("test Method");
        }

        public class program
        {
            static void Main(string[] args)
            {
                Test t = new Test();
                int a = Test.b;
                int b = t.a;
                Console.WriteLine($"a:{a}");

                //Test t = new Test();
                //int b = t.a;
                Console.WriteLine($"b :{b}");
            }
        }
        
    }
}
