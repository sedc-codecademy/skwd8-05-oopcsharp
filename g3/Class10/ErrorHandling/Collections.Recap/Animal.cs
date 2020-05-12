using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Recap
{
    public class Vehicle
    {
        public Brand Brand { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }

    public enum Brand
    {
        Fiat101,
        Yugo,
        Fico,
        Audi = 100,
        Opel = 99
    }
}
