using NUnit.Framework;

namespace MathLibraryTesting
{
    [TestFixture]
    public class BasicOperations
    {
        #region Simple Tests Testing Basic Operations
        [Test]
        public void Adding()
        {
            Assert.That(1 + 1 == 2);
            Assert.That(100 + 100 == 200);
            Assert.That(1000 + 1000 == 2000);
        }

        [Test]
        public void Subtracting()
        {
            Assert.That(1 - 1 == 0);
            Assert.That(100 - 50 == 50);
            Assert.That(1000 - 900 == 100);
        }

        [Test]
        public void Multiplying()
        {
            Assert.That(1 * 1 == 1);
            Assert.That(10 * 10 == 100);
            Assert.That(13 * 1000 == 13000);
        }

        [Test]
        public void Dividing()
        {
            Assert.That(1 / 1 == 1);
            Assert.That(100 / 1 == 100);
            Assert.That(2000 / 1000 == 2);
        }
        #endregion
    }
}