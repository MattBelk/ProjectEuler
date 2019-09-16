using System;
using System.Diagnostics;

namespace _005
{
    class Program
    {
        //The core of this problem is really just finding the least common multiple (lcm) of 1, 2, 3, ... , 20.
        //We can easily find the greatest common divisor (gcd) using Euclid's algorithm, together with the fact that
        //for integers a and b, lcm(a,b) = (a * b) / gcd(a,b).
        //Luckily, we can also use the fact that lcm is associative to save having to deal with 20*19*...*1 (which is VERY large).

        //Finds gcd(a,b) by Euclid's algorithm using recursion
        private static long gcd(long a, long b)
        {
            if(b == 0)
            {
                return a;
            }
            else
            {
                return gcd(b, a % b);
            }
        }

        private static long lcm(long a, long b)
        {
            return (a * b) / gcd(a, b);
        }

        public static long Solution()
        {
            long currentLcm = 1;
            for (long i = 2; i <= 20; i++)
            {
                currentLcm = lcm(currentLcm, i);
            }
            return currentLcm;
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
