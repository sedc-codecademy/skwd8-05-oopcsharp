using SEDC.Class05.Classes.Classes;
using System;

namespace SEDC.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.DateOfBirth = new DateTime(1990,6,3);
            human.FirstName = "Tosho";
            human.LastName = "Todorovski";
            human.SSN = 12345;
            // human.FullName = "Tosho Todorovski"; not accesable due to protection modifier
            //Console.WriteLine($"{human.FirstName} {human.LastName} is born on {human.DateOfBirth}.");
            Human trajan = new Human();
            trajan.FirstName = "Trajan";
            //Console.WriteLine(
            //    $"{trajan.FirstName} {trajan.LastName} is born on {trajan.DateOfBirth} with SSN: {trajan.SSN}.");

            Human[] humans = new Human[2] { human, trajan };

            Car fiat = new Car();
            fiat.Brand = "Fiat";
            fiat.Model = "Tipo";
            fiat.ProductionYear = new DateTime(1988, 12, 12);
            fiat.IsRunning = false;

            //fiat.Drive();

            Car mercedes = new Car()
            {
                Brand = "Mercedes",
                Model = "C200",
                ProductionYear = new DateTime(2000,10,10),
                IsRunning = true
            };

            Car citroen = new Car()
            {
                Brand = "Citroen",
                Model = "Diana",
                ProductionYear = new DateTime(1888, 10, 10),
                IsRunning = true
            };

            Car ww = new Car()
            {
                Brand = "Volkswagen",
                Model = "Golf",
                ProductionYear = new DateTime(2008, 01, 10),
                IsRunning = false
            };

            //Console.WriteLine(fiat.GetInfo());
            //Console.WriteLine(mercedes.GetInfo());
            //Console.WriteLine(citroen.GetInfo());
            //Console.WriteLine(ww.GetInfo());

            PersonExample();

            Console.ReadLine();
        }

        public static void PersonExample()
        {
            Person trajan = new Person()
            {
                DateOfBirth = new DateTime(1990, 4, 1),
                FirstName = "Trajan",
                LastName = "Stevkovski"
            };
            Person toshe = new Person()
            {
                DateOfBirth = new DateTime(1990, 6, 3),
                FirstName = "Toshe",
                LastName = "Todorovski"
            };

            Console.WriteLine(trajan.SayHelloTo(toshe.GetFullName()));
        }
    }
}
