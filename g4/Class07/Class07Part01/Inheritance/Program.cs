using InheritanceClasses;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dumbo = new Animal()
            {
                Id = 1,
                Name = "Dumbo",
                Type = "elephant",
                // IsHappy = true - we can't access this here
            };
            dumbo.PrintInfo();
            dumbo.Eat();
            Console.WriteLine("-----------------------------------------");

            Dog baron = new Dog()
            {
                Id = 2,
                Type = "dog",
                Name = "Barron",
                Race = "German sheppard"
            };
            baron.PrintInfo();
            baron.Eat();
            baron.Bark();
            baron.IsDogHappy();
            Console.WriteLine("-----------------------------------------");

            Cat garfield = new Cat()
            {
                Id = 3,
                Name = "Garfield",
                Laziness = "very much"
            };
            // we don't tell the type here
            garfield.PrintInfo();
            garfield.Eat();
            garfield.Meow();
            Console.WriteLine("-----------------------------------------");

            Console.ReadLine();
        }
    }
}
