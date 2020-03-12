using System;

namespace BranchingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEFINITION 1

            //Declaration
            int[] numbers = new int[2];

            //Assignment
            numbers[0] = 10;
            numbers[1] = 20;

            // Note in this case we wont have compile time error but app will throw exception
            numbers[3] = 100;


            //DEFINITION 2

            // Declare and init at same time
            int[] nums = new int[2] { 10, 20 };

            //Note in this case we will have compile time error. Gues why?
            int[] errorNums = new int[2] { 10, 20 30 };


            // DEFINITION 3
            int[] numArray = new int[] { 10, 20, 30, 40, 50 };
        }
    }
}
