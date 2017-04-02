using System;
using OurMathLib;


namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vstup:");
            string[] tokens = Console.ReadLine().Split();
            double[] tp = { 1.2, 3.2, 4.2, 4, 4 };

           // int[] myInts = Array.ConvertAll(arr, int.Parse);
            //double vysledek = OurMathLib.Math.Add(1, 3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(tokens[i]);
            }
           // Console.WriteLine("vysledek je " + vysledek);
            
            Console.ReadKey();
        }
    }
}
