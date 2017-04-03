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
        private bool isDecimal = false;

        /// <summary>
        /// Applied along with Operation to CurrentNumber.
        /// Is on screen all the time.
        /// </summary>
        private double displayValue = 0;

        /// <summary>
        /// If any errors occur, the error message will be stored here
        /// </summary>
        private string errMessage = "";
    

        public Operation CurrentOperation = Operation.none;

        /// <summary>
        /// Return the error message set 
        /// </summary>
        /// <returns></returns>
        public string GetErrMessage()
        {
            return errMessage;
        }

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


        private int numOfDecimalDigs = 1;

        /// <summary>
        /// Returns the string representation of the current operation symbol
        /// </summary>
        /// <returns>String of the current operation</returns>
        public string GetCurrentOperationSymbol()
        {
            string toReturn = "";
            switch (CurrentOperation)
            {
            case Operation.none:
                toReturn = "";
                break;
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
        /// Adds a digit to DisplayValue
        /// </summary>
        /// <param name="number">A digit or an operation to be added</param>
        /// <returns>True on success; False otherwise</returns>
        public void AddNumber(char number)
        {
            double numToAdd = 0;
            try
            {
                numToAdd = double.Parse(number.ToString());
            }
            catch (FormatException e)
            {
                if (number == ',' )
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
                }
                errMessage = e.Message;
                return;
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
        /// Sets DisplayValue to 0, CurrentValue doesn't change
        /// </summary>
       public void Revert()
        {
            displayValue = 0;
            numOfDecimalDigs = 0;
            isDecimal = false;
            errMessage = null;
        }

        /// <summary>
        /// Sets both DisplayValue and CurrentValue to 0
        /// </summary>
        public void Reset()
        {
            displayValue = 0;
            currentValue = 0;
            numOfDecimalDigs = 0;
            isDecimal = false;
            errMessage = null;
        }

        /// <summary>
        /// Sets the currentOperation to the op param
        /// </summary>
        /// <param name="op">String of the operation</param>
        public void SetOperation(string op)
        {
            //TODO: add all
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
                break;
            case "pow":
                CurrentOperation = Operation.powern;
                break;
            case "pow2":
                CurrentOperation = Operation.power2;
                break;
            case "fact":
                CurrentOperation = Operation.fact;
                break;
            case "logn":
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
        /// Applies CurrentOperation using DisplayNumber to CurrentNumber if CurrentOperation is set.
        /// </summary>
        public void ApplyOperation() //TODO: discuss what to do after applying operation, if we should wipe it or leave it the same
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
                //CHECK for solutions
                currentValue = OurMathLib.Math.Factorial((ulong)displayValue); ///////////////////////
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
            case Operation.none:
                throw new System.InvalidOperationException("No operation selected");
            default:
                return;
            }
            displayValue = currentValue;
        }
    }
}