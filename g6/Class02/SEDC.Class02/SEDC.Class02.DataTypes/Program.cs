using System;
using System.Threading;

namespace SEDC.Class02.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataType
            int integerVariable = 1;
            int integetVariable1;
            integetVariable1 = -100;
            long integetVariable3 = 123123231232332233;
            int a = 100;
            int b = 100;
            int c = a * b;

            float floatVariable = 2.5F; // F is for float
            decimal decimalVariable = 2.5M; // M is for decimal
            double doubleVariable = 2.5D; // D is for double

            string stringVariable = "Trajan Stekvovski";
            Console.WriteLine(stringVariable);
            char stringVariable1 = 't';
            Console.WriteLine(stringVariable);

            bool isTrue = false;

            var variableA = 134567823652737245;
            // variableA = "asdasd";

            bool isTrue2 = false && true;
            string str = "";
            string str2 = null;
            bool isTrue3 = str2 == null || str == null || false || true;
            bool isTrue4 = true && false || true;
            bool isTrue5 = !isTrue;

            bool isLarger = 6 > 12;
            bool someExpression = true;
            someExpression &= isLarger;
            #endregion

            #region Exercise04

            double credit = 102;
            double cost = 5;

            double result = credit / cost;

            Console.WriteLine(result);

            #endregion


            #region IfStatement
            //int a = 5;
            //int b = 3;

            //if (a > b)
            //{
            //    Console.WriteLine("5 is larger than 3");
            //}
            //else
            //{
            //    Console.WriteLine("5 is not larger than 3");
            //}

            //Console.WriteLine("Please enter a number");
            //int someNumber = int.Parse(Console.ReadLine());

            //if(someNumber > 0)
            //{
            //    Console.WriteLine("Number is positive");
            //}
            //else if(someNumber < 0)
            //{
            //    Console.WriteLine("Numbet is negative");
            //}
            //else
            //{
            //    Console.WriteLine("MNumber is zero");
            //}

            #endregion
            #region Excersise05
            //int braches = 12;
            //int applesOnBranch = 8;
            //int bascetCapacity = 5;

            //int treeCount = 0;
            //bool isValidInput = 
            //    int.TryParse(Console.ReadLine(), out treeCount);

            //if (isValidInput)
            //{
            //    int result = (applesOnBranch * braches) * treeCount;
            //    if(result % bascetCapacity == 0)
            //    {
            //        Console.WriteLine(result / bascetCapacity);
            //    }
            //    else
            //    {
            //        Console.WriteLine((result / bascetCapacity) + 1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion
            #region Switch

            int day = 3;

            switch(day)
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
            Console.ReadLine();
        }
    }
}
