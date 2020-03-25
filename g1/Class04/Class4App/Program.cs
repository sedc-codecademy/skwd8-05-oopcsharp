using System;

namespace Class4App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ONLINE World!");

            #region FirstPart
            //int firstNumber = 10;
            //int secondNumber = 20;
            //int thirdNumber = 100;

            //var numbers = new int[] { 10, 20, 30, 50, 80 };

            //int sumOfAll = Sum(numbers);

            //Console.WriteLine(sumOfAll);

            //int result = Sum(firstNumber, secondNumber);

            //int anotherResult = Sum(firstNumber, secondNumber, thirdNumber);

            //Console.WriteLine("The sum of the numbers is:" + result);
            #endregion

            #region SecondPart
            string group = "G1";
            int num = 50;

            Greetings(group, num);


            //Increment(num);

            #endregion

            Console.ReadLine();
        }

        //My question for you :)
        public static void Increment(int number)
        {
            number += 100;

            Console.WriteLine(number);
        }

        public static void Greetings(string group, int number)
        {
            Console.WriteLine("{0} is enjoying the online C# training", group);

            char sign = '+';
        }

        //Methods Overloading
        //Method signature -> Name of the method/Input Parameters

        //Polymorphism -> Multiple forms

        public static int Sum(int first, int second)
        {
            return first + second;
        }

        public static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        public static string Sum(int first, bool anotherFirst)
        {
            return "";
        }

        //Generic method for sum of n numbers (array of integers)
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        
    }
}