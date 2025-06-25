//using System;

//namespace Sample
//{
//    public delegate void SampleDelegate();

//    public class Sample
//    {
//        static void Main()
//        {
//            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
//            SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
//            SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
//            //In this example del4 is a multicast delegate. You use +(plus)
//            //operator to chain delegates together and -(minus) operator to remove.
//            SampleDelegate del4 = del1 + del3 + del2;
//            del4();
//            //del1();
//            //del2();
//            //del3();

//        }

//        public static void SampleMethodOne()
//        {
//            Console.WriteLine("SampleMethodOne Invoked");
//        }

//        public static void SampleMethodTwo()
//        {
//            Console.WriteLine("SampleMethodTwo Invoked");
//        }

//        public static void SampleMethodThree()
//        {
//            Console.WriteLine("SampleMethodThree Invoked");
//        }
//    }
//}


//using System;

//namespace Sample
//{
//    public delegate void SampleDelegate();

//    public class Sample
//    {
//        static void Main()
//        {
//            //In this example del is a multicast delegate. You use +=
//            //operator to chain delegates together and -= operator to remove.
//            SampleDelegate del = new SampleDelegate(SampleMethodOne);
//            del += SampleMethodTwo;
//            del += SampleMethodThree;
//            del -= SampleMethodOne;

//            del();

//        }

//        public static void SampleMethodOne()
//        {
//            Console.WriteLine("SampleMethodOne Invoked");
//        }

//        public static void SampleMethodTwo()
//        {
//            Console.WriteLine("SampleMethodTwo Invoked");
//        }

//        public static void SampleMethodThree()
//        {
//            Console.WriteLine("SampleMethodThree Invoked");
//        }
//    }
//}


using System;

namespace Sample
{
    public delegate int SampleDelegate();

    public class Sample
    {
        static void Main()
        {
            
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodOne;

            int ValueReturnByDelegate = del();

            Console.WriteLine("Returned Value = {0}", ValueReturnByDelegate);
        }

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }

        public static int SampleMethodThree()
        {
            return 3;
        }
    }
}
