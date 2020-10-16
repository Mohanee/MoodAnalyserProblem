using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalyserCustomException :Exception
    { 
            public enum ExceptionType
            {
                ENTERED_NULL, ENTERED_INVALID_MOOD
            }

            ExceptionType type;

            public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }

        }
    }


