using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysers
{
    public class MoodAnalysis
    {
        public string message;
        public MoodAnalysis(string message)
        {
            this.message = message;
            Console.WriteLine(message);
        }

        public string Moodss()
        {
            if(message.Contains("Happy"))
            {
                return "Happy";
            }
            else if (message.Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "Enter your current Mood";
            }
        }
    }
}
