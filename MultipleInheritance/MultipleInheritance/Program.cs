using System;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MultipleInheritance multipleInheritance = new MultipleInheritance();
            multipleInheritance.FirstMethod();
            multipleInheritance.SecondMethod();
        }
    }
    public interface IFirst
    {
        void FirstMethod();
    }

    public interface ISecond
    {
      public  void SecondMethod();
    }

    class MultipleInheritance : IFirst, ISecond
    {
        public void FirstMethod()
        {
            Console.WriteLine("First method");
        }

        public void SecondMethod()
        {
            Console.WriteLine("Second method");
        }
    }
}
