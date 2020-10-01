using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void DoUnfashionableDatesGetATable()
        {
            //Arrange
            DateFashion fashion = new DateFashion();
            //Act
            int result = fashion.GetATable(0, 1);
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void IsBoringFashionEnoughForATable()
        {
            //Arrange
            DateFashion fashion = new DateFashion();
            //Act
            int result = fashion.GetATable(5, 5);
            //Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void DofashionableDatesGetATable()
        {
            //Arrange
            DateFashion fashion = new DateFashion();
            //Act
            int result = fashion.GetATable(12, 8);
            //Assert
            Assert.AreEqual(2, result);
        }
    }
}
