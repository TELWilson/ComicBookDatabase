using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
     public class CigarPartyTest
    {
        [TestMethod]
        public void DoSquirrelsHaveSuccessfulWeekendParty()
        {
            //Arrange
            CigarParty party = new CigarParty();
            //Act

            bool result = party.HaveParty(100, true);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DoSquirrelsHaveSuccessfulWeekdayParty()
        {
            //Arrange
            CigarParty party = new CigarParty();
            //Act

            bool result = party.HaveParty(100, false);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AreSquirrelsSadAboutTenCigars()
        {
            //Arrange
            CigarParty party = new CigarParty();
            //Act

            bool result = party.HaveParty(10, true);
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
