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
    public class TriangleTests
    {
        [TestMethod()]
        public void IsRightTriangleTest()
        {
            Triangle right = new Triangle((3, 4, 5));

            Assert.IsTrue(right.IsRightTriangle);
        }

        [TestMethod()]
        public void IsRightTriangleSortTest()
        {
            Triangle right = new Triangle((4, 5, 3));

            Assert.IsTrue(right.IsRightTriangle);
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            Triangle right = new Triangle((4, 5, 3));

            Assert.AreEqual(6, right.GetArea);
        }

        [TestMethod()]
        public void NegativeValueTest()
        {


            Assert.ThrowsException<NegativeValueException>(
                () =>
                {
                    new Triangle((-1, 4, 5));
                }
                );
        }
    }
}