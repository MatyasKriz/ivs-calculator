using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurMathLib
{

    public class Math
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
           return Math.Power(inputNumber, exponent);
        }

        public static double Root(double inputNumber, double exponent)
        {
            return Math.Root(inputNumber, exponent);
        }

        public static ulong Factorial(ulong inputNumber)
        {
            //ulong result = 1;
            //for (uint i = 2; i <= inputNumber; i++)
            //{
            //    result *= i;
            //}
            //return result;

            return Math.Factorial(inputNumber);
        }
        
        public static double Logarithm(double inputNumber)
        {
            return Math.Logarithm(inputNumber);
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
