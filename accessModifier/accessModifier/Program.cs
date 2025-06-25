using System;

namespace accessModifier
{
    public class Person
    {
        public string name = "John";
        private int age = 25;
        protected string address = "City";
        internal string country = "Nepal";

        public void ShowInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("Country :" + country);
        }
    }
    public class Student : Person {
        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Name : " + name);
            //Console.WriteLine("Student age :" + age);
            Console.WriteLine("Student Address : " + address);
            Console.WriteLine("StudentCountry : " + country);
        }

    }



   class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
            //Console.WriteLine(person.age);
            //Console.WriteLine(person.address);
            Console.WriteLine(person.country);

            person.ShowInfo();

            Console.WriteLine("-----------------");

            Student student = new Student();

            student.ShowStudentInfo();

        }
    }

}
