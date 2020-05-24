using System;
using System.Diagnostics;
using System.Threading;

namespace lab5_OS
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); 

            int[] C = new int[2];
            // int res = 0;

            for (int j = 500000000; j > 0; j--)
            {
                C[0]+=2;
                //C[0]++;
            }

            C[1] = C[0];

            Console.WriteLine(C[0]);

            stopwatch.Stop();
            TimeSpan interval = TimeSpan.FromTicks(stopwatch.ElapsedTicks);
            string timeInterval = interval.ToString();
            Console.WriteLine("Time of work: " + timeInterval);
        }
    }
}
