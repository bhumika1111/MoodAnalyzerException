using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionInvalidMood;
using System;

namespace MoodAnalayzerExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckInvalidCase()
        {
            try
            {
                //Arrange
                string message = "Null";

                //referance
                MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

                //Act 
                string result = moodAnalyze.AnalyzeMood(message);

             

            }

            catch (NullReferenceException e )
            {
                //Assert

                Assert.AreEqual("mood null" , e.Message);



            }
        }
    }
}
