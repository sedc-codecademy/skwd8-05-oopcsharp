using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AnimalService
    {
        //override the method in some of the animals service
        public string GetInfo(Animal animal)
        {
            string canReallySwim = animal.CanSwim ? "can" : "can not";
            return $"Spicies: {animal.Spicies}, Eyecolor: {animal.EyeColor}, {canReallySwim} swim";
        }
    }
}
