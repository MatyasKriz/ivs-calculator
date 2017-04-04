using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurMathLib
{
    public class Result
    {
        //TODO: add enumerations based on functions in OurMathLib.Math
        public enum Operation { none, add, subtract, multiply, divide, power2, powern, lognatur, logx, fact, sqrt, nthroot}

        /// <summary>
        /// The number that all operations are applied to.
        /// </summary>
        private double currentValue = 0;

        /// <summary>
        /// Applied along with Operation to currentValue.
        /// Is on screen all the time.
        /// </summary>
        private double displayValue = 0;

        /// <summary>
        /// Indicates whether the input number is it's decimal part
        /// </summary>
        private bool isDecimal = false;

        /// <summary>
        /// Counts the position of the next decimal number
        /// </summary>
        private int numOfDecimalDigs = 1;

        public Operation CurrentOperation = Operation.none;


        /// <summary>
        /// Returns the displayValue
        /// </summary>
        /// <returns>Value of displayValue</returns>
        public double GetDisplayValue()
        {
            return displayValue;
        }

        /// <summary>
        /// Returns the currentValue
        /// </summary>
        /// <returns>Value of currentValue</returns>
        public double GetCurrentValue()
        {
            return currentValue;
        }

        /// <summary>
        /// Returns the string representation of the current operation symbol
        /// </summary>
        /// <returns>String of the current operation</returns>
        public string GetCurrentOperationSymbol()
        {
            string toReturn = "";
            switch (CurrentOperation)
            {
            case Operation.add:
                toReturn = "+";
                break;
            case Operation.subtract:
                toReturn = "-";
                break;
            case Operation.multiply:
                toReturn = "*";
                break;
            case Operation.divide:
                toReturn = "/";
                break;
            case Operation.power2:
                toReturn = "^2";
                break;
            case Operation.powern:
                toReturn = "x^n";
                break;
            case Operation.lognatur:
                toReturn = "log_e";
                break;
            case Operation.logx:
                toReturn = "log_x";
                break;
            case Operation.fact:
                toReturn = "!";
                break;
            case Operation.sqrt:
                toReturn = "2^√";
                break;
            case Operation.nthroot:
                toReturn = "n^√";
                break;

            default:
                toReturn = "";
                break;
            }

            return toReturn;
        }

        /// <summary>
        /// Adds a digit to displayValue
        /// </summary>
        /// <param name="number">A digit or an operation to be added</param>
        public void AddNumber(char number)
        {
            double numToAdd = 0;
            try
            {
                numToAdd = double.Parse(number.ToString());
            }
            catch (FormatException e)
            {
                if (number == '.')
                {
                    if (!isDecimal)
                    {
                        isDecimal = true;
                    }
                    return;
                }
                else if (number == 'e')
                {
                    displayValue = OurMathLib.Math.E;
                    return;
                }
                else if (number == 'p')
                {
                    displayValue = OurMathLib.Math.PI;
                    return;
                }
                throw new Exception(e.Message);
            }
            if (!isDecimal)
            {
                if (displayValue == 0.0 && numToAdd == 0)
                {
                    //Do nothing - leading zeroes
                }
                else
                {
                    displayValue *= 10;
                    displayValue += numToAdd;
                }
            }
            else
            {
                double numToDiv = Math.Power(10, numOfDecimalDigs);
                numToAdd /= numToDiv;
                numOfDecimalDigs++;
                displayValue += numToAdd;
            }
        }

        /// <summary>
        /// Sets displayValue to 0, currentValue doesn't change
        /// </summary>
       public void Revert()
        {
            displayValue = 0;
            numOfDecimalDigs = 1;
            isDecimal = false;
        }

        /// <summary>
        /// Sets both displayValue and currentValue to 0
        /// </summary>
        public void Reset()
        {
            displayValue = 0;
            currentValue = 0;
            numOfDecimalDigs = 1;
            isDecimal = false;
        }

        /// <summary>
        /// Sets the currentOperation to the op param
        /// </summary>
        /// <param name="op">String of the operation</param>
        public void SetOperation(string op)
        {
            switch(op) {
            case "add":
                CurrentOperation = Operation.add;
                break;
            case "sub":
                CurrentOperation = Operation.subtract;
                break;
            case "mul":
                CurrentOperation = Operation.multiply;
                break;
            case "div":
                CurrentOperation = Operation.divide;
                break;
            case "sqrt":
                CurrentOperation = Operation.sqrt;
                displayValue = OurMathLib.Math.Root(displayValue);
                numOfDecimalDigs = 1;
                isDecimal = false;
                return;
                
            case "pow":
                CurrentOperation = Operation.powern;
                break;
            case "pow2":
                CurrentOperation = Operation.power2;
                displayValue = OurMathLib.Math.Power(displayValue);
                numOfDecimalDigs = 1;
                isDecimal = false;
                return;
            case "fact":
                CurrentOperation = Operation.fact;
                displayValue = OurMathLib.Math.Factorial(displayValue);
                numOfDecimalDigs = 1;
                isDecimal = false;
                return;
            case "ln":
                CurrentOperation = Operation.lognatur;
                break;
            case "logx":
                CurrentOperation = Operation.logx;
                break;
            case "nthroot":
                CurrentOperation = Operation.nthroot;
                break;
            default:
                CurrentOperation = Operation.none;
                break;
            }
            currentValue = displayValue;
            Revert();
        }

        /// <summary>
        /// Applies CurrentOperation using displayValue to currentValue if CurrentOperation is set.
        /// </summary>
        public void ApplyOperation() 
        {
            switch(CurrentOperation) {
            case Operation.add:
                currentValue = OurMathLib.Math.Add(currentValue, displayValue);
                break;
            case Operation.subtract:
                currentValue = OurMathLib.Math.Subtract(currentValue, displayValue);
                break;
            case Operation.multiply:
                currentValue = OurMathLib.Math.Multiply(currentValue, displayValue);
                break;
            case Operation.divide:
                currentValue = OurMathLib.Math.Divide(currentValue, displayValue);
                break;
            case Operation.fact:
                currentValue = OurMathLib.Math.Factorial(displayValue);
                break;
            case Operation.lognatur:
                //CHECK for solutions
                currentValue = OurMathLib.Math.Logarithm(displayValue);
                break;
            case Operation.logx:
                //CHECK for solutions
                currentValue = OurMathLib.Math.Logarithm(displayValue, currentValue);
                break;
            case Operation.nthroot:
                //CHECK 
                currentValue = OurMathLib.Math.Root(displayValue, currentValue);
                break;
            case Operation.sqrt:
                //CHECK
                currentValue = OurMathLib.Math.Root(displayValue);
                break;
            case Operation.power2:
                currentValue = OurMathLib.Math.Power(currentValue);
                break;
            case Operation.powern:
                //CHECK
                currentValue = OurMathLib.Math.Power(currentValue, displayValue);
                break;
            default:
                return;
            }
            displayValue = currentValue;
        }
    }
}