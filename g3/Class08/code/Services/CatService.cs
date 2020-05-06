using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class CatService : AnimalService
    {
        public override string GetInfo(Animal animal)
        {
            string canReallySwim = animal.CanSwim ? "can" : "can not";
            return $"Spicies: {animal.Spicies}, Eyecolor: {animal.EyeColor}, {canReallySwim} swim and this is calling from the CatService!";
        }
    }
}
