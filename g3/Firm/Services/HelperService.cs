using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.CustomerModels;
using Domain.Enums;

namespace Services
{
    public class HelperService
    {
        public HelperService()
        {
            random = new Random();
            names = new string[] { "Lacy", "Man", "Trutude", "Eurocee", "Afix", "Trire", "Vivous", "Polyent", "Uberent" };
        }

        private Random random { get; set; }
        private string[] names { get; set; }

        public int GenerateId()
        {
            return random.Next();
        }

        public string RandomBusinessName()
        {
            return names[random.Next(0, names.Length - 1)];
        }

        public bool RandomBool()
        {
            return random.Next(0, 1) == 1 ? true : false;
        }

        public int RandomFromTo(int from, int to)
        {
            return random.Next(from, to);
        }
    }
}
