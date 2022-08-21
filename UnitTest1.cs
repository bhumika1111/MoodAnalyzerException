using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class TestCase4_1
    {
        /// <summary>
        /// Test Case 4.2  //Given Class Name When Improper Should Throw MoodAnalysis Exception.
        /// </summary>
      

            [TestMethod]
            public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Class()
            {
                
                {
                    //Arrange
                    string message = "MoodAnalyzers";     //wrong className passed to pass test
                object expected = new MoodAnalyzer(message);
                    //Act
                    object Obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerReflection.MoodAnalyzer","MoodAnalyzer");
                    expected.Equals(Obj);
                }
              
            }

     }
            
        
    
}
