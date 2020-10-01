using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void DoesHelloThereBecomeElloHere()
        {
            //Arrange
            NonStart joinedString = new NonStart();
            //Act
            string result = joinedString.GetPartialString("Hello", "There");
            //Assert
            Assert.AreEqual("ellohere", result);
        }

        [TestMethod]
        public void DoesShotlJavaBecomhotlava()
        {
            //Arrange
            NonStart joinedString = new NonStart();
            //Act
            string result = joinedString.GetPartialString("Shotl", "Java");
            //Assert
            Assert.AreEqual("hotlava", result);
        }

        [TestMethod]
        public void DoesCaolIllaBecomeaollla()
        {
            //Arrange
            NonStart joinedString = new NonStart();
            //Act
            string result = joinedString.GetPartialString("Caol", "Illa");
            //Assert
            Assert.AreEqual("aollla", result);
        }
    }
}
