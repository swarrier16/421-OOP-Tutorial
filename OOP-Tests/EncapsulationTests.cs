using System;
using Encapsulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Tests
{
    [TestClass]
    public class EncapsulationTests
    {
        private Course c = new Course();

        [TestMethod]

        public void EncapsulationTest()
        {
           
            Assert.AreEqual(21, c.classSize);

        }

    }
}