using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tests
{
    [TestClass]
    public class InheritanceTests
    {
        Rectangle rectangle = new Rectangle();
        private readonly double width = 1.5;
        private readonly double height = 2.5;
        

        [TestMethod]
        public void PerimeterTest()
        {
            var c = rectangle.Perimeter(width, height);
            Assert.AreEqual(8, c);

        }

        [TestMethod]
        public void AreaTest()
        {
            var c = rectangle.Area(width, height);
            Assert.AreEqual(3.75, c);

        }

    }
}

