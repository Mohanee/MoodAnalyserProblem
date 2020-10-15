using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IAmSadMood_Returns_SAD_TC1()
        {

            string message = "I am in sad mood";
            MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass(message);
            string result= ma.CheckMood();

            Assert.AreEqual(result,"SAD");
        }

        [TestMethod]
        public void IAminAnyMood_Returns_HAPPY_TC2()
        {
            string message = "I am in any mood";
            MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass(message);
            string result = ma.CheckMood();
            Assert.AreEqual(result, "HAPPY");
        }

        [TestMethod]
        public void IamSadMood_Returns_SAD_usingCtor()
        {
            MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass("I am in sad mood");
            string result = ma.CheckMood();

            Assert.AreEqual(result, "SAD");
        }

        [TestMethod]
        public void IamAnyMood_Returns_HAPPY_usingCtor()
        {
            MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass("I am in any mood");
            string result = ma.CheckMood();

            Assert.AreEqual(result, "HAPPY");
        }
    }
}
