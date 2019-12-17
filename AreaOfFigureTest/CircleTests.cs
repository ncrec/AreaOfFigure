using System;
using AreaOfFigure.Figures;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AreaOfFigureTests
{
    [TestFixture]
    internal class CircleTests
    {
        [Test]
        public void CircleCreatingTest()
        {
            Assert.That(() => new Circle(0), 
                Throws.TypeOf<ArgumentException>());
            Assert.That(() => new Circle(-1),
                Throws.TypeOf<ArgumentException>());
            Assert.DoesNotThrow(() => new Circle( 5));
        }
        [Test]
        public void CircleCalculatingTest()
        {
            var expected = new Circle(5).GetArea();
            Assert.AreEqual(expected, 25*Math.PI);
        }
    }
}
