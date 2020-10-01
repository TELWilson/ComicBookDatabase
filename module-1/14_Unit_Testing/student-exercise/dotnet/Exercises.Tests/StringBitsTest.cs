using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void DoesStringReturnNewStringOfOddChars()
        {
            //Arrange
            StringBits oddChars = new StringBits();
            //Act
            string result = oddChars.GetBits("Hello");
            //Assert
            Assert.AreEqual("Hlo", result);
        }

        [TestMethod]
        public void DoesStringSquirrelPartyReturnNewStringOfOddChars()
        {
            //Arrange
            StringBits oddChars = new StringBits();
            //Act
            string result = oddChars.GetBits("SquirrelParty");
            //Assert
            Assert.AreEqual("SurePry", result);
        }

        [TestMethod]
        public void DoesStringWrigleyReturnNewStringOfOddChars()
        {
            //Arrange
            StringBits oddChars = new StringBits();
            //Act
            string result = oddChars.GetBits("Wrigley");
            //Assert
            Assert.AreEqual("Wily", result);
        }
    }
}
