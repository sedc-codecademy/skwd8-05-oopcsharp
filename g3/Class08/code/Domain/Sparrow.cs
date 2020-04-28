using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Sparrow : Bird
    {
        public string Feathers { get; set; }
        public Sparrow()
        {
            Console.WriteLine("");
        }

        public Sparrow(string spices, string eyeColor, string wings, string feathers, bool canFly) : base(eyeColor, spices, wings, false, canFly)
        {
            //this.
            //base.Spicies = spices;
            //base.EyeColor = eyeColor;
            //base.Wings = wings;
            this.Feathers = feathers;
            //Sparrow sparrow = new Sparrow();
        }
    }
}
