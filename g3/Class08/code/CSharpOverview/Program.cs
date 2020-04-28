using System;
using Domain;
using Services;

namespace CSharpOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalService animalService = new AnimalService();

            Animal mirce = new Animal()
            {
                Spicies = "Mirce",
                EyeColor = "green",
                CanSwim = true
            };
            Animal ace = new Animal("Ace", "green", true);
            Animal stojan = new Animal("Stojan", "yellow", true);

            Cat bozana = new Cat();

            Bird slave = new Bird("slavejce", "black", "white", false, true);

            Sparrow goran = new Sparrow("goran", "white", "awesome", "blue", true);
            Sparrow dejan = new Sparrow();

            mirce.Eat();
            bozana.Eat();
            bozana.Meow();
            Console.WriteLine(slave.Wings);


            Console.WriteLine(animalService.GetInfo(mirce));
            Console.WriteLine(animalService.GetInfo(ace));
            Console.WriteLine(animalService.GetInfo(stojan));


            Console.Read();
        }
    }
}
