using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolku drva imas?");
            string inputTree = Console.ReadLine();
            int noOfTrees;
            var successTreeParse = int.TryParse(inputTree, out noOfTrees);
            if (successTreeParse)
            {
                Console.WriteLine("Kolku jabolka ima na edna granka?");
                if (int.TryParse(Console.ReadLine(), out int noOfApples))
                {
                    Console.WriteLine("Kolku jabolka sobira edna kosnica?");
                    if (int.TryParse(Console.ReadLine(), out int noBucketCapacity))
                    {
                        float totalApples = noOfTrees * 12 * noOfApples;
                        float buckets = totalApples / noBucketCapacity;

                        var bucketsCorrect = Math.Ceiling(buckets);

                        Console.WriteLine("Ti trebaat: " + bucketsCorrect + " korpi.");
                    }
                    else
                    {
                        Console.WriteLine("Ne vnese pravilen broj na jabolka sto gi sobira vo edna kosnica.");
                    }
                }
                else
                {
                    Console.WriteLine("Ne vnese pravilen broj na jabolka.");
                }
            }
            else
            {
                Console.WriteLine("Ne vnese pravilen broj na drva.");
            }
        }
    }
}
