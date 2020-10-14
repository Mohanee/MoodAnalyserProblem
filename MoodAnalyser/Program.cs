using System;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Mood Analyser Problem");
            Console.WriteLine("What is your mood??");
            string message = Console.ReadLine();
            MoodAnalyserClass ma = new MoodAnalyserClass();
            ma.CheckMood(message);
             
        }
    }

    public class MoodAnalyserClass
    {
        public string CheckMood(string message)
        {
            string msg = message.ToLower();

            if(msg == "i am in sad mood")
            {
                return ("SAD");
            }
            else 
            {
                return("HAPPY");
            }
        }
    }
}
