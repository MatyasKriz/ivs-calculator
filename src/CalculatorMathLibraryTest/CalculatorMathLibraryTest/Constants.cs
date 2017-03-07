using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Logarithm
    {
        double delta = OurMathLib.Math.delta;
        #region Constants tests
        [Test]
        public void Pi()
        {
            Assert.AreEqual(Math.PI, OurMathLib.Math.PI, delta);
        }

        [Test]
        public void Euler()
        {
            Assert.AreEqual(Math.E, OurMathLib.Math.E, delta);
        }
        #endregion
    }
}