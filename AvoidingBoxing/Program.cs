using AvoidingBoxing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AvoidingBoxing
{
    class Program
    {
        private const int pointsInSpaceR3 = 10_000_000;
        static void Main(string[] args)
        {
            using Process process = Process.GetCurrentProcess();
            Console.WriteLine($"{ConvertBytesToMegabytes(GC.GetTotalMemory(false))} used memory before.");

            var points = new List<PontoNoEspacoR3>(pointsInSpaceR3);

            for (var i = 0; i < pointsInSpaceR3; i++)
            {
                points.Add(new PontoNoEspacoR3
                {
                    X = i,
                    Y = i,
                    Z = i
                });
            }

            Console.WriteLine($"{ConvertBytesToMegabytes(GC.GetTotalMemory(false))} used memory after.");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }

        static string ConvertBytesToMegabytes(long bytes)
        {
            return ((bytes / 1024f) / 1024f).ToString("0.00") + " MB";
        }

    }


}