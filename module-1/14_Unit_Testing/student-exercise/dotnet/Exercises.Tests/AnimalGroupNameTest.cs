using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void RhinoShouldBeCrash()
        {
            //Arrange
           AnimalGroupName animalGroup = new AnimalGroupName();

            //Act
            string animal = animalGroup.GetHerd("Rhino");
                
            
            //Assert
            Assert.AreEqual("Crash", animal);
        }

        [TestMethod]
        public void RHINOShouldBeCrash()
        {
            //Arrange
            AnimalGroupName animalGroup = new AnimalGroupName();

            //Act
            string animal = animalGroup.GetHerd("RHINO");


            //Assert
            Assert.AreEqual("Crash", animal);
        }

        [TestMethod]
        public void SquirrelShouldBeUnknown()
        {
            //Arrange
            AnimalGroupName animalGroup = new AnimalGroupName();

            //Act
            string animal = animalGroup.GetHerd("Squirrel");


            //Assert
            Assert.AreEqual("unknown", animal);
        }
    }
}
