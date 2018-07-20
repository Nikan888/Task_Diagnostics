using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_Diagnostics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            long[] array = { 56, 84, 98, 142, 45, 96, 32, 65 };

            Console.WriteLine("/// First algorithm ///");
            stopwatch.Start();
            long firstGCD = GCDComputer.FirstGCD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                firstGCD = GCDComputer.FirstGCD(firstGCD, array[i]);
            stopwatch.Stop();
            Console.WriteLine("GCD = {0}", firstGCD);
            Console.WriteLine("Elapsed = {0}", stopwatch.Elapsed);
            Console.WriteLine("----------------------------------------------------------------");
            stopwatch.Reset();

            Console.WriteLine("/// Second algorithm ///");
            stopwatch.Start();
            long secondGCD = GCDComputer.SecondGCD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                secondGCD = GCDComputer.SecondGCD(secondGCD, array[i]);
            stopwatch.Stop();
            Console.WriteLine("GCD = {0}", secondGCD);
            Console.WriteLine("Elapsed = {0}", stopwatch.Elapsed);
            Console.WriteLine("----------------------------------------------------------------");
            stopwatch.Reset();

            Console.WriteLine("/// Third algorithm ///");
            stopwatch.Start();
            long thirdGCD = GCDComputer.ThirdGCD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                thirdGCD = GCDComputer.ThirdGCD(thirdGCD, array[i]);
            stopwatch.Stop();
            Console.WriteLine("GCD = {0}", thirdGCD);
            Console.WriteLine("Elapsed = {0}", stopwatch.Elapsed);
            Console.WriteLine("----------------------------------------------------------------");
            stopwatch.Reset();

            Console.WriteLine("/// Euqlid algorithm ///");
            stopwatch.Start();
            long euqlidGCD = GCDComputer.EuqlidGCDRec(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                euqlidGCD = GCDComputer.EuqlidGCDRec(euqlidGCD, array[i]);
            stopwatch.Stop();
            Console.WriteLine("GCD = {0}", euqlidGCD);
            Console.WriteLine("Elapsed = {0}", stopwatch.Elapsed);
            Console.WriteLine("----------------------------------------------------------------");
            stopwatch.Reset();

            Console.ReadKey();
        }
    }
}
