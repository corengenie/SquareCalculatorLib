using System;
using NUnit.Framework;
using SquareCalculator;

namespace UnitTests
{
    public class TriangleTest
    {
        [Test]
        public void CreateNegativeSideTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(-1, 1, 1));
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(1, -1, 1));
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(1, 1, -1));
        }

        [Test]
        public void CreateZeroSideTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(0, 1, 1));
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(1, 0, 1));
            Assert.Catch<ArgumentOutOfRangeException>(() => _ = new Triangle(1, 1, 0));
        }

        [Test]
        public void CreateInValidTest()
        {
            Assert.Catch<InvalidFigureException>(() => _ = new Triangle(10, 1, 1));
        }

        [Test]
        public void CreateValidTest()
        {
            Assert.DoesNotThrow(() => _ = new Triangle(3, 4, 5));
        }

        [Test]
        public void GetSquareTest()
        {
            Assert.AreEqual(6d, Calculator.CalculateSquare(new Triangle(3, 4, 5)), 0.0000001);
        }

        [Test]
        public void IsRightTrueCaseTest()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRight);
        }

        [Test]
        public void IsRightFalseCaseTest()
        {
            Assert.IsFalse(new Triangle(4, 5, 7).IsRight);
        }
    }
}