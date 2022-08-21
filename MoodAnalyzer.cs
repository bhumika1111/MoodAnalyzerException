using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionInvalidMood
{
    public class MoodAnalyzer
    {


        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood(string message)
        {
            
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            
           

        }
    }
}
