using NUnit.Framework;
namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClassSquare
    {

        [Test]
        public void TestMethodSquareArea()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(5);
            double S = square.getAreaSquare();
            Assert.AreEqual(5 * 5, S);
        }

        [Test]
        public void TestMethodSquareLength()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(1);
            double L = square.getLengthSquare();
            Assert.AreEqual(1*4, L);
        }

    }
}
