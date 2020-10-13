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
            MoodAnalyser ma = new MoodAnalyser();
            ma.CheckMood(message);
             
        }
    }

    class MoodAnalyser
    {
        public void CheckMood(string message)
        {
            string msg = message.ToLower();

            if(msg == "sad")
            {
                Console.WriteLine("Ohh, you're in a sad mood");
            }
            else if(msg == "happy")
            {
                Console.WriteLine("Wow, you're in a happy mood");
            }

            else
            {
                Console.WriteLine("Sorry, unable to identify your mood");
            }
        }
    }
}
