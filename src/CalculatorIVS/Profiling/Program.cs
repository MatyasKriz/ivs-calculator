using System;
using OurMathLib;


namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = { 1.3, 2.3, 3.4, 4.2, 10, 20};
            int length = input.Length;
            Console.Write("delka: " + length + "\n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(input[i]);
            }

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
                bigsum = OurMathLib.Math.Add(bigsum,3);
                OurMathLib.Math.Subtract(OurMathLib.Math.Power(input[i]), 3);
  
            }

            // Console.WriteLine("vysledek je " + vysledek);

            Console.ReadKey();
        }
    }
}
