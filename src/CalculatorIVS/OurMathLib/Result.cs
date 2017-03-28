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
        static public double DigitLimit = 15;

        /// <summary>
        /// The number that all operations are applied to.
        /// </summary>
        private double currentValue = 0;

        /// <summary>
        /// Applied along with Operation to CurrentNumber.
        /// Is on screen all the time.
        /// </summary>
        private double displayValue = 0;

        /// <summary>
        /// If any errors occur, the error message will be stored here
        /// </summary>
        private string? errMessage = null;
    

        public Operation CurrentOperation = Operation.none;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string? GetErrMessage()
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

        /// <summary>
        /// Adds a digit to DisplayValue
        /// </summary>
        /// <param name="number">A digit or an operation to be added</param>
        /// <returns>True on success; False otherwise</returns>
        public bool AddNumber(char number)
        {
            //TODO
            
            try
            {
                int numToAdd = (int)number;
            }
            catch (InvalidCastException e)
            {
                if (number == ',' || number == '.')
                {
                    return false;
                }
            }
            displayValue += number;

            return true;
        }

        /// <summary>
        /// Sets DisplayValue to 0, CurrentValue doesn't change
        /// </summary>
       public void Revert()
        {
            displayValue = 0;

        }

        /// <summary>
        /// Sets both DisplayValue and CurrentValue to 0
        /// </summary>
        public void Reset()
        {
            displayValue = 0;
            currentValue = 0;
        }

        /// <summary>
        /// Sets the currentOperation to the op param
        /// </summary>
        /// <param name="op">String of the operation</param>
        public void SetOperation(string op)
        {
            //TODO
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