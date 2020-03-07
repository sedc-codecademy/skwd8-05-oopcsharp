using System;

namespace SEDC.Class02.DataEntryAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ReadFromInput
            string readLine = Console.ReadLine();
            Console.WriteLine(readLine);
            #endregion

            #region DataCOnversion

            string numberString = "2asd";
            string doubleString = "2.5";

            //int parseInt = int.Parse(numberString);
            //double parseDoube = double.Parse(doubleString);

            //int convertedInt = Convert.ToInt32(numberString);
            //double converttoDouble = Convert.ToDouble(doubleString);

            int tryParsed = 0;
            bool isVaild = int.TryParse(numberString, out tryParsed);
            double doubleTryParsed = 0;
            bool isValidDouble = double.TryParse(doubleString, out doubleTryParsed);

            //int casted = (int)doubleTryParsed; 

            Console.WriteLine(tryParsed);

            #endregion

            Console.ReadLine();
        }
    }
}
