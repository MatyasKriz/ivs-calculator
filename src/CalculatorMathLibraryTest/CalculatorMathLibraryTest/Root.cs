using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Root
    {
        double delta = OurMathLib.Math.delta;
        #region Root tests
        [Test]
        public void Root_PositiveNumber()
        {
            Assert.AreEqual(1, OurMathLib.Math.Root(1));
            Assert.AreEqual(2, OurMathLib.Math.Root(4));
            Assert.AreEqual(Math.Sqrt(2), OurMathLib.Math.Root(2), delta);
        }

        public void Root_Zero()
        {
            Assert.AreEqual(0, OurMathLib.Math.Root(0));
        }

        public void Root_NegativeNumber()
        {
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Root(-1); });
        }
        #endregion
    }
}