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