using System;
using Domain;
using Services;

namespace CSharpInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalService animalService = new AnimalService();

            #region Domain Models instantation
            Animal ace = new Animal("Ace", "green", true); // Create an object with constructor
            Animal stojan = new Animal("Stojan", "yellow", true);
            Animal mirce = new Animal()
            {
                Spicies = "Mirce",
                EyeColor = "green",
                CanSwim = true
            }; // Create an object in shorter way

            Cat bozana = new Cat(); // Cat inherits from class Animal

            Bird slave = new Bird("slavejce", "black", "white", false, true); // Bird inherits from class Animal

            Sparrow goran = new Sparrow("goran", "white", "awesome", "blue", true);
            Sparrow dejan = new Sparrow(); // Sparrow inherits from class Bird
            #endregion

            Console.WriteLine(animalService.GetInfo(mirce));
            Console.WriteLine(animalService.GetInfo(ace));
            Console.WriteLine(animalService.GetInfo(stojan));

            mirce.Eat();
            bozana.Eat(); // bozana is a Cat object but, the Eat methods belongs to Animal class, TIP: use hover on the Eat method for more information
            //rename and override Meow method
            bozana.MakeSound(); // bozana is a Cat object and the Meow method belongs to Cat class

            Tiger johny = new Tiger();
            johny.MakeSound();

            WhiteTiger jacky = new WhiteTiger();
            jacky.MakeSound();
            jacky.MakeATigerSound();

            Console.WriteLine(slave.Wings);


            Console.Read();
        }
    }
}
