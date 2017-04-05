using System;
using OurMathLib;
using System.Collections.Generic;
using System.Linq;

namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(token => double.Parse(token)); // input in the format eg. "3,3 2,42 9,01"

            double[] input = numbers.ToArray();
            int length = input.Length;

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
