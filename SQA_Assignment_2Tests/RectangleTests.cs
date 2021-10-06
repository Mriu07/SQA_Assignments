using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQA_Assignment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment_2.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleTest()
        {
            //Arrange & Act - Default Constructor
            Rectangle rectangle = new Rectangle();

            //Assert
            Assert.AreEqual(1, rectangle.GetRectangleLength());

        }

        [TestMethod()]
        public void RectangleTest1()
        {
            //Arrange & Act - Default Constructor
            Rectangle rectangle = new Rectangle(5, 5);

            //Assert
            Assert.AreEqual(5, rectangle.GetRectangleLength());

            Assert.AreEqual(5, rectangle.GetRectangleWidth());

        }

        [TestMethod()]
        public void GetRectangleLengthTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            rectangle.SetRectangleLength(3);

            //Assert
            Assert.AreEqual(3, rectangle.GetRectangleLength());

        }

        [TestMethod()]
        public void SetRectangleLengthTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            rectangle.SetRectangleWidth(5);

            //Assert
            Assert.AreEqual(5, rectangle.GetRectangleWidth());

        }

        
    }
}