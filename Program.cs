using System;
using System.Diagnostics;

namespace _003
{
    class Program
    {
        //We could just brute force this one by looping through and finding which integers are divisors,
        //and then checking primality, but that will be extremely slow.
        //Instead, we can use a similar algorithm to finding the prime decomposition of an integer. Such a decomposition
        //is guaranteed by the Fundamental Theorem of Arithmetic.
        //Note that we don't care for finding each prime factor, just the highest one.
        //
        //To do this, we can use a counter to loop through possible factors, and at each stage:
        // * Check whether it divides the current number
        // * If so, set the current number to itself divided by the counter, and set the largest prime factor to the counter
        // * Otherwise, increment the counter
        //
        //Note that the counter doesn't need to only consist of primes, since we divide the current number by 
        //any factor which is found. So if the counter divides the current number, it will be prime

        public static long Solution()
        {
            const long number = 600851475143;
            long currentNumber = number;
            long largestPrimeFactor = 0;
            //Check the prime 2 first
            int counter = 2;

            //Check currentNumber for prime factors (doesn't check whether currentNumber itself is prime)
            //Note that if the largest prime factor only appears once in the prime factorisation,
            //then the loop will end with currentNumber > largestPrimeFactor, and currentNumber will be this largest prime.
            while (counter * counter < currentNumber)
            {
                if (currentNumber % counter == 0)
                {
                    currentNumber /= counter;
                    largestPrimeFactor = counter;
                }
                else
                {
                    counter++;
                }
            }
            //As in the above note, we need to check the case when the largest prime factor appears once, and is currentNumber at the end of the loop
            if (currentNumber > largestPrimeFactor)
            {
                largestPrimeFactor = currentNumber;
            }
            return largestPrimeFactor;
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
