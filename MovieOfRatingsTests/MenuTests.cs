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
            int name = 765;

            Assert.AreEqual(217, menu.FindNrReviewsByReviewer(name));
        }

        [TestMethod()]
        public void FindAveGradeByReviewerTest()
        {
            int name = 1;

            Assert.AreEqual(3, menu.FindAveGradeByReviewer(name));
        }

        [TestMethod()]
        public void FindNrGradesByReviewerTest()
        {
            int name = 561;
            int grade = 5;

            Assert.AreEqual(932, menu.FindNrGradesByReviewer(name, grade));
        }

        [TestMethod()]
        public void FindNrReviewsOfMovieTest()
        {
            int name = 1107678;

            Assert.AreEqual(17, menu.FindNrReviewsOfMovie(name));
        }

        [TestMethod()]
        public void FindAveGradeOfMovieTest()
        {
            int name = 59052;

            Assert.AreEqual(2, menu.FindAveGradeOfMovie(name));
        }

        [TestMethod()]
        public void FindNrGradesOfMovieTest()
        {
            int name = 2291422;
            int grade = 5;

            Assert.AreEqual(2, menu.FindNrGradesOfMovie(name, grade));
        }

    }
}