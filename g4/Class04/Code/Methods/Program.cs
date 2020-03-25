using System;

namespace Methods
{
    class Program
    {
        // Method with no parameters and no return 
        static void CheckDroid1()
        {
            Console.WriteLine("These aren't the droids that you are looking for.");
            Console.ReadLine();
        }

        // Method with parameters and no return 
        static void CheckDroid2(bool isJedi)
        {
            if (isJedi)
            {
                Console.WriteLine("These aren't the droids that you are looking for.");
            } else
            {
                Console.WriteLine("Take the droids. It's fine");
            }
            Console.ReadLine();
        }

        // Method with no parameters and return
        static string JediMindTrick()
        {
            string statement = "Another Jedi statement that will confuse you all";
            return statement;
        }

        // Method with parameters and return
        static string CheckDroids3(bool isJedi)
        {
            if (isJedi)
            {
                return "These aren't the droids that you are looking for.";
            }
            else
            {
                return "Take the droids. It's fine";
            }
        }

        // Extra on demand
        static string ExperimentalMethod(int firstNum, int secondNum, string message)
        {
            int result = firstNum + secondNum;
            string parsedResult = result.ToString();

            return parsedResult;
            
        }


        static void Main(string[] args)
        {
            // Revision from last class
            #region forEach
            //int[] nums = new int[5];
            //nums[0] = 1;
            //nums[1] = 3;
            //nums[2] = 5;
            //nums[3] = 7;
            //nums[4] = 9;

            //int sum = 0;

            //foreach (var num in nums)
            //{
            //    sum += num;
            //}

            ////Console.WriteLine(sum);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter new number");
            //    int inputNumber = int.Parse(Console.ReadLine());
            //    Array.Resize(ref nums, nums.Length + 1);
            //    Console.WriteLine("nums length" + nums.Length);
            //    nums[nums.Length - 1] = inputNumber;
            //}

            ////Console.WriteLine("nums length after looping" + nums.Length);
            #endregion

            #region Method Invocations

            //CheckDroid1();
            //CheckDroid2(false);
            //Console.WriteLine(JediMindTrick());
            //Console.WriteLine(CheckDroids3(true));
            //Console.WriteLine(ExperimentalMethod(2, 3, ""));

            #endregion



            Console.ReadLine();
        }
    }
}
