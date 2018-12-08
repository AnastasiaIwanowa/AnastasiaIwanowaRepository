using NUnit.Framework;
using System;

namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClassTriangle
    {

        [Test]
        public void TestMethodTriangleArea()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(5, 9, 5);
            double p = (5 + 5 + 9) / 2; //полупериметр
            double S = triangle.getAreaTriangle();
            Assert.AreEqual(Math.Sqrt(p * (p - 5) * (p - 5) * (p - 9)), S);
        }

        [Test]
        //ошибка в этом методе, так как он неверно возвращает длину треугольника
        public void TestMethodTriangleLength()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(4, 9, 8);
            double L = triangle.getLengthTriangle();
            Assert.AreEqual(4 + 9 + 8, L);
        }
    }
}
