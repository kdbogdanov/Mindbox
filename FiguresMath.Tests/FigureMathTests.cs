using FiguresMath.Figures;
using NUnit.Framework;
using System;

namespace FiguresMath.Tests
{
    public class FigureMathTests
    {
        [Test]
        public void ShouldCalculateTriangleSquare()
        {
            var figure = new Triangle(3.0, 4.0, 5.0);
            const double expectedValue = 6.0;

            var result = figure.Calculate();

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void ShouldCalculateCircleSquare()
        {
            var figure = new Circle(3.0);
            const double expectedValue = 28.274333882308138;

            var result = figure.Calculate();

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void ShouldCheckTriangleIsRight()
        {
            var figure = new Triangle(3.0, 4.0, 5.0);

            var result = figure.IsRight();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void ShouldThrowsExceptionForInvalidCircle()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(-1.0)).Message;

            Assert.AreEqual(ex, "Radius of the circle can't be <= 0.");
        }

        [Test]
        public void ShouldThrowsExceptionForInvalidTriangle()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(-1.0, 5.0, 4.0)).Message;

            Assert.AreEqual(ex, "There is no triangle with given sides.");
        }
    }
}