using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustumExceptionTestCase;

namespace CustomExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 3.1: Given Null Mood Should Throw MoodAnalysisException.
        /// Given-When-Then
        /// </summary>
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyzeMood(message);

            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood Should Not be null", e.Message);
            }
        }
    }
}








