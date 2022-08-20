using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerRefractor;

namespace MoodAnalyzerRefractorTest
{
    [TestClass]
    public class UnitTest1
    {
        //Here we check the Given condition " I am in sad mood should return sad".
        [TestMethod]
        public void GivenIAmInSadMoodShouldReturnSad()
        {
            //Arrange
            string message = "I am in sad mood ";
            string expected = "Sad";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyzeMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }



        //Here we check the Given condition " I am in Any mood should return Happy".
        [TestMethod]
        public void GivenIAmInAnyMoodShouldReturnHappy()
        {
            //Arrange
            string message = "I am in any mood ";
            string expected = "Happy";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyzeMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }

        //Here we check the Given condition " I am in Happy mood should return Happy".
        [TestMethod]
        public void GivenIAmInHappyMoodShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Happy mood ";
            string expected = "Happy";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyzeMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }
    }
}
