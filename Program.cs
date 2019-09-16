using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _010
{
    class Program
    {
        //Similar to problem 7, except we have an upper limit on the value of primes, and we want to return the sum.

        public static long Solution()
        {
            const long limit = 2000000;
            long counter = 1;
            bool isPrime = true;
            int j = 0;
            List<long> primes = new List<long>();

            primes.Add(2);

            while (counter < limit)
            {
                counter += 2;
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= counter)
                {
                    if (counter % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(counter);
                }
            }
            return primes.Sum();
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
