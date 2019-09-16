using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _007
{
    class Program
    {
        //This problem is solved by simply finding primes until we have found 10001 of them.
        //Primes are added to a list, which is then used to check prime divisors of each number.
        public static int Solution()
        {
            const int limit = 10001;
            int counter = 1;
            bool isPrime = true;
            int j = 0;
            List<int> primes = new List<int>();

            primes.Add(2);

            while (primes.Count < limit)
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
            return primes[limit - 1];
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
