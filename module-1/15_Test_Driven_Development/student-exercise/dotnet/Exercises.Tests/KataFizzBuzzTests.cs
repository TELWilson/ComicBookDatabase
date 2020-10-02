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
        public void DoesFizzBuzzReturnFizzForOne()
        {
            //Arrange
            KataFizzBuzz inputString = new KataFizzBuzz();
            //Act
            string result = inputString.FizzBuzz(1, "1");
            //Assert
            Assert.AreEqual("1", result);
        }
        
    }
}
