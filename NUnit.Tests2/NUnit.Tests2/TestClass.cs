using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClass
    {
        //double PI = 3.1415;

        [Test]
        public void TestMethodCircleArea()
        {
            GeometricFigures.Circle circle = new GeometricFigures.Circle(3);
            double S = circle.getAreaCircle();
            Assert.AreEqual(Math.PI * 3*3, S);
        }

        [Test]
        public void TestMethodCircleLength()
        {
            GeometricFigures.Circle circle = new GeometricFigures.Circle(3);
            double L = circle.getLengthCircle();
            Assert.AreEqual(2*Math.PI*3, L);
        }

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

        [Test]
        public void TestMethodTriangleArea()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(5, 9, 5);
            double p = (5 + 5 + 9) / 2; //полупериметр
            double S = triangle.getAreaTriangle();
            Assert.AreEqual(Math.Sqrt(p*(p-5)*(p-5)*(p-9)), S);
        }

        [Test]
        public void TestMethodTriangleLength()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(4, 9, 8);
            double L = triangle.getLengthTriangle();
            Assert.AreEqual(4+9+8, L);
        }
    }
}
