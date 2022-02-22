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

        public string  Moodss()
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
        public string AnalyseMood()
        {
            try
            {
                if (message==null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
                }
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (MoodAnalysisException obj)
            {
                return obj.Message;
            }
           // return null;
        }
    }
}
