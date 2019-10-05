using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieOfRatings.Tests
{
    [TestClass()]
    public class MenuTests
    {
        Menu menu = new Menu();
        [TestMethod()]
        public void FindNrReviewsByReviewerTest()
        {
            int name = 1;

            Assert.AreEqual(547, menu.FindNrReviewsByReviewer(name));
        }

        [TestMethod()]
        public void FindAveGradeByReviewerTest()
        {
            int name = 1;
            
            Assert.AreEqual(547, menu.FindAveGradeByReviewer(name));
        }
    }
}