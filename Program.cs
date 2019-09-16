using System;
using System.Diagnostics;

namespace _008
{
    //Firstly, there are 0's in the 1000-digit number. Clearly any thirteen adjacent digits where one is 0 have product 0.
    //So we keep go through the number, keeping track of the current product and how many 0's appear in the current 13 digits.
    //Note that the number is well over the limit of the long type, so we'll deal with strings.
    class Program
    {
        public static long Solution()
        {
            const string numberString = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long maxProduct = 1;
            // The product of the current NON-ZERO digits out of the current 13 digits
            long currentProduct = 1;
            int length = numberString.Length;

            // The number of zeros in the current 13 digits.
            int zeros = 0;

            for (int i = 0; i < length; i++)
            {
                //Check if we have 13 digits yet, if so then 'remove the oldest one' (decrement zeros or divide currentProduct accordingly).
                if (i + 1 > 13)
                {
                    if (numberString[i - 13] == '0')
                    {
                        zeros--;
                    }
                    else
                    {
                        currentProduct /= long.Parse(numberString.Substring(i - 13, 1));
                    }
                }

                //If the new digit is 0, increment zeros. Otherwise, multiply currentProduct by the new digit to recalculate currentProduct.
                if (numberString[i] == '0')
                {
                    zeros++;
                }
                else
                {
                    currentProduct *= long.Parse(numberString.Substring(i, 1));
                }

                //If we have 13 digits, none of which are 0, and currentProduct is larger, then update maxProduct.
                if (i + 1 >= 13 && zeros == 0 && currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }
            }
            return maxProduct;
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long result = Solution();
            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Result: {result} \t Time: {time} milliseconds");
            Console.WriteLine("Press any key to quit!");
            Console.ReadKey();
        }
    }
}
