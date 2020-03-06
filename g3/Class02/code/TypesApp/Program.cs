using System;

namespace TypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // use the "+" sign, just after the line number 10, to open this region
            #region var
            //var name; // "var" cannot be used this way, it must have initialization
            //var name = "Dejan";
            //name = 5; // Also once the type is determened, it cannot be changed to another type like int
            #endregion

            #region types
            //string name; // null by default
            //name = "Dejan"; // For String we must use double quotes
            //char firstLetter = 'D'; // Single quotes must be used for char

            //byte ageByte = 255; // 255 is the maximum number that byte can hold
            //int ageInt = 256; // The limit of int is a little bit bigger
            //long ageLong = 3432244311321312222; // The limit of long is alot bigger
            //double ageDouble = 257.7; // Double is the type for decimal numbers, there are also float and decimal types
            #endregion

            #region type conversion

            //double shoeSize = "46"; // Doesn't work
            //double shoeSize = double.Parse("46"); // We must convert the type from string to double first
            //double shoeSize = double.Parse("Cetiries i shesh"); // Will throw an exception

            //double shoeSize;
            //bool isSuccess = double.TryParse("46", out shoeSize); // TryParse returns true or false depending on whether the convertion is successfull or not, and if successful, it also sets the variable that we pass as a second parameter with the out to the converted value
            //if (isSuccess) Console.WriteLine(shoeSize);
            //else Console.WriteLine("Error happend");

            //var toseAge = 0;
            //var toseAge = 1;
            //var toseAge = "true";
            //var toseAge = "false";
            //var toseAge = "";
            //bool toseDouble = Convert.ToBoolean(toseAge); // Similar to truthy/falsy in JavaScript
            //Console.WriteLine(toseDouble);
            #endregion

            #region implicit/explicit conversion
            //byte num1 = 255;
            //int num2 = 25633;
            //long num3 = 338739783393897893;
            //long result  = num2; // num2(int) can be implicitly converted and stored in result(long)
            //byte result = num3; // num3 cannot be implictly converted and stored in byte
            //string result = "dushko"; // also "dushko" cannot be implictly converted

            //long resultString = Convert.ToInt64("5363"); // We must use explicit conversion if we want to convert string to long/int/byte...
            #endregion

            #region read from a console
            string userInput = Console.ReadLine();
            int userInputInt;
            if (!int.TryParse(userInput, out userInputInt))
                Console.WriteLine("Decko vnesni broj!");
            else
                Console.WriteLine($"Decko ti si super! brojot sto go vnesi e: {userInputInt} test: {userInputInt - 10}");
            #endregion

            Console.ReadLine();
        }
    }
}
