using System;
using NUnit.Framework;
using SquareCalculator;

namespace UnitTests
{
    public class CircleTest
    {
        [Test]
        public void CreateNegativeRadiusTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Circle(-1d));
        }

        [Test]
        public void CreateZeroRadiusTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Test]
        public void CreateValidTest()
        {
            Assert.DoesNotThrow(() => new Circle(4));
        }

        [Test]
        public void GetSquareTest()
        {
            Assert.AreEqual(50.265482457, Calculator.CalculateSquare(new Circle(4)), 0.0000001);
        }
    }
}