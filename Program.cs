using System;
using System.Diagnostics;

namespace _001
{
    class Program
    {
        //returns the sum of integers up to n, which are divisible by m
        private static int SumDivisible(int m, int n)
        {
            //Sum of integers from 1 to N is N*(N+1)/2, so the sum required is 
            //just m*(N*(N+1)/2), where N = n / m (floor).

            //Number of operations needed is independent of m, n, so this approach is O(1), compared to O(n) using a for loop.

            return m * (n / m) * ((n / m) + 1) / 2;
        }

        public static int Solution()
        {
            //Note that SumDivisible(15,999) returns integers up to 999 divisible by BOTH 3 and 5, which were counted twice.
            return SumDivisible(3,999) + SumDivisible(5,999) - SumDivisible(15, 999);
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
