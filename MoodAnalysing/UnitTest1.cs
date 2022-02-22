using MoodAnalysers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MoodAnalysing
{
    [TestClass]
    public class UnitTest1
    {
       /* [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalysis mood = new MoodAnalysis("Happy");
            string result = mood.Moodss();
            Assert.AreEqual("Happy", result);
        }
        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalysis mood = new MoodAnalysis("sad");
            string result = mood.Moodss();
            Assert.AreEqual("sad", result);
        }*/
        [TestMethod]
        public void EmptyMessage()
        {
            MoodAnalysis mood = new MoodAnalysis("");
            string result = mood.AnalyseMood();
            Assert.AreEqual("Message should not be Empty", result);
        }
        [TestMethod]
        public void NullMessage()
        {
            MoodAnalysis mood = new MoodAnalysis("null");
            string result = mood.AnalyseMood();
            Assert.AreEqual("Message should not be Null", result);
        }
    }
}