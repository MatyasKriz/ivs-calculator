using NUnit.Framework;
using OurMathLib;

namespace MathLibraryTesting
{
    [TestFixture]
    public class BasicOperations
    {
        double Delta = OurMathLib.Math.Delta;
        #region Simple Tests Testing Basic Operations
        [Test]
        public void Basic_Add()
        {
            Assert.AreEqual(2, OurMathLib.Math.Add(1, 1));
            Assert.AreEqual(250.75, OurMathLib.Math.Add(150, 100.75));
            Assert.AreEqual(101010, OurMathLib.Math.Add(100010, 1000));
        }

        [Test]
        public void Basic_Subtract()
        {
            Assert.AreEqual(0, OurMathLib.Math.Subtract(1, 1));
            Assert.AreEqual(50.5, OurMathLib.Math.Subtract(100, 49.5));
            Assert.AreEqual(1999999, OurMathLib.Math.Subtract(2000000, 1));
        }

        [Test]
        public void Basic_Multiply()
        {
            Assert.AreEqual(1, OurMathLib.Math.Multiply(1, 1));
            Assert.AreEqual(33.3, OurMathLib.Math.Multiply(11.1, 3));
            Assert.AreEqual(424242, OurMathLib.Math.Multiply(42, 10101));
        }

        [Test]
        public void Basic_Divide()
        {
            Assert.AreEqual(1, OurMathLib.Math.Divide(1, 1));
            Assert.AreEqual(0.5, OurMathLib.Math.Divide(50, 100));
            Assert.AreEqual(12345, OurMathLib.Math.Divide(12345, 1));
        }
        #endregion
    }
}