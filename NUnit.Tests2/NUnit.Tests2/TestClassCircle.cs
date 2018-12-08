using NUnit.Framework;
using System;

namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClassCircle
    {
        [Test]
        public void TestMethodCircleArea()
        {
            GeometricFigures.Circle circle = new GeometricFigures.Circle(15);
            double S = circle.getAreaCircle();
            Assert.AreEqual(Math.PI * 15 * 15, S);
        }

        [Test]
        public void TestMethodCircleLength()
        {
            GeometricFigures.Circle circle = new GeometricFigures.Circle(3);
            double L = circle.getLengthCircle();
            Assert.AreEqual(2 * Math.PI * 3, L);
        }
    }
}
