using NUnit.Framework;

namespace Katas
{
    public class CustomMath
    {
        public static int multiply(int a, int b)
        {
            return a * b;
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            const int expected = 6;
            var actual = CustomMath.multiply(2, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
