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
        public enum Operation { none, add, subtract, multiply, divide }

        /// <summary>
        /// The number of digits that can be displayed in the textbox.
        /// </summary>
        public const double DigitLimit = 15;

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

            return CurrentOperation.ToString();
        }

        /// <summary>
        /// Adds a digit to DisplayValue
        /// </summary>
        /// <param name="number">A digit or an operation to be added</param>
        /// <returns>True on success; False otherwise</returns>
        public void AddNumber(char number)
        {
            int numToAdd = 0;
            try
            {
                numToAdd = (int)number;
                Console.WriteLine(numToAdd);
            }
            catch (InvalidCastException e)
            {
                if (number == ',' || number == '.')
                {
                    if (!isDecimal)
                    {
                        isDecimal = true;
                    }
                    return;
                }
                errMessage = e.Message;
                return;
            }
            if (!isDecimal)
            {
                displayValue *= 10;
                displayValue += numToAdd;
            }
            else
            {
                //TODO
                return;

            }
            if (displayValue.ToString().Length >= DigitLimit)
            {
                errMessage = "The number of digits exceed the DigitLimit";
            }
            return;
        }

        /// <summary>
        /// Sets DisplayValue to 0, CurrentValue doesn't change
        /// </summary>
       public void Revert()
        {
            displayValue = 0;
            errMessage = null;
        }

        /// <summary>
        /// Sets both DisplayValue and CurrentValue to 0
        /// </summary>
        public void Reset()
        {
            displayValue = 0;
            currentValue = 0;
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
            case "plus":
                CurrentOperation = Operation.add;
                break;
            case "minus":
                CurrentOperation = Operation.subtract;
                break;
            case "mul":
                CurrentOperation = Operation.multiply;
                break;
            case "div":
                CurrentOperation = Operation.divide;
                break;
            default:
                CurrentOperation = Operation.none;
                break;
            }
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
            default:
                return;
            }
            displayValue = currentValue;
        }
    }
}