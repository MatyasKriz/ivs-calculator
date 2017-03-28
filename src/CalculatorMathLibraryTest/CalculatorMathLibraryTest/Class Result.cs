using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class ResultClass
    {
        double DigitLimit = OurMathLib.Result.DigitLimit;
        OurMathLib.Result result;

        [OneTimeSetUp]
        public void Setup()
        {
            result = new OurMathLib.Result();
        }

        #region ResultClass tests
        public void ResultClass_DefaultValues()
        {
            Assert.AreEqual(0, result.DisplayValue);
            Assert.AreEqual(0, result.CurrentValue);
            Assert.AreEqual(OurMathLib.Result.Operation.none, result.CurrentOperation);
        }

        public void ResultClass_ApplyOperationNone()
        {
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }

        public void ResultClass_InsertNumber()
        {
            result.AddNumber(4);
            result.AddNumber(2);
            Assert.AreEqual(42, result.DisplayValue);

            result.AddNumber(0);
            Assert.AreEqual(420, result.DisplayValue);
        }

        public void ResultClass_Revert()
        {
            result.AddNumber(9);
            result.Revert();
            Assert.AreEqual(0, result.DisplayValue);
        }

        public void ResultClass_Reset()
        {
            result.AddNumber(9);
            result.Reset();
            Assert.AreEqual(0, result.DisplayValue);
            Assert.AreEqual(0, result.CurrentValue);
        }

        public void ResultClass_ExceedLimit()
        {
            for(int i = 1; i <= DigitLimit; i++) {
                result.AddNumber((i % 9) + 1);
            }
            Assert.Throws<InvalidOperationException>(delegate { result.AddNumber(7); });
        }

        public void ResultClass_AddPrecedingZeroes()
        {
            for(int i = 1; i <= 5; i++) {
                result.AddNumber(0);
            }
            ResultClass_InsertNumber();
        }

        public void ResultClass_AddWrongNumber()
        {
            Assert.Throws<ArgumentException>(delegate { result.AddNumber(-7); });
            Assert.Throws<ArgumentException>(delegate { result.AddNumber(42); });
            Assert.Throws<ArgumentException>(delegate { result.AddNumber(5.5); });
        }

        public void ResultClass_ApplyOperation()
        {
            result.AddOperation(OurMathLib.Result.Operation.subtract);
            result.ApplyOperation();
            Assert.AreEqual(-420, result.DisplayValue);
            Assert.AreEqual(-420, result.CurrentValue);
        }

        public void ResultClass_DivideZero()
        {
            result.AddOperation(OurMathLib.Result.Operation.divide);
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }
        #endregion
    }
}