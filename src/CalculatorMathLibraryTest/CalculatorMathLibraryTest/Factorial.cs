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
        public void Factorial_NonNegative()
        {
            Assert.That(OurMathLib.Math.Factorial(5) == 120);
            Assert.That(OurMathLib.Math.Factorial(2) == 2);
            Assert.That(OurMathLib.Math.Factorial(0) == 1);
        }

        //negative numbers can't even be used as the IDE complains that they are not ulong

        [Test]
        public void Factorial_LargeNumbers()
        {
            Assert.That(OurMathLib.Math.Factorial(10) == 3628800);
            Assert.That(OurMathLib.Math.Factorial(13) == 6227020800);
            Assert.That(OurMathLib.Math.Factorial(15) == 1307674368000);
        }
        #endregion
    }
}