using System;

namespace BaseKeyboard
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dog barks");
        }
    }

    public class animal1
    {
        public animal1(string name)
        {
            Console.WriteLine("Animal creted:" + name);
        }
    }

    public class Dog1 : animal1
    {
        public Dog1(string name) : base(name)
        {
            Console.WriteLine("Dog1 created");
        }
    }

    public class program
    {
        public static void Main()
        {
            Animal animal = new Animal();
            animal.Speak();

            Dog dog = new Dog();
            dog.Speak();

            animal1 animal1 = new animal1("Generic animal");
            Dog1 dog1 = new Dog1("Buddy");
        }
    }


}
