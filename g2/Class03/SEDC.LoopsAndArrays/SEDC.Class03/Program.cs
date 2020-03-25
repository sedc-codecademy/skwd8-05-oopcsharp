using System;

namespace SEDC.Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF YOU WANT TO FIND OUT WHAT EACH EXAMPLE DOES JUST OPEN THE REGION ON TO '+' SIGN

            #region For loop, break and contiunue
            // *** For loop ***
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Hello #{i}");
            //}

            // *** Infinetly for loop, unless a condition is met ***
            //for(; ; )
            //{
            //    Console.WriteLine("This will go forever unlessyou type E for exit!");
            //    string input = Console.ReadLine();
            //    if (input == "E" || input == "e") break;
            //}

            //int final = 10;
            //int counter = 0;

            //for(int i = counter; i < final; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // *** Break and continue - Creating the droid army ***
            //Console.WriteLine("Creating the droid army...");
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Assembling Droid Batalion " + i);
            //    if(i == 5)
            //    {
            //        Console.WriteLine("Problem in assembling with Droid battalion " + i);
            //        continue;
            //    }
            //    if(i == 7)
            //    {
            //        Console.WriteLine("Droid Assembler broke down!");
            //        break;
            //    }

            //    Console.WriteLine("Droid Batalion " + i + " is operational. \n");
            //}
            #endregion

            #region While
            // *** While loop *** 
            int counter = 1;
            //while (counter <= 5)
            //{
            //    Console.WriteLine($"Student No. {counter}");
            //    counter++;
            //}

            // *** Infinite while loop - Do not try it at home :) ***
            //while (true)
            //{
            //    Console.WriteLine("This will go on forever!");
            //}

            //Console.WriteLine("Please enter your name!");
            //string name = Console.ReadLine();

            //while(name != "martin")
            //{
            //    Console.WriteLine("Please enter your name!");
            //    name = Console.ReadLine();
            //}

            //while (true)
            //{
            //    if(name == "martin")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Please enter your name!");
            //    name = Console.ReadLine();
            //}

            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter <= 5);
            #endregion

            #region Arrays and array methods

            //Array declaration 
            int[] emptyIntArray = new int[5];
            emptyIntArray[0] = 1;
            emptyIntArray[1] = 2;
            emptyIntArray[2] = 3;
            emptyIntArray[3] = 4;
            emptyIntArray[4] = 5;
            //Console.WriteLine(emptyIntArray);
            //Console.WriteLine(emptyIntArray[0]);
            //Console.WriteLine(emptyIntArray[4]);

            emptyIntArray[0] = 10;
            emptyIntArray[4] = -15;

            //Cannot simply add a new element on 5th position
            //emptyIntArray[5] = 200;
            //Console.WriteLine(emptyIntArray[0]);
            //Console.WriteLine(emptyIntArray[4]);

            // Cannot display the 6th element if the array has declared only 5 elements
            //Console.WriteLine(emptyIntArray[5]);


            //Creating and initialization of array
            string[] names = new string[] { "Ivo", "Martin", "Nikola", "Orce", "Krsto" };
            bool[] boolArray = new bool[] { true, false, false, false, true };

            //Console.WriteLine(names[1]);

            // Even shorter way
            char[] chars = { 'i', 'v', 'o' };
            double[] doubles = { 4.5, 3.2, -10.6 };


            // *** Arrays property Length ***
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {names[i]}");
            //}
            //Console.WriteLine($"There are {names.Length} names in the array");


            // *** Arrays method IndexOf() ***
            int indexFound = Array.IndexOf(names, "Krsto");
            int indexNotFound = Array.IndexOf(names, "Angel");

            int foundInteger = Array.IndexOf(emptyIntArray, 5);
            //Console.WriteLine(foundInteger);

            //Console.WriteLine($"Found. The value you are seraching for is on position {indexFound}");
            //Console.WriteLine(indexNotFound);

            // *** Arrays method Reverse() ***
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}
            //Array.Reverse(chars);

            //Console.WriteLine("=============== After Reverse() ================");
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}


            Array.Reverse(chars);
            char[] reverted = chars;

            Array.Resize(ref chars, 4);
            chars[3] = 'm';
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //for (int i = 0; i < reverted.Length; i++)
            //{
            //    Console.WriteLine(reverted[i]);
            //}


            // *** Arrays method Resize() ***
            Array.Resize(ref names, 6);
            names[5] = "Dejan";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //Array.Resize(ref names, 8);
            //names[6] = "Dragan";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            string[] fullNames = new string[0];
            int count = 0;
            while (true)
            {
                Console.WriteLine("Please enter a name from keybord:");
                string fullName = Console.ReadLine();

                Array.Resize(ref fullNames, fullNames.Length + 1);

                fullNames[count] = fullName;
                Console.WriteLine("Name stored successfully!");

                //for (int i = 0; i < fullNames.Length; i++)
                //{
                //    Console.WriteLine(fullNames[i]);
                //}

                // *** Using of foreach ***
                foreach (var name in fullNames)
                {
                    int orderedNum = Array.IndexOf(fullNames, name);

                    Console.WriteLine($"{orderedNum + 1}. {name}");
                }

                Console.WriteLine("Do you want to add another name? Enter N to stop or Y to continue!");

                string continueOrNot = Console.ReadLine();
                if (continueOrNot == "n" || continueOrNot == "N") break;
                count++;
            }





            #endregion


            Console.ReadLine();
        }
    }
}
