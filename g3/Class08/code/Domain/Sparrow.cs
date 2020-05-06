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

        // : base(...) is the constructor of the Bird class, so by calling base() we are calling the constructor of Bird and we send some of the parameters that are passed in the Sparrow() constructor to the base constructor, not all parameters must be sent, also some of them can be sent by value only, like canSwim could be false directly
        public Sparrow(string spices, string eyeColor, string wings, string feathers, bool canFly) : base(eyeColor, spices, wings, false, canFly)
        {
            // If we call the base constructor, we should not set the properties of the base class in this class, that's why they are commented here, and in the base constructor they are not commented
            //base.Spicies = spices;
            //base.EyeColor = eyeColor;
            //base.Wings = wings;
            this.Feathers = feathers;
        }
    }
}
