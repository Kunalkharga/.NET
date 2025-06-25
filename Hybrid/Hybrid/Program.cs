using System;

class Program
{
    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    class Person
    {
        public string Name;
        public void Greet()
        {
            Console.WriteLine("Hello, " + Name);
        }
    }

    static void Main()
    {
        ShowMessage("Welcome to Hybrid C# Code!");

        Person person = new Person();
        person.Name = "Kunal";
        person.Greet();
    }
}
