using System;
using System.Diagnostics;

namespace _006
{
    class Program
    {
        //Rather than calculate each expression and take the difference, note that
        //the sum of the first n natural numbers is n*(n+1)/2, and that the sum of the 
        //squares of the first n natural numbers is n*(n+1)*(2n+1)/6.
        //This gives us a very simple way to solve the problem, rather than brute force.

        public static long Solution()
        {
            const long n = 100;
            long sum = (n * (n + 1)) / 2;
            long squares = (n * (n + 1) * (2 * n + 1)) / 6;
            return sum * sum - squares;
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
