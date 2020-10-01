using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void DoesArrayOfEvensContainOneOrThree()
        {
            //Arrange
            Lucky13 newArray = new Lucky13();
            int[] nums = { 0, 2, 4 };
            //Act
            bool result = newArray.GetLucky(nums);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DoesArrayOfOddsContainOneOrThree()
        {
            //Arrange
            Lucky13 newArray = new Lucky13();
            int[] nums = { 1,3,5 };
            //Act
            bool result = newArray.GetLucky(nums);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void DoesArrayOfZerosContainOneOrThree()
        {
            //Arrange
            Lucky13 newArray = new Lucky13();
            int[] nums = { 0, 0, 0 };
            //Act
            bool result = newArray.GetLucky(nums);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
