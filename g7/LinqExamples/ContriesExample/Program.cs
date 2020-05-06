using System;
using System.Collections.Generic;
using System.Linq;

namespace ContriesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Albania", 2994667, 11100));
            countries.Add(new Country("Chile", 16888760, 292258));
            countries.Add(new Country("Cyprus", 1120489, 3571));
            countries.Add(new Country("Iceland", 311058, 39768));
            countries.Add(new Country("Macedonia", 2077328, 9781));
            Console.WriteLine("----All Countries-----");
            PrintCountries(countries);
            //Find all countries that have above 1M population
            List<Country> countriesOver1M = countries.Where(country => country.Population > 1000000).ToList();
            Console.WriteLine("----Over 1M-----");
            PrintCountries(countriesOver1M);

            //Lets order countries by their size starting from the smallest
            List<Country> orderStartingTheSmallest = countries.OrderBy(country => country.Area).ToList();
            Console.WriteLine("----Order starting from the smallest-----");
            PrintCountries(orderStartingTheSmallest);
            //Lets order countries by their size starting from the largest
            List<Country> orderStartingTheLargest = countries.OrderByDescending(country => country.Area).ToList();
            Console.WriteLine("----Order starting from the largest-----");
            PrintCountries(orderStartingTheLargest);

            //Lets get the names of the countries that have over 1M population, and over 10000
            List<string> names = countries.Where(country => country.Population > 1000000 && country.Area > 10000).Select(country => country.Name)
                .ToList();
            Console.WriteLine("-----------");
            names.ForEach(countryName => Console.WriteLine(countryName));
            //names.ForEach(Console.WriteLine);

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
        }

        public static void PrintCountries(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country.GetInfo());
            }
        }
    }
}
