//using System;

//class Program
//{
//    static void Main()
//    {
//        int a = 5;    
//        int b = 3;   

//        Console.WriteLine($"a & b: {a & b}");  
//        Console.WriteLine($"a | b: {a | b}");  
//        Console.WriteLine($"a ^ b: {a ^ b}");  
//        Console.WriteLine($"~a: {~a}");        

//        Console.WriteLine($"a << 1: {a << 1}");  
//        Console.WriteLine($"a >> 1: {a >> 1}");  
//    }
//}





//using System;

//class Program
//{
//    static void Main()
//    {
//        int a = 5;
//        int result = ~a;
//        Console.WriteLine(result);
//    }
//}








using System;
using System.Data;
using System.IO;

class Program
{
    static void Main()
    {
        var aa = sizeof(int);
        Console.WriteLine("Size of i t is :" + aa);
        var bb = typeof(StreamReader);
        Console.WriteLine("Type of streamreader:" + bb);

        int a = 5;
        int b = 10;

        var result1 = (a > b) ? a : b;
        Console.WriteLine(result1);
        Console.ReadLine();

    }
}