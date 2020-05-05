using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(string spicies, string eyeColor, bool canSwim)
        {
            Spicies = spicies;
            this.EyeColor = eyeColor;
            CanSwim = canSwim;
        }

        public string Spicies { get; set; }
        public string EyeColor { get; set; }
        public bool CanSwim { get; set; }

        public void Eat()
        {
            Console.WriteLine("eating now, don't distrub be");
        }
    }
}
