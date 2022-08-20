using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerTestCase1
{
    public class MoodAnalyze
    {
        private string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        
        public string AnalyzeMood(string message)
        {
            if (this.message.Contains("sad"))
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
