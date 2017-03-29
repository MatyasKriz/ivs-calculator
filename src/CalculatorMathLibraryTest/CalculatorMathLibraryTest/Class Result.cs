using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class ResultClass
    {
        double DigitLimit = OurMathLib.Result.DigitLimit;
        double Delta = OurMathLib.Math.Delta;
        OurMathLib.Result result;

        [OneTimeSetUp]
        public void Setup()
        {
            result = new OurMathLib.Result();
        }

        #region ResultClass tests
        [Test]
        public void ResultClass_DefaultValues()
        {
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(0, result.GetCurrentValue());
            Assert.AreEqual("", result.GetCurrentOperationSymbol());
        }

        [Test]
        public void ResultClass_ApplyOperationNone()
        {
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }

        [Test]
        public void ResultClass_InsertNumber()
        {
            result.AddNumber('4');
            result.AddNumber('2');
            Assert.AreEqual(42, result.GetDisplayValue());

            result.AddNumber('0');
            Assert.AreEqual(420, result.GetDisplayValue());
        }

        [Test]
        public void ResultClass_Revert()
        {
            result.SetOperation("sub");
            result.AddNumber('6');
            result.ApplyOperation();
            result.AddNumber('2');
            result.Revert();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(4, result.GetCurrentValue());
            Assert.AreEqual("-", result.GetCurrentOperationSymbol());
        }

        [Test]
        public void ResultClass_Reset()
        {
            result.SetOperation("add");
            result.AddNumber('6');
            result.ApplyOperation();
            result.AddNumber('9');

            result.Reset();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(0, result.GetCurrentValue());
            Assert.AreEqual("+", result.GetCurrentOperationSymbol());
        }

        [Test]
        public void ResultClass_ExceedLimit()
        {
            for(int i = 1; i <= DigitLimit; i++) {
                char number = ((i % 9) + 1).ToString().ToCharArray()[0];
                result.AddNumber(number);
            }
            Assert.Throws<InvalidOperationException>(delegate { result.AddNumber('7'); });
        }

        [Test]
        public void ResultClass_AddLeadingZeroes()
        {
            for(int i = 1; i <= 5; i++) {
                result.AddNumber('0');
            }
            result.AddNumber('6');
            result.AddNumber('7');
            Assert.AreEqual(67, result.GetCurrentValue());
        }

        [Test]
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

        [Test]
        public void ResultClass_ApplyOperation()
        {
            result.SetOperation("sub");
            result.AddNumber('9');
            result.ApplyOperation();
            Assert.AreEqual(-9, result.GetDisplayValue());
            Assert.AreEqual(-9, result.GetCurrentValue());
        }

        [Test]
        public void ResultClass_DivideZero()
        {
            result.SetOperation("div");
            Assert.Throws<InvalidOperationException>(delegate { result.ApplyOperation(); });
        }
        #endregion
    }
}