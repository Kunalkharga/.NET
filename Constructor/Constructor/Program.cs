using System;

namespace Constructor
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Hello World!");
        }
        ~Program()
        {
            Console.WriteLine("Destructor called.");
        }
        static void Main(string[] args)
        {
            DefaultConstructorClass obj = new DefaultConstructorClass();
            Console.WriteLine("value of x:" + obj.a);
            Console.WriteLine("value of y: " + obj.b);

            InstanceConstructorExample obj1 = new InstanceConstructorExample(5);
            InstanceConstructorExample obj2 = new InstanceConstructorExample(10);
            Console.WriteLine("value of x in obj1: " + obj1.x);
            Console.WriteLine("value of x in obj2: " + obj2.x);

            OverloadedConstructorExample obj11 = new OverloadedConstructorExample();
            OverloadedConstructorExample obj12 = new OverloadedConstructorExample(5);
            OverloadedConstructorExample obj13 = new OverloadedConstructorExample(3, 7);

            Console.WriteLine("obj1: x = " + obj11.x + ", y = " + obj11.y);
            Console.WriteLine("obj2: x = " + obj12.x + ", y = " + obj12.y);
            Console.WriteLine("obj3: x = " + obj13.x + ", y = " + obj13.y);
        }
    }

    public class DefaultConstructorClass
    {
        public readonly int a;
        public readonly int b;

        public DefaultConstructorClass()
        {
            a = 10;
        }
    }

    public class InstanceConstructorExample
    {
        public int x;
        public InstanceConstructorExample(int value)
        {
            x = value;
        }
    }

    class OverloadedConstructorExample
    {
        public int x;
        public int y;

        public OverloadedConstructorExample()
        {
            x = 0;
            y = 0;
        }

        public OverloadedConstructorExample(int value)
        {
            x = value;
            y = 0;
        }

        public OverloadedConstructorExample(int value1, int value2)
        {
            x = value1;
            y = value2;
        }
    }
}
