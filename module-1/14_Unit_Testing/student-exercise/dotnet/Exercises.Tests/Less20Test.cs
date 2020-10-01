using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void IsNineteenOneLessThanTwenty()
        {
            //Arrange
            Less20 oneLess = new Less20();
            //Act
            bool result = oneLess.IsLessThanMultipleOf20(19);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsEighteenTwoLessThanTwenty()
        {
            //Arrange
            Less20 twoLess = new Less20();
            //Act
            bool result = twoLess.IsLessThanMultipleOf20(18);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsTwentLessThanMultipleOfTwenty()
        {
            //Arrange
            Less20 evenValue = new Less20();

            //Act
            bool result = evenValue.IsLessThanMultipleOf20(20);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
