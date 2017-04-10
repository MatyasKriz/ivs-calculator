using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurMathLib
{
    public class Math
    {
        /// <summary>
        /// We guarantee our functions to be this precise.
        /// </summary>
        public static double Delta = 0.0000001;

        public static double PI = System.Math.PI;
        public static double E = System.Math.E;
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
            if(y == 0)
            {
                throw new Exception("Division by 0.");
            }  
            double result = x / y;
            return result;
        }

        public static double Power(double inputNumber, double exponent = 2)
        {
            return System.Math.Pow(inputNumber, exponent);
        }

        public static double Root(double inputNumber, double exponent = 2)
        {
            if (inputNumber < 0 && (exponent % 2 == 0))
            {
                throw new Exception("Cannot calculate root.");
            }
            if (inputNumber < 0 && (exponent % 2 == 1))
            {
                return -(System.Math.Pow(-inputNumber, 1 / exponent));
            }
            else
            {
                return System.Math.Pow(inputNumber, 1 / exponent);
            }
        }

        public static double Factorial(double inputNumber)
        {

            double result = 1;
            for(ulong i = 2; i <= inputNumber; i++) {
                result *= i;
                if (double.IsInfinity(result))  
                {
                    break;
                }
            }
            return result;
        }

        public static double Logarithm(double inputNumber, double logBase = System.Math.E)
        {
            if (inputNumber <= 0 || logBase == 1 || logBase <= 0)
            {
                throw new ArgumentException("Cannot calculate log.");
            }
            return System.Math.Log(inputNumber, logBase);
        }

        public static double Abs(double inputNumber)
        {
            return System.Math.Abs(inputNumber);
        }

        public static double Random(int from, int to)
        {
            Random rnd = new Random();
            return rnd.Next(from, to);  // from <= x < to
        }

    }
}
