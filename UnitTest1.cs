using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerTestCase;
namespace MoosAnalyzerTest
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
    }
}
