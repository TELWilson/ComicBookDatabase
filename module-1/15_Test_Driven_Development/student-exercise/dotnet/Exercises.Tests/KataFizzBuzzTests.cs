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
        public void DoesFizzBuzzReturnFizzForOne(int input, string expected)
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
