using System;

namespace Inheritance
{

    public static class program
    {
        static void Main(string[] args)
        {
            DerivedClass1 derivedClass1 = new DerivedClass1();
            derivedClass1.BaseMethod();
            derivedClass1.IntermediateMethod();
            derivedClass1.DerivedMethod();

            //DerivedClass2 DerivedClass2 = new DerivedClass2(); 
            //derivedClass1. BaseMethod();
            //derivedClass1. IntermediateMethod();
        }
        class BaseClass1
        {
            public void BaseMethod()
            {
                Console.WriteLine("Base method");
            }
        }

        class IntermediateClass : BaseClass1
        {
            public void IntermediateMethod()
            {
                Console.WriteLine("Intermediate method");
            }
        }

        class DerivedClass1 : IntermediateClass
        {
            public void DerivedMethod()
            {
                Console.WriteLine("Derived method");
            }
        }
    }
}
