using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.2: Given ? I Am In Any Mood? Message Should Return Happy.
        /// </summary>
        [TestMethod]
        public void GivenIAmInAnyMoodShouldReturnHappy()
        {
            //Arrange
            string expexted = "Happy";
            string message = "I Am In Any Mood";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expexted, mood);
        }


        
    }
}
