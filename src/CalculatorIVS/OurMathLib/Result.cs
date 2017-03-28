using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurMathLib
{
    public class result
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
        public double CurrentValue = 0;

        /// <summary>
        /// Applied along with Operation to CurrentNumber.
        /// Is on screen all the time.
        /// </summary>
        public double DisplayValue = 0;

        public Operation CurrentOperation = Operation.none;

        /// <summary>
        /// Adds a digit to DisplayValue
        /// </summary>
        /// <param name="number">A digit to be added</param>
        /// <returns>True on success; False otherwise</returns>
        public bool AddNumber(int number)
        {
            //TODO

            return true;
        }

        /// <summary>
        /// Sets DisplayValue to 0, CurrentValue doesn't change
        /// </summary>
       public void Revert()
        {
            DisplayValue = 0;

        }

        /// <summary>
        /// Sets both DisplayValue and CurrentValue to 0
        /// </summary>
        public void Reset()
        {
            DisplayValue = 0;
            CurrentValue = 0;
        }


        public void AddOperation(Operation op)
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
                CurrentValue = OurMathLib.Math.Add(CurrentValue, DisplayValue);
                break;
            case Operation.subtract:
                CurrentValue = OurMathLib.Math.Subtract(CurrentValue, DisplayValue);
                break;
            case Operation.multiply:
                CurrentValue = OurMathLib.Math.Multiply(CurrentValue, DisplayValue);
                break;
            case Operation.divide:
                CurrentValue = OurMathLib.Math.Divide(CurrentValue, DisplayValue);
                break;
            default:
                return;
            }
            DisplayValue = CurrentValue;
        }
    }
}