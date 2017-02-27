using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class Factorial
    {
        #region Factorial tests
        [Test]
        public void FactorialNonNegative()
        {
            Assert.That(OurMathLib.Math.Factorial(5) == 120);
            Assert.That(OurMathLib.Math.Factorial(2) == 2);
            Assert.That(OurMathLib.Math.Factorial(0) == 1);
        }

        [Test]
        public void FactorialNegative()
        {
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Factorial(-1); });
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Factorial(-5); });
            Assert.Throws<ArgumentException>(delegate { OurMathLib.Math.Factorial(-1024); });
        }

        [Test]
        public void FactorialLargeNumbers()
        {
            Assert.That(OurMathLib.Math.Factorial(10) == 3628800);
            Assert.That(OurMathLib.Math.Factorial(13) == 6227020800);
            Assert.That(OurMathLib.Math.Factorial(15) == 1307674368000);
        }
        #endregion
    }
}