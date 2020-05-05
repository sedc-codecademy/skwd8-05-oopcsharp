using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Bird : Animal // Bird class has access to all the properties and methods that are defined in Animal
    {
        public Bird()
        {

        }

        public Bird(string eyeColor, string spicies, string wings, bool canSwim, bool canFly)
        {
            Spicies = spicies; // Spicies is property in Animal class, but as you can see it is available in the Bird class to use
            EyeColor = eyeColor;
            CanSwim = canSwim;
            Wings = wings; // Wings is a proeprty in the Bird class
            CanFly = canFly; // CanFly is also property of the Bird class
            //CanFly = true; // could be set with a default value, to true, it doesn't have to be sent as parameters
        }

        public string Wings { get; set; }
        public bool CanFly { get; set; }
    }
}
