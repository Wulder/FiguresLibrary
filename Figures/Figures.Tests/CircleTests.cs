using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Figures.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_5_78()
        {
            double expected = Math.Round(78.5398163, 3);

            Circle c = new Circle(5);
            double actual = Math.Round(c.GetArea(), 3);

            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void GetPerimeter_67_420()
        {
            double expected = 420.973;

            Circle c = new Circle(67);
            double actual = Math.Round(c.GetPerimeter(),3);

            Assert.AreEqual(expected, actual);
        }
    }
}
