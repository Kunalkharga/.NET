//using System;

//namespace MulticastDelegate
//{
//    public delegate int SampleDelegateMethod();

//    class Sample
//    {
//        public static int a = 10, b = 5, c, d = 4, e;

//       public static int Add()
//        {
//            c = a + b;
//            return c;
//        }

//        public static int Sub()
//        {
//            e = c - d;
//            return e;
//        }

//        public static void Main()
//        {
//            SampleDelegateMethod del1 = new SampleDelegateMethod(Add);
//            SampleDelegateMethod del2 = new SampleDelegateMethod(Sub);
//            SampleDelegateMethod del = del1 + del2;
//            int result = del();
//            Console.WriteLine(result);
//        }
//    }
//}




using System;

namespace MulticastDelegate
{
    public delegate int MulticastDelegate();

    public class Sample
    {
        public static int a = 10, b = 5, c, d = 4, e;

        public static void Main(string[] args)
        {
            MulticastDelegate multicastdelegate = new MulticastDelegate(Add);
            multicastdelegate += Sub;
            e = multicastdelegate();

            Console.WriteLine("Final value :" + e);
        }

        public static int Add()
        {
            c = a + b;
            return c;
        }

        public static int Sub()
        {
            e = c - d;
            return e;
        }
    }
}
