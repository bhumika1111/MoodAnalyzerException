using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerRespond
{
    class MoodAnalyze
    {
        private string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing happy Or sad.
        public string AnalyseMood(string message)
        {
            if (this.message.Contains("Sad"))
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
