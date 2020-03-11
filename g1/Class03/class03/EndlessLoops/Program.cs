using System;

namespace EndlessLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // increment/decrement
            int number = 1;

            // we use it for checking if input from console is successfully converted
            bool result;

            while (true)
            {
                Console.WriteLine("Please enter a number:");

                result = int.TryParse(Console.ReadLine(), out number);

                // checking if number is converted successfully
                // if not we want to go to beggining ask the user to enter a number
                // note that if number is not converted all code after "continue" wont be executed
                if (result == false)
                    continue;

                // this code will be executed if result == true which means user entered number
                Console.WriteLine("Congratulations, you entered a number !");
                break;

            }

            // This example is the same but implemented with for instead with while
            // in this case we dont set condition which means that loop will be endless

            int num;
            bool res;
            for (int i=0; ;i++)
            {
                Console.WriteLine("Please enter a number:");

                res = int.TryParse(Console.ReadLine(), out num);

                if (res == false)
                    continue;

                Console.WriteLine("Congratulations, you entered a number");
                break;
            }
            Console.ReadLine();
        }

    }
}
