﻿using System;
using MethodOverloading;

namespace MethodOverloading
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(float a, float b)
        {
            return Convert.ToInt32(a + b);
        }

        public float Add (int a, int b, int c)
        {
            return a + b + c;u
        }

        public double Add(double a , double b)
        {
            return a + b;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}

public class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        Console.WriteLine("Add(int, int, int): " + calc.Add(5, 10, 15));
        Console.WriteLine("Add(double, double): " + calc.Add(5.5, 10.3));

    }
}
