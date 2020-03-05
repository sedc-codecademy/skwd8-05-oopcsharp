using System;

namespace SEDC.Class02.BranchingAndFlowOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IfStatement
            int a = 5;
            int b = 3;

            if (a > b)
            {
                Console.WriteLine("5 is larger than 3");
            }
            else
            {
                Console.WriteLine("5 is not larger than 3");
            }

            Console.WriteLine("Please enter a number");
            int someNumber = int.Parse(Console.ReadLine());

            if (someNumber > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (someNumber < 0)
            {
                Console.WriteLine("Numbet is negative");
            }
            else
            {
                Console.WriteLine("MNumber is zero");
            }

            #endregion
            #region Excersise05
            int braches = 12;
            int applesOnBranch = 8;
            int bascetCapacity = 5;

            int treeCount = 0;
            bool isValidInput =
                int.TryParse(Console.ReadLine(), out treeCount);

            if (isValidInput)
            {
                int result = (applesOnBranch * braches) * treeCount;
                if (result % bascetCapacity == 0)
                {
                    Console.WriteLine(result / bascetCapacity);
                }
                else
                {
                    Console.WriteLine((result / bascetCapacity) + 1);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            #endregion
            #region Switch

            int day = 3;

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Work Day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("No such day");
                    break;
            }

            #endregion
        }
    }
}
