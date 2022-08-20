using System;

namespace MoodAnalyzerRespond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::Welcome To Mood Analyzer Program:::::::");
            Console.WriteLine("***Please Enter Which Mood You Have E.g- Happy Or Sad***");
            string message = Console.ReadLine();
            // Create Instance Of A class
            MoodAnalyze check = new MoodAnalyze(message);

            //referance is stored in result
            string result = check.AnalyseMood(message);
            Console.WriteLine(result + "Mood");
        }

    }
    
}
