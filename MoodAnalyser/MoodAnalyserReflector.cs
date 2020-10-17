using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyser
{
    public class MoodAnalyserReflector
    {
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser.MoodAnalyserClass");
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterisedConstructor("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass", message);
                MethodInfo method = type.GetMethod(methodName);
                object mood = method.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException e)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.METHOD_NOT_FOUND, "No such method found");
            }
        }
    }
}
