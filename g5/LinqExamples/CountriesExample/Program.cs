using System;
using System.Collections.Generic;
using System.Linq;

namespace CountriesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Macedonia", 2077328, 9781));
            countries.Add(new Country("Chile", 16888760, 292258));
            countries.Add(new Country("Cyprus", 1120489, 3571));
            countries.Add(new Country("Iceland", 311058, 39768));
            countries.Add(new Country("Albania", 2994667, 11100));
            PrintCountries(countries);

            //Find all countries that have above 1M population
            List<Country> above1M = countries.Where(country => country.Population > 1000000).ToList();
            PrintCountries(above1M);

            //Lets order countries by their size starting from the smallest
            List<Country> orderListAsc = countries.OrderBy(country => country.Area).ToList();
            PrintCountries(orderListAsc);
            
            //Lets order countries by their population starting from the largest
            List<Country> orderListDesc = countries.OrderByDescending(country => country.Population).ToList();
            PrintCountries(orderListDesc);

            //Lets get the names of the countries that have over 1M population, and area over 10000
            List<string> countriesNames = countries
                .Where(country => country.Population > 1000000 && country.Area > 10000)
                .Select(country => country.Name).ToList();

            Console.WriteLine("----------------------------");
            countriesNames.ForEach(Console.WriteLine);
        }

        public static void PrintCountries(List<Country> countries)
        {
            Console.WriteLine("----------------------------");
            foreach (var country in countries)
            {
                Console.WriteLine(country.GetInfo());
            }
        }
    }
}
