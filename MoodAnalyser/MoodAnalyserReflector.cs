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


        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyserClass moodAnalyzer = new MoodAnalyserClass();

                Type type = typeof(MoodAnalyserClass);

                FieldInfo fieldInfo = type.GetField(fieldName);
                if (message == null)
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.ENTERED_NULL, "Mood should not be NULL");

                fieldInfo.SetValue(moodAnalyzer, message);

                return moodAnalyzer.message;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.FIELD_NOT_FOUND, "Field is not found");

            }
        }
    }
}
