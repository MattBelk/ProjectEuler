using System;
using System.Diagnostics;

namespace _009
{
    class Program
    {
        public static int Solution()
        {
            //Although we could use number theory to find a more elegant solution, a brute force solution shouldn't be too bad for performance.
            //We can reduce the number of checks needed by noting that, since a < b < c, we have a < sum/3 and b < sum/2.
            const int sum = 1000;
            int a = 0, b = 0, c = 0;
            bool found = false;

            for(a = 1; a < sum / 3; a++)
            {
                for(b = 1; b < sum / 2; b++)
                {
                    //Since a + b + c = sum
                    c = sum - a - b;

                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            return a * b * c;
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
