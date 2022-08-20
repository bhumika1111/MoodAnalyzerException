using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
   public class MoodAnalyze
    {
        private string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing happy and sad.
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
