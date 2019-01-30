using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RectangleAssignment;

namespace RectangleTests
{
    [TestFixture]
     class RectangleTest
    {
        [Test]
        public void GetLength_Input3and0_Returns3()
        {
            //Arrange
            int len = 3;
            int wid = 0;
            int expectedResult = len;
            Rectangle testRect = new Rectangle(len,wid);

            //Act
            int actualResult = testRect.GetLength();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input2and3asInitialDimensionsAndSetLengthAs6_Returns6()
        {
            //Arrange
            int len = 2;
            int wid = 3;
            int testlength = 6;
            int expectedResult = testlength;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.SetLength(testlength);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input0and4_Returns4()
        {
            //arrange
            int len = 0;
            int wid = 4;
            int expectedResult = wid;
            Rectangle testRect = new Rectangle(len, wid);

            //act
            int actualResult = testRect.GetWidth();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input5and6asInitialDimensionsAndSetWidthAs3_Returns3()
        {
            //Arrange
            int len = 5;
            int wid = 6;
            int testwidth = 3;
            int expectedResult = testwidth;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.SetWidth(testwidth);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input2and3_Returns10()
        {
            //Arrange
            int len = 2;
            int wid = 3;
            int expectedResult = (2 * len) + (2 * wid);
            Rectangle testRect = new Rectangle(len,wid);

            //Act
            int actualResult = testRect.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input3and6_Returns18()
        {
            //Arrange
            int len = 3;
            int wid = 6;
            int expectedResult = len * wid ;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
