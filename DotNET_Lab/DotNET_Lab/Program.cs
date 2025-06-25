////LabSheet-1
////2. Write the first program to print Hello World.
//using System;

//namespace First
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}


////LabSheet-2
////3. Class and its type with examples
//using System;

//namespace classTypes
//{
//    public class Person
//    {
//        public string Name;
//        public int Age;
//        public void Display() => Console.WriteLine($"Name: {Name}, Age: {Age}");
//    }

//    public static class Maths
//    {
//        public static int Add(int a, int b) => a + b;
//    }

//    public partial class Student
//    {
//        public string Name;
//        public void Show() => Console.WriteLine($"Student: {Name}");
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person p = new Person { Name = "Kunal", Age = 22 };
//            p.Display();

//            Student s = new Student { Name = "Kharga" };
//            s.Show();


//        }
//    }
//}





////4.Demonstrate(Value type and Reference Type) and process of Boxing and Unboxing.
//using System;

//namespace valuetype_boxing
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int val = 22;
//            Console.WriteLine("Value Type: " + val);

//            string str = "hello";
//            Console.WriteLine("Reference Type: " + str);

//            object obj = val;
//            Console.WriteLine("Boxed Value: " + obj);

//            int unboxedVal = (int)obj;
//            Console.WriteLine("Unboxed Value: " + unboxedVal);
//        }
//    }
//}





////5. WAP to find simple interest. [si=(p*t*r)/100]
//using System;

//namespace simpleInterest
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            double p = 4000, t = 2, r = 5;
//            double si = (p * t * r) / 100;
//            Console.WriteLine($"Simple Interest = {si}");
//        }
//    }
//}





////6. WAP to check the cost price and selling price and check profit or loss. Also, find the profit or loss amount.
//using System;

//namespace profitlosscheck
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            double costprice = 5000;
//            double sellingprice = 6000;

//            if (sellingprice > costprice)
//            {
//                Console.WriteLine("The profit amount is Rs. " + (sellingprice - costprice));
//            }
//            else if (costprice > sellingprice)
//            {
//                Console.WriteLine("The loss amount is Rs. " + (costprice - sellingprice));
//            }
//            else
//            {
//                Console.WriteLine("No profit, No loss");
//            }
//        }
//    }
//}





////7. Wap to show the use of ternary operator and switch.
//using System;

//namespace TernaryAndSwitch
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int age = 22;
//            string status = (age <= 18) ? "Male" : "Female";
//            Console.WriteLine($"Status: {status}");

//            int day = 2;
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Sunday");
//                    break;
//                case 2:
//                    Console.WriteLine("Monday");
//                    break;
//                default:
//                    Console.WriteLine("Invalid day");
//                    break;
//            }
//        }
//    }
//}





////8. Demonstrate string concatenation and interpolation.
//using System;

//namespace stringDemo
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string firstName = "ram";
//            string lastName = "sita";

//            string fullNameConcat = firstName + " " + lastName;
//            Console.WriteLine("Concatenation: " + fullNameConcat);

//            string fullNameInterpolated = $"{firstName} {lastName}";
//            Console.WriteLine("Interpolation: " + fullNameInterpolated);
//        }
//    }
//}





////9. Demonstrate 2d array and Jagged array.
//using System;

//namespace ArrayDemo
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {

//            int[,] twoDArray = {
//                { 2, 4 },
//                { 6, 8},

//            };

//            Console.WriteLine("2D Array:");
//            for (int i = 0; i < twoDArray.GetLength(0); i++)
//            {
//                for (int j = 0; j < twoDArray.GetLength(1); j++)
//                {
//                    Console.Write(twoDArray[i, j] + " ");
//                }
//                Console.WriteLine();
//            }

//            int[][] jaggedArray = new int[2][];
//            jaggedArray[0] = new int[] { 2, 4, 6 };
//            jaggedArray[1] = new int[] { 7, 8 };

//            Console.WriteLine("\nJagged Array:");
//            foreach (int[] row in jaggedArray)
//            {
//                foreach (int val in row)
//                {
//                    Console.Write(val + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}


//LabSheet-3

//1.Demonstrate the Constructor and its types.
//using System;

//class Demo
//{
//    string name;
//    int age;
//    static string course;

//    // Default Constructor
//    public Demo()
//    {
//        name = "Unknown";
//        age = 0;
//    }

//    // Parameterized Constructor
//    public Demo(string n, int a)
//    {
//        name = n;
//        age = a;
//    }

//    // Copy Constructor
//    public Demo(Demo d)
//    {
//        name = d.name;
//        age = d.age;
//    }

//    // Static Constructor
//    static Demo()
//    {
//        course = "BCA";
//        Console.WriteLine("Static Constructor Called");
//    }

//    // Private Constructor
//    private Demo(string msg)
//    {
//        Console.WriteLine("Private Constructor Called: " + msg);
//    }

//    public void Show()
//    {
//        Console.WriteLine("Name: " + name + ", Age: " + age + ", Course: " + course);
//    }

//    public static Demo CreateInstance()
//    {
//        return new Demo("This is private constructor");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Demo d1 = new Demo();
//        d1.Show();

//        Demo d2 = new Demo("Kunal", 21);
//        d2.Show();

//        Demo d3 = new Demo(d2);
//        d3.Show();

//        Demo d4 = Demo.CreateInstance();
//    }
//}


//2.You are designing a simple class hierarchy in C# for a software system.
//Your task is to create two classes: Animal (base class) and Dog (derived class).
//You need to implement properties and inheritance, ensuring the following:

//using System;

//class Animal
//{
//    private string name;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

//class Dog : Animal
//{
//    public string Breed { get; set; }

//    public void DisplayInfo()
//    {
//        Console.WriteLine("Dog Name: " + Name);
//        Console.WriteLine("Dog Breed: " + Breed);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dog myDog = new Dog();
//        myDog.Name = "Tommy";
//        myDog.Breed = "German Shepherd";

//        myDog.DisplayInfo();
//    }
//}


//3.Demonstrate Polymorphism, method overload, and overriding.
//using System;

//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing a shape");
//    }

//    public void Draw(string color)
//    {
//        Console.WriteLine("Drawing a shape with color: " + color);
//    }
//}

//class Circle : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a circle");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape s1 = new Shape();
//        s1.Draw();
//        s1.Draw("Red");

//        Circle c1 = new Circle();
//        c1.Draw();

//        Shape s2 = new Circle(); // Polymorphism
//        s2.Draw();
//    }
//}



//4.Demonstrate binary and unary operator overloading
//using System;
//class Number
//{
//    int value;

//    public Number(int v)
//    {
//        value = v;
//    }

//    public static Number operator +(Number a, Number b)
//    {
//        return new Number(a.value + b.value);
//    }

//    public static Number operator -(Number a)
//    {
//        return new Number(-a.value);
//    }

//    public void Show()
//    {
//        Console.WriteLine("Value: " + value);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Number n1 = new Number(10);
//        Number n2 = new Number(5);

//        Number result1 = n1 + n2;  
//        result1.Show();

//        Number result2 = -n1;      
//        result2.Show();
//    }
//}



//5.WAP to demonstrate a 2*2 matrix array and a jagged array.
//using System;

//class Program
//{
//    static void Main()
//    {
//        // 2x2 Matrix (Multidimensional Array)
//        int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };

//        Console.WriteLine("2x2 Matrix:");
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }

//        // Jagged Array
//        int[][] jagged = new int[2][];
//        jagged[0] = new int[] { 10, 20 };
//        jagged[1] = new int[] { 30, 40, 50 };

//        Console.WriteLine("Jagged Array:");
//        for (int i = 0; i < jagged.Length; i++)
//        {
//            for (int j = 0; j < jagged[i].Length; j++)
//            {
//                Console.Write(jagged[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//6.Create a C# inventory system that includes: Define Category (e.g., Electronics, Groceries). 
//using System;
//using System.Collections.Generic;

//enum Category
//{
//    Electronics,
//    Groceries,
//    Clothing
//}

//sealed class Item
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//    public Category Category { get; set; }

//    public Item(string name, double price, Category category)
//    {
//        Name = name;
//        Price = price;
//        Category = category;
//    }

//    public override string ToString() => $"{Name} - Rs.{Price}";
//}

//class Inventory
//{
//    private List<Item> items = new List<Item>();

//    public void AddItem(Item item)
//    {
//        items.Add(item);
//    }

//    public List<Item> GetItemsByCategory(Category category)
//    {
//        List<Item> list = new List<Item>();
//        foreach (var item in items)
//        {
//            if (item.Category == category)
//                list.Add(item);
//        }
//        return list;
//    }

//    public Dictionary<Category, List<Item>> GetItemsGroupedByCategory()
//    {
//        var dict = new Dictionary<Category, List<Item>>();
//        foreach (var item in items)
//        {
//            if (!dict.ContainsKey(item.Category))
//                dict[item.Category] = new List<Item>();
//            dict[item.Category].Add(item);
//        }
//        return dict;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var inventory = new Inventory();

//        inventory.AddItem(new Item("Laptop", 75000, Category.Electronics));
//        inventory.AddItem(new Item("Rice", 2000, Category.Groceries));
//        inventory.AddItem(new Item("T-Shirt", 1200, Category.Clothing));
//        inventory.AddItem(new Item("Mobile", 25000, Category.Electronics));

//        Console.WriteLine("Items in Electronics:");
//        foreach (var item in inventory.GetItemsByCategory(Category.Electronics))
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("\nAll Items Grouped by Category:");
//        var grouped = inventory.GetItemsGroupedByCategory();
//        foreach (var pair in grouped)
//        {
//            Console.WriteLine(pair.Key + ":");
//            foreach (var item in pair.Value)
//            {
//                Console.WriteLine("  " + item);
//            }
//        }
//    }
//}



//7.Demonstrate Struct in C #
//using System;

//struct Point
//{
//    public int X;
//    public int Y;

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Point coordinates: X = " + X + ", Y = " + Y);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(10, 20);
//        p1.Display();

//        Point p2;  
//        p2.X = 5;
//        p2.Y = 15;
//        p2.Display();
//    }
//}