﻿using System;
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
            MoodAnalyserClass ma = new MoodAnalyserClass(message);
            ma.CheckMood();
             
        }
    }

    public class MoodAnalyserClass
    {
        public string message { get; set; }

        public MoodAnalyserClass(string message)
        {
            this.message = message.ToLower();
        }

        public MoodAnalyserClass()
        {
        }

        public string CheckMood()
        {
            string msg = this.message;

            try
            {
                if (msg == "i am in sad mood")
                {
                    return ("SAD");
                }
                else
                {
                    return ("HAPPY");
                }
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
