using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void HowManyBasInBaBaBlackSheep()
        {
            //Arrange
            WordCount marysLamb = new WordCount();
            string[] wool = { "Ba", "Ba", "Black", "Sheep" };
            //Act
            //string[] result = marysLamb.GetCount(Wool);
            Dictionary<string, int> result = marysLamb.GetCount(wool);
            //Assert
            Assert.AreEqual(2, result["Ba"]);
        }

        [TestMethod]
        public void HowManyEisInEiAyEiAyOh()
        {
            //Arrange
            WordCount farmSong = new WordCount();
            string[] words = { "Ei", "Ay", "Ei", "Ay", "Oh" };
            //Act
            //string[] result = marysLamb.GetCount(Wool);
            Dictionary<string, int> result = farmSong.GetCount(words);
            //Assert
            Assert.AreEqual(2, result["Ei"]);
        }

        [TestMethod]
        public void HowManywesInLittlePiggyWentHome()
        {
            //Arrange
            WordCount littlePiggy = new WordCount();
            string[] wentHome = { "we", "we", "we", "all", "the", "way", "home" };
            //Act
            //string[] result = marysLamb.GetCount(Wool);
            Dictionary<string, int> result = littlePiggy.GetCount(wentHome);
            //Assert
            Assert.AreEqual(3, result["we"]);
        }
    }
}
