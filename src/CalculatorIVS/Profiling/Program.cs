using System;
using OurMathLib;
using System.Collections.Generic;

namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] input = { 5, 10, 15, 20, 25 };
            //string[] parts = Console.ReadLine().Split(' ');

            //double[] input = Array.ConvertAll(parts.Split(' '), Double.Parse);
            int length = input.Length;
            //Console.Write("delka: " + length + "\n");
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(input[i]);
            //}

            // calculating deviation
            double fraction = (OurMathLib.Math.Divide(1, OurMathLib.Math.Subtract(length, 1)));

            double arithmeticMean = 0;
            double tempsum = 0;
            for (int i = 0; i < length; i++)
            {
                tempsum = OurMathLib.Math.Add(input[i], tempsum);
            }
            arithmeticMean = OurMathLib.Math.Divide(tempsum, length);

            double bigsum = 0;
            for (int i = 0; i < length; i++)
            {
                bigsum = OurMathLib.Math.Add(bigsum, OurMathLib.Math.Power(OurMathLib.Math.Subtract(input[i], arithmeticMean)));
            }

            double deviation = OurMathLib.Math.Root(OurMathLib.Math.Multiply(fraction, bigsum));
            //deviation calculated

            Console.WriteLine("Deviation: " + deviation);
            Console.ReadKey();
        }
    }
}
