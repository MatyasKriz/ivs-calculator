using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class ResultClass
    {
        double Delta = OurMathLib.Math.Delta;
        OurMathLib.Result result;

        [SetUp]
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
        public void ResultClass_InsertDecimalNumber()
        {
            result.AddNumber('4');
            result.AddNumber('2');
            Assert.AreEqual(42, result.GetDisplayValue());

            result.AddNumber('0');
            result.AddNumber('.');
            result.AddNumber('6');
            result.AddNumber('9');
            Assert.AreEqual(420.69, result.GetDisplayValue());
        }

        [Test]
        public void ResultClass_Revert()
        {
            result.AddNumber('6');
            result.SetOperation("sub");
            result.AddNumber('2');
            result.ApplyOperation();
            result.AddNumber('9');

            result.Revert();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(4, result.GetCurrentValue());
            Assert.AreEqual("-", result.GetCurrentOperationSymbol());
        }

        [Test]
        public void ResultClass_Reset()
        {
            result.AddNumber('6');
            result.SetOperation("add");
            result.AddNumber('9');
            result.ApplyOperation();
            result.AddNumber('1');

            result.Reset();
            Assert.AreEqual(0, result.GetDisplayValue());
            Assert.AreEqual(0, result.GetCurrentValue());
            Assert.AreEqual("", result.GetCurrentOperationSymbol());
        }


        [Test]
        public void ResultClass_AddLeadingZeroes()
        {
            AddZeroes(5);
            result.AddNumber('6');
            result.AddNumber('7');
            Assert.AreEqual(67, result.GetDisplayValue());
        }

        private void AddZeroes(int through)
        {
            for(int i = 1; i <= through; i++) {
                result.AddNumber('0');
            }
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