using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Logarithm
    {
        double Delta = OurMathLib.Math.Delta;
        #region Constants tests
        [Test]
        public void Pi()
        {
            Assert.AreEqual(Math.PI, OurMathLib.Math.PI, Delta);
        }

        [Test]
        public void Euler()
        {
            Assert.AreEqual(Math.E, OurMathLib.Math.E, Delta);
        }
        #endregion
    }
}