﻿using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Logarithm
    {
        double Delta = OurMathLib.Math.Delta;
        #region Logarithm tests
        [Test]
        public void Logarithm_PositiveNumber()
        {
            Assert.AreEqual(0, OurMathLib.Math.Logarithm(1), Delta);
            Assert.AreEqual(1, OurMathLib.Math.Logarithm(OurMathLib.Math.E), Delta);
        }

        [Test]
        public void Logarithm_Zero()
        {
            //is equal to -infinity, but our calculator will not deal with infinities
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Logarithm(0); });
        }

        [Test]
        public void Logarithm_NegativeNumber()
        {
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Logarithm(-1); });
        }
        #endregion
    }
}