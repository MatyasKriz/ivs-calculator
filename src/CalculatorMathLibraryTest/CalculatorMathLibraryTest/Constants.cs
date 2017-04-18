using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Constants
    {
        double delta = OurMathLib.Math.Delta;
        #region Constants tests
        [Test]
        public void Pi()
        {
            Assert.AreEqual(System.Math.PI, OurMathLib.Math.PI, delta);
        }

        [Test]
        public void Euler()
        {
            Assert.AreEqual(System.Math.E, OurMathLib.Math.E, delta);
        }
        #endregion
    }
}