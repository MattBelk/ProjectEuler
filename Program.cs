using System;
using System.Diagnostics;

namespace _002
{
    class Program
    {
        //Note that every third term in the Fibonacci sequence is even, and any other term is odd.
        //So we just need to sum every third term. These terms can be calculated without knowing the others!
        //
        //Let the nth term be F(n). Then for n > 6, by substituting at each stage we get
        //F(n) = F(n-1) + F(n-2)
        //     = F(n-2) + 2F(n-3) + F(n-4)              substituting both above
        //     = 3F(n-3) + 2F(n-4)                      substituting F(n-2) above
        //     = 3F(n-3) + F(n-4) + F(n-5) + F(n-6)     substituting one F(n-4) above
        //     = 4F(n-3) + F(n-6) 
        //
        //So we can calculate each third term using the above formula, summing them as we go along.

        public static long Solution()
        {
            // Term 3 behind current
            long fib3 = 2;
            // Term 6 behind current
            long fib6 = 0;
            long fibn = 2;
            long summed = 0;


            while (fibn < 4000000)
            {
                //Add previous fibn
                summed += fibn;
                //Calculate next fibn using the formula above, then set new fib6, fib3
                fibn = 4 * fib3 + fib6;
                fib6 = fib3;
                fib3 = fibn;
            }

            return summed;
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
