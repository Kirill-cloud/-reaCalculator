using Microsoft.VisualStudio.TestTools.UnitTesting;
using АreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АreaCalculator.Tests
{
    [TestClass()]
    public class СircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            double r = 2;
            Circle circle = new(r);

            Assert.AreEqual(Math.PI * r * r, circle.GetArea);
        }
        [TestMethod()]
        public void NegativeValueTest()
        {
            double invalidRadius = -2;

            Assert.ThrowsException<NegativeValueException>(
                () => { new Circle(invalidRadius); }
                );
        }
    }
}