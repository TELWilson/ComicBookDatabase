using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void DoesAStringChocolateReturnChoThreeTimes()
        {
            //Arrange
            FrontTimes shortString = new FrontTimes();
            //Act
            string result = shortString.GenerateString("Chocolate", 3);
            //Assert
            Assert.AreEqual("ChoChoCho", result);
        }

        [TestMethod]
        public void DoesAStringAbcReturnAbcFiveTimes()
        {
            //Arrange
            FrontTimes shortString = new FrontTimes();
            //Act
            string result = shortString.GenerateString("Abc", 5);
            //Assert
            Assert.AreEqual("AbcAbcAbcAbcAbc", result);
        }

        [TestMethod]
        public void DoesAStringThreeReturnTwoTimes()
        {
            //Arrange
            FrontTimes shortString = new FrontTimes();
            //Act
            string result = shortString.GenerateString("3", 2);
            //Assert
            Assert.AreEqual("33", result);
        }
    }
}
