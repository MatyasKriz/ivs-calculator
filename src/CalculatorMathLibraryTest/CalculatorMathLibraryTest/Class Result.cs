using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class ResultClass
    {
<<<<<<< HEAD
        double DigitLimit = OurMathLib.result.DigitLimit;
        OurMathLib.result result;
=======
        double DigitLimit = OurMathLib.Result.DigitLimit;
        double Delta = OurMathLib.Math.Delta;
        OurMathLib.Result result;
>>>>>>> refs/remotes/origin/Result-class

        [OneTimeSetUp]
        public void Setup()
        {
            result = new OurMathLib.result();
        }

        #region ResultClass tests
        public void ResultClass_DefaultValues()
        {
<<<<<<< HEAD
            Assert.AreEqual(0, result.DisplayValue);
            Assert.AreEqual(0, result.CurrentValue);
            Assert.AreEqual(OurMathLib.result.Operation.none, result.CurrentOperation);
=======
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(0, result.GetCurrentValue());
            Assert.AreEqual(OurMathLib.Result.Operation.none, result.CurrentOperation);
>>>>>>> refs/remotes/origin/Result-class
        }

        public void ResultClass_ApplyOperationNone()
        {
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }

        public void ResultClass_InsertNumber()
        {
            result.AddNumber('4');
            result.AddNumber('2');
            Assert.AreEqual(42, result.GetDisplayValue());

            result.AddNumber('0');
            Assert.AreEqual(420, result.GetDisplayValue());
        }

        public void ResultClass_Revert()
        {
            result.SetOperation(OurMathLib.Result.Operation.add);
            result.AddNumber('6');
            result.ApplyOperation();
            result.AddNumber('2');
            result.Revert();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(6, result.GetCurrentValue());
        }

        public void ResultClass_Reset()
        {
            result.SetOperation(OurMathLib.Result.Operation.add);
            result.AddNumber('6');
            result.ApplyOperation();
            result.AddNumber('9');

            result.Reset();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(0, result.GetCurrentValue());
        }

        public void ResultClass_ExceedLimit()
        {
            for(int i = 1; i <= DigitLimit; i++) {
                result.AddNumber((i % 9) + 1);
            }
            Assert.Throws<InvalidOperationException>(delegate { result.AddNumber(7); });
        }

        public void ResultClass_AddLeadingZeroes()
        {
            for(int i = 1; i <= 5; i++) {
                result.AddNumber('0');
            }
            result.AddNumber('6');
            result.AddNumber('7');
            Assert.AreEqual(67, result.GetCurrentValue());
        }

        public void ResultClass_AddTrailingZeroes()
        {
            result.AddNumber('2');
            result.AddNumber('3');
            result.AddNumber('4');

            result.AddNumber('.');

            result.AddNumber('3');
            result.AddNumber('5');

            for(int i = 1; i <= 5; i++) {
                result.AddNumber('0');
            }
            Assert.AreEqual(234.35, result.GetCurrentValue(), Delta);
        }

        public void ResultClass_AddNumbersInAscii()
        {
            Assert.DoesNotThrow<ArgumentException>(delegate { result.AddNumber(53); });
            Assert.Throws<ArgumentException>(delegate { result.AddNumber(65); });
        }

        public void ResultClass_ApplyOperation()
        {
<<<<<<< HEAD
            result.AddOperation(OurMathLib.result.Operation.subtract);
=======
            result.SetOperation(OurMathLib.Result.Operation.subtract);
            result.AddNumber('9');
>>>>>>> refs/remotes/origin/Result-class
            result.ApplyOperation();
            Assert.AreEqual(-9, result.GetDisplayValue());
            Assert.AreEqual(-9, result.GetCurrentValue());
        }

        public void ResultClass_DivideZero()
        {
<<<<<<< HEAD
            result.AddOperation(OurMathLib.result.Operation.divide);
=======
            result.SetOperation(OurMathLib.Result.Operation.divide);
>>>>>>> refs/remotes/origin/Result-class
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }
        #endregion
    }
}