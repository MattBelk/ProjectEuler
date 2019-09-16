using System;
using System.Diagnostics;
using System.Linq;

namespace _004
{
    class Program
    {
        //For this problem, we'll just loop through unique pairs of 3-digit numbers and keep track of the largest palindromic product found.

        private static bool isPalindromic(int number)
        {
            var digits = number.ToString().ToCharArray();
            return digits.SequenceEqual(digits.Reverse());
        }

        public static int Solution()
        {
            int largestPalindrome = 0;

            for (int i = 100; i < 1000; i++)
            {
                //Start j from i to ensure pairs are unique, stops pairs being checked twice
                for (int j = i; j < 1000; j++)
                {
                    int product = i * j;
                    if (product > largestPalindrome && isPalindromic(product))
                    {
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome;
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = Solution();
            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Result: {result} \t Time: {time} milliseconds");
            Console.WriteLine("Press any key to quit!");
            Console.ReadKey();
        }
    }
}
