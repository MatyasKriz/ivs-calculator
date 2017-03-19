namespace OurMathLib
{
    using System;
    public class OurMath
    {
        public static double Delta = 0.0000001; //how precise we guarantee our functions to be

        public static double PI = GetPI(); // needs to add const
        public static double E = GetE(); // same
        public static double Add(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public static double Subtract(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public static double Multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }

        public static double Divide(double x, double y)
        {
            double result = x / y;
            return result;
        }

        public static double Power(double inputNumber, double exponent)
        {
           return Math.Pow(inputNumber, exponent);
        }

        public static double Root(double inputNumber)
        {
            return Math.Sqrt(inputNumber);
            // square root of the number
        }

        public static ulong Factorial(ulong inputNumber)
        {
            // improve data types
            ulong x = 1;
            ulong m = inputNumber;

            for (ulong i = inputNumber; i > 0; i--)
            {
                x = x * m;
                m--;
            }
            return x;
        }
        
        public static double Logarithm(double inputNumber, double inputNumber2)
        {
            return Math.Log(inputNumber, inputNumber2);
        }

        public static double Abs(double inputNumber)
        {
            return Math.Abs(inputNumber);
        }

        private static double GetPI()
        {
            return Math.PI;
        }

        private static double GetE()
        {
            return Math.E;
        }
    }
}
