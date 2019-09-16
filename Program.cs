﻿using System;
using System.Diagnostics;

namespace _002
{
    class Program
    {
        

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
