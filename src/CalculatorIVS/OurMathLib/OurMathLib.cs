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

        public static double PI = GetPI();
        public static double E = GetE();
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

        public static double Power(double inputNumber, double exponent = 2)
        {
            return 1;
        }

        public static double Root(double inputNumber, double exponent = 2)
        {
            return 1;
        }

        public static ulong Factorial(ulong inputNumber)
        {
            ulong result = 1;
            for(uint i = 2; i <= inputNumber; i++) {
                result *= i;
            }
            return result;
        }
        
        public static double Logarithm(double inputNumber)
        {
            return 1;
        }

        public static double Abs(double inputNumber)
        {
            return inputNumber < 0 ? -inputNumber : inputNumber;
        }

        private static double GetPI()
        {
            return 3.14;
        }

        private static double GetE()
        {
            return 2.71;
        }
    }
}
