using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProb;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
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
