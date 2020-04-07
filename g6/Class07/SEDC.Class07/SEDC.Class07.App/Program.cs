using SEDC.Class07.App.Class;
using SEDC.Class07.Excersise.Entities;
using System;

namespace SEDC.Class07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //Cat cat = new Cat() { Id = 1, Lazyness = "Lazy", Name = "Tom", Type = "Macor" };
            //Dog bob = new Dog() { Id = 1, Race = "Yes", Name = "Sppedy", Type = "Kuce" };

            //cat.Feed("Smoki");
            //bob.Feed("Cat");

            //Cat cat1 = new Cat();
            //cat1.Feed("Snack");

            // SuperDog superBob = new SuperDog();

            Cat cat = new Cat(1, "Tom", "Macor");
            Dog bob = new Dog(2, "Speedy", "Kuce", "Yes");

            cat.Feed("Smoki");
            bob.Feed("Cat");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
