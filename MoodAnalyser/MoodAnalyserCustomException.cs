using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException :Exception
    { 
            public enum ExceptionType
            {
                ENTERED_NULL, ENTERED_EMPTY_MOOD, CLASS_NOT_FOUND, METHOD_NOT_FOUND, FIELD_NOT_FOUND
            }

            ExceptionType type;

            public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }

        }
    }


