using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void AreFirstAndLastIndexEqualLength3()
        {
            //Arrange
            SameFirstLast intArray = new SameFirstLast();
            int[] numbers = { 2, 3, 4 };
            //Act
            bool result = intArray.IsItTheSame(numbers);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AreFirstAndLastIndexEqualLength5()
        {
            //Arrange
            SameFirstLast intArray = new SameFirstLast();
            int[] numbers = { 2, 3, 4, 7, 2 };
            //Act
            bool result = intArray.IsItTheSame(numbers);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void AreFirstAndLastIndexEqualLength1()
        {
            //Arrange
            SameFirstLast intArray = new SameFirstLast();
            int[] numbers = { 3};
            //Act
            bool result = intArray.IsItTheSame(numbers);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
