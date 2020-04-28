using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public Bird(string eyeColor, string spcies, string wings, bool canSwim, bool canFly)
        {
            Spicies = spcies;
            EyeColor = eyeColor;
            CanSwim = canSwim;
            Wings = wings;
            //CanFly = true; // setting Default values
            CanFly = canFly;
        }

        public string Wings { get; set; }
        public bool CanFly { get; set; }

    }
}
