using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieOfRatings.Tests
{
    [TestClass()]
    public class MenuTests
    {
        Menu menu = new Menu();
        [TestMethod()]
        public void FindAveScoreByReviewerTest()
        {
            int name = 564;
            
            Assert.AreEqual(2, menu.FindAveScoreByReviewer(name));
        }
    }
}