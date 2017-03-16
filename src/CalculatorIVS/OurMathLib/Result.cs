using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurMathLib
{
    public static class Result
    {
        //TODO: add enumerations based on functions in OurMathLib.Math
        public enum Operation { none, add, subtract, multiply, divide }

        /// <summary>
        /// The number that all operations are applied to.
        /// </summary>
        public static double CurrentNumber = 0;

        /// <summary>
        /// Applied along with Operation to CurrentNumber.
        /// Is on screen all the time.
        /// </summary>
        public static double DisplayNumber = 0;

        public static Operation CurrentOperation = Operation.none;

        /// <summary>
        /// Applies CurrentOperation using DisplayNumber to CurrentNumber if CurrentOperation is set.
        /// </summary>
        public static void ApplyOperation() //TODO: discuss what to do after applying operation, if we should wipe it or leave it the same
        {
            switch(CurrentOperation) {
            case Operation.add:
                CurrentNumber = OurMathLib.Math.Add(CurrentNumber, DisplayNumber);
                break;
            case Operation.subtract:
                CurrentNumber = OurMathLib.Math.Subtract(CurrentNumber, DisplayNumber);
                break;
            case Operation.multiply:
                CurrentNumber = OurMathLib.Math.Multiply(CurrentNumber, DisplayNumber);
                break;
            case Operation.divide:
                CurrentNumber = OurMathLib.Math.Divide(CurrentNumber, DisplayNumber);
                break;
            default:
                return;
            }
            DisplayNumber = CurrentNumber;
        }
    }
}