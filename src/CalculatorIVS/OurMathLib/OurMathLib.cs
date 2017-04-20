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
        /// <summary>
        /// Add 2 numbers.
        /// </summary>
        /// <param name="x">The first number to be added.</param>
        /// <param name="y">The second number to be added.</param>
        /// <returns>The sum of 2 number.</returns>
        public static double Add(double x, double y)
        {
            double result = x + y;
            return result;
        }
        /// <summary>
        /// Subtract 2 numbers.
        /// </summary>
        /// <param name="x">The number the function subtract from.</param>
        /// <param name="y">The number the function subtracts.</param>
        /// <returns>The difference of 2 numebers.</returns>
        public static double Subtract(double x, double y)
        {
            double result = x - y;
            return result;
        }
        /// <summary>
        /// Multiplies 2 numbers.
        /// </summary>
        /// <param name="x">The multiplied number.</param>
        /// <param name="y">The multiplied number.</param>
        /// <returns>Multiplied number.</returns>
        public static double Multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }
        /// <summary>
        /// Divides 2 numbers.
        /// </summary>
        /// <param name="x">The number which is being devided.</param>
        /// <param name="y">The divident.</param>
        /// <returns>The fraction of the numbers.</returns>
        public static double Divide(double x, double y)
        {
            if(y == 0)
            {
                throw new InvalidOperationException("Division by 0.");
            }  
            double result = x / y;
            return result;
        }
        /// <summary>
        /// Raises the number to the specified exponent.
        /// </summary>
        /// <param name="inputNumber">The number which is being raised.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The raised number.</returns>
        public static double Power(double inputNumber, double exponent = 2)
        {
            return System.Math.Pow(inputNumber, exponent);
        }
        /// <summary>
        /// Calculates the nth root of the number.
        /// </summary>
        /// <param name="inputNumber">The number the root is calculated from.</param>
        /// <param name="exponent">The nth root.</param>
        /// <returns>The nth root.</returns>
        public static double Root(double inputNumber, double exponent = 2)
        {
            if (inputNumber < 0 && (exponent % 2 == 0))
            {
                throw new ArgumentException("Cannot calculate root.");
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
        /// <summary>
        /// Calculates the factorial.
        /// </summary>
        /// <param name="inputNumber">The number the factorial is calculated from.</param>
        /// <returns>The factorial.</returns>
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
        /// <summary>
        /// Calculates the Logarithm.
        /// </summary>
        /// <param name="inputNumber">The argument.</param>
        /// <param name="logBase">The base.</param>
        /// <returns>The logarithm.</returns>
        public static double Logarithm(double inputNumber, double logBase = System.Math.E)
        {
            if (inputNumber <= 0 || logBase == 1 || logBase <= 0)
            {
                throw new ArgumentException("Cannot calculate log.");
            }
            return System.Math.Log(inputNumber, logBase);
        }
        /// <summary>
        /// Return the absolute value.
        /// </summary>
        /// <param name="inputNumber">The number.</param>
        /// <returns>Return the absolute value.</returns>
        public static double Abs(double inputNumber)
        {
            return System.Math.Abs(inputNumber);
        }
        /// <summary>
        /// Generates random number from x to y.
        /// </summary>
        /// <param name="from">The smallest number which can be generated.</param>
        /// <param name="to">The largest number which can be generated.</param>
        /// <returns>Random number from the interval.</returns>
        public static double Random(int from, int to)
        {
            Random rnd = new Random();
            return rnd.Next(from, to);  // from <= x < to
        }

    }
}
