using System;
using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class StdDeviation
    {
        double Delta = OurMathLib.Math.Delta;

        #region Standard deviation testing
        [Test]
        public void Deviation_Test1()
        {
            int[] data = { 1, 2, 3, 5, 4, 6 };
            Assert.AreEqual(1.87083, OurMathLib.Math.StdDeviation(data), Delta);
        }

        [Test]
        public void Deviation_Test10()
        {
            int[] data = { 10, 20, 30, 25, 42, 56 };
            Assert.AreEqual(16.39207, OurMathLib.Math.StdDeviation(data), Delta);
        }

        [Test]
        public void Deviation_Test100()
        {
            int[] data = { 100, 200, 300, 250, 420, 560 };
            Assert.AreEqual(163.92071, OurMathLib.Math.StdDeviation(data), Delta);
        }
        #endregion
    }
}