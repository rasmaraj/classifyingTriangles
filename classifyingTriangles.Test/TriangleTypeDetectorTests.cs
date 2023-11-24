using Microsoft.VisualStudio.TestTools.UnitTesting;
using classifyingTriangles.Component.Interaces;
using classifyingTriangles.Component.BLL;
using System;
using classifyingTriangles.Component;

namespace classifyingTriangles.Test
{
    [TestClass]
    public class TriangleTypeDetectorTests
    {
        [TestMethod]
        public void equilateralTriangleTest()
        {
           ITriangleType triangleDetector = new TriangleTypeDetector();
            string result = triangleDetector.GetTriangleType(5, 5, 5);
            Assert.AreEqual("Equilateral Triangle", result);
        }

        [TestMethod]
        public void isoscelesTriangleTest()
        {
            ITriangleType triangleDetector = new TriangleTypeDetector();
            string result = triangleDetector.GetTriangleType(5, 5, 8);
            Assert.AreEqual("Isosceles Triangle", result);
        }

        [TestMethod]
        public void scaleneTriangleTest()
        {
            ITriangleType triangleDetector = new TriangleTypeDetector();
            string result = triangleDetector.GetTriangleType(3, 4, 5);
            Assert.AreEqual("Scalene Triangle", result);
        }
    }
}
