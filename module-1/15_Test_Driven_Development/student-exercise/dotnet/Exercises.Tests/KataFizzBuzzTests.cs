using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(22, "22")]
        [DataRow(0, " ")]
        [DataRow(13, "Fizz")]//need to get this test working
        public void DoesFizzBuzzReturnCorrectString(int input, string expected)
        {
            //Arrange
            KataFizzBuzz inputString = new KataFizzBuzz();
            //Act
            string result = inputString.FizzBuzz(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
        
    }
}
