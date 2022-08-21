using System;
using System.Collections.Generic;
using System.Text;

namespace MoodExceptionTestCases
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
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
