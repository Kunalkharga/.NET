using System;


class Program
{
    static int test1() => 5;
    

    static int test2(int x) => x +10;

    static string myfunc(string a, string b) => a + b;

  static  bool test(int a, int b)
    {
        return a > b;
    }

    static void Main()
        {
        int x = test1();
        int res = test2(x);
        string c = myfunc("ram"," sita");
        bool d = test(4, 5);
        Console.WriteLine($"The result is: {res}");
        }
    }


