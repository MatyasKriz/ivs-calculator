using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Power
    {
        double Delta = OurMathLib.Math.Delta;
        #region Power to 2 tests
        [Test]
        public void Power_PositiveNumber()
        {
            Assert.AreEqual(1, OurMathLib.Math.Power(1));
            Assert.AreEqual(4, OurMathLib.Math.Power(2));
            Assert.AreEqual(2, OurMathLib.Math.Power(OurMathLib.Math.Root(2)), Delta);
        }

        [Test]
        public void Power_Zero()
        {
            Assert.AreEqual(0, OurMathLib.Math.Power(0));
        }

        [Test]
        public void Power_NegativeNumber()
        {
            Assert.AreEqual(1, OurMathLib.Math.Power(-1));
            Assert.AreEqual(4, OurMathLib.Math.Power(-2));
        }
        #endregion

        #region Different exponent tests
        [Test]
        public void Power_DifferentExp_PositiveNumber()
        {
            Assert.AreEqual(1, OurMathLib.Math.Power(1, 3));
            Assert.AreEqual(16, OurMathLib.Math.Power(2, 4));
        }

        [Test]
        public void Power_DifferentExp_Zero()
        {
            Assert.AreEqual(1, OurMathLib.Math.Power(1, 3));
            Assert.AreEqual(16, OurMathLib.Math.Power(2, 4));
            Assert.AreEqual(1, OurMathLib.Math.Power(0, 0));
        }

        [Test]
        public void Power_DifferentExp_NegativeNumber()
        {
            Assert.AreEqual(-27, OurMathLib.Math.Power(-3, 3));
            Assert.AreEqual(-32, OurMathLib.Math.Power(-2, 5));
        }
        #endregion
    }
}