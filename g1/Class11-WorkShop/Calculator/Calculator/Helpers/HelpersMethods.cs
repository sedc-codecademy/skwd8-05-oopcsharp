using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Helpers
{
    internal static class HelpersMethods
    {
        internal static decimal CalculateAverage(List<int> numbers)
        {
            int sum = 0;
            numbers.ForEach(number => sum += number);
            return Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Count);
        }

        internal static int FindMaxNumber (List<int>numbers)
        {
            int max = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
