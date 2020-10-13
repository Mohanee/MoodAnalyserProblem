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
            MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass();
            string message = "I am in sad mood";

            string result= ma.CheckMood(message);

            Assert.AreEqual(result,"SAD");
        }
    }
}
