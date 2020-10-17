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

        [TestMethod]
        public void EmptyEntry_Returns_CustomeException_with_EmptyErrorMessage()
        {
            try
            {
                MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass("");
                string result = ma.CheckMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

        [TestMethod]
        public void NullEntry_Returns_CustomeException_with_NullErrorMessage()
        {
            try
            {
                MoodAnalyserClass ma = new MoodAnalyser.MoodAnalyserClass(null);
                string result = ma.CheckMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }

        [TestMethod]
        public void Given_MoodAnalyserClassName_Should_ReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyserClass();
            object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            expected.Equals(actual);
        }

        [TestMethod]
        public void Given_ImproperClassName_Should_Throw_MoodAnalysisException_CLASS_NOT_FOUND()
        {
            try
            {
                object expected = new MoodAnalyserClass();
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("abc", "pqrmethod");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }

        [TestMethod]
        public void Given_ImproperConstructorName_Should_Throw_MoodAnalysisException_NO_SUCH_METHOD()
        {
            try
            {
                object expected = new MoodAnalyserClass();
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("Mood", "MoodAnalyserClass");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such method found", e.Message);
            }
        }

        [TestMethod]
        public void Given_MoodAnalyserClassName_Should_ReturnMoodAnalyserObject_UsingParameters()
        {
            object expected = new MoodAnalyserClass("HAPPY");
            object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterisedConstructor("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass", "HAPPY");
            actual.Equals(expected);
        }

        [TestMethod]
        public void GivenImproperClassName_WhenAnalyse_UsingParameterisedConstructor_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyserClass();
                object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterisedConstructor("Mood", "MoodAnalyserClass", "HAPPY");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }

        [TestMethod]
        public void GivenImproperConstructorName_WhenAnalyse_UsingParameterisedConstructor_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyserClass();
                object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterisedConstructor("MoodAnalyser.MoodAnalyserClass", "Mood", "Happy");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }

        [TestMethod]
        public void GivenMoodAnalyserWithoutMessage_WhenAnalysed_UsingParameterizedConstructor_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyserClass();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterisedConstructor("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

    }
}
