using System;
using System.Collections.Generic;

namespace SEDC.Class08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            int[] intArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine(intArray1[3]);

            List<int> listOfIntegers = new List<int>();
            List<int> listOfIntegers1 = new List<int>() { 1, 2, 3, 4, 5 };

            Dictionary<int, string> dictionaryOfIntString = new Dictionary<int, string>();
            Dictionary<int, string> dictionaryOfIntString1 = new Dictionary<int, string>() 
            {
                { 1, "Trajan" },
                { 2, "Tosho" }
            };


            dictionaryOfIntString1[1] = "Trajan12";
            dictionaryOfIntString1[7] = "Tosho";
            dictionaryOfIntString1[18] = "Bob";
            dictionaryOfIntString1[22] = "Bobski";
            dictionaryOfIntString1[22] = "Bobski Bobski";

            Console.WriteLine(dictionaryOfIntString1[22]);

            dictionaryOfIntString1.Add(23, "Nesto drugo");
            dictionaryOfIntString1.Remove(50);

            Dictionary<double, Person> listOfPersons = new Dictionary<double, Person>()
            {
                { 2.0, new Person() { Name = "Trajan" } },
                { 3.0, new Person() { Name = "Tosho" } }
            };

            foreach (var item in listOfPersons)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
                Console.WriteLine(listOfPersons[item.Key].Name);
            }


            //foreach (var item in dictionaryOfIntString1)
            //{
            //    Console.WriteLine("Value: " + dictionaryOfIntString1[item.Key]);

            //    Console.WriteLine("----------- using .Value");

            //    //Console.WriteLine("Key: " + item.Key);
            //    Console.WriteLine("Value using .Value: " + item.Value);
            //}

            //Console.WriteLine(listOfIntegers1[2]);


            //Console.WriteLine(intArray1.Length);
            //Console.WriteLine(listOfIntegers1.Count);
            //Console.WriteLine(intArray.Length);
            //Console.WriteLine(listOfIntegers.Count);

            //Array.Resize(ref intArray1, 11);
            //intArray1[11] = 8;

            //listOfIntegers.Add(1);
            //listOfIntegers.Add(2);
            //listOfIntegers.Add(3);
            //listOfIntegers.Add(1);
            //listOfIntegers.Add(5);
            //listOfIntegers.Remove(1);

            //Console.WriteLine("--------------------------------------------");

            //foreach (var item in listOfIntegers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------");

            //for (int i = 0; i < listOfIntegers1.Count; i++)
            //{
            //    Console.WriteLine(listOfIntegers1[i]);
            //}



            Console.ReadLine();
        }
    }
}
