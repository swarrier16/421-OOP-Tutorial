using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        private polymorphism Poly = new polymorphism(); //private property for the test class called calculator
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;

        [TestMethod]
        
        public void AddIntegerTest()
        {
            var c = Poly.Sum(aInt, bInt);
            Assert.AreEqual(3, c);

        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            var c = Poly.Sum(aDouble, bDouble);
            Assert.AreEqual(4.0, c);

        }
    }
}

