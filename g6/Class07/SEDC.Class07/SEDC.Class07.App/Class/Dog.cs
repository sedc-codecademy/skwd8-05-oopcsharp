using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.App.Class
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
            : base()
        {
        }

        public Dog(int id, string name, string type, string race)
            : base(id, name, type)
        {
            Race = race;
        }
        
        public void Feed(string snack)
        {
            Console.WriteLine($"WE feed the dog with {snack}");
            // more code here
            Eat(snack);
        }
        public void Bark()
        {

        }

    }
}
