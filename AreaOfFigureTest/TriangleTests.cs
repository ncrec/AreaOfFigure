using System;
using AreaOfFigure.Figures;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AreaOfFigureTests
{
    [TestFixture]
    internal class TriangleTests
    {
        [Test]
        public void TriangleCreatingTest()
        {
            Assert.That(() => new Triangle(1, 4, 5),
                Throws.TypeOf<ArgumentException>());
            Assert.That(() => new Triangle(-1, 4, 5),
                Throws.TypeOf<ArgumentException>());
            Assert.That(() => new Triangle(0, 0, 0),
                Throws.TypeOf<ArgumentException>());
            Assert.DoesNotThrow(() => new Triangle(3, 4, 5));
        }
        [Test]
        public void TriangleCalculatingTest()
        {
            var expected = new Triangle(3,4,5).GetArea();
            Assert.AreEqual(expected, 6);
        }
        [Test]
        public void IsRightTriangleTest()
        {
            var expected = new Triangle(4, 3, 5).IsRightTriangle();
            Assert.IsTrue(expected);
            expected = new Triangle(3, 4, 4).IsRightTriangle();
            Assert.IsFalse(expected);
        }
    }
}
 