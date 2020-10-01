using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd13Test
    {
        [TestMethod]
        public void DoesItReturnTripleThree()
        {
            //Arrange
            MaxEnd3 max = new MaxEnd3();
            int[] input = { 1, 2, 3 };
            int[] expectation = { 3, 3, 3 };
            //Act
            int[] result = max.MakeArray(input);
            //Assert
            CollectionAssert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void DoesItReturnTripleEleven()
        {
            //Arrange
            MaxEnd3 max = new MaxEnd3();
            int[] input = { 11, 5, 9 };
            int[] expectation = { 11, 11, 11 };
            //Act
            int[] result = max.MakeArray(input);
            //Assert
            CollectionAssert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void DoesItReturnTriple5()
        {
            //Arrange
            MaxEnd3 max = new MaxEnd3();
            int[] input = { 5, 2, 5 };
            int[] expectation = { 5, 5, 5 };
            //Act
            int[] result = max.MakeArray(input);
            //Assert
            CollectionAssert.AreEqual(expectation, result);
        }
    }
}
