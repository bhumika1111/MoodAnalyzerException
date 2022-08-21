using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class TestCase4_1
    {
        /// <summary>
        /// Test Case 4.3  Given improper constructor name should throw constructor not found exception.
        /// </summary>


        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Constructor()
        {

            
                try
                {
                    //Arrange
                    string className = "MoodAnalyzer";
                    string constructorName = "SampleMoodAnalyzer";     //wrong constructorName passed to pass test
                    //Act
                    object resultObj = MoodAnalyzerFactory.CreateMoodAnalyse(className,constructorName);
                }
                catch (MoodAnalyzerCustomException e)
                {
                    //Assert
                    Assert.AreEqual("Constructor is not found", e.Message);
                }
            




        }



    }
}
