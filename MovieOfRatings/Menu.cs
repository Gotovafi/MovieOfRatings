using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOfRatings
{
    public class Menu
    {

        public int FindNrReviewsByReviewer(int name)
        {
            List<Review> x1 = new List<Review>();
            int numberOfReviews = 0;

            x1.ForEach(delegate (Review review)
            {
                if (review.Reviewer == name)
                {
                    numberOfReviews++;
                }
            });

            return numberOfReviews;
        }

        public double FindAveScoreByReviewer(int name)
        {
            List<Review> x1 = new List<Review>();
            int numberOfScores = 0;
            int totalScore = 0;
            double aveScore;

            x1.ForEach(delegate (Review review)
            {
                if (review.Reviewer == name)
                {
                    numberOfScores++;
                    totalScore = totalScore + review.Grade;
                }
            });

            aveScore = totalScore / numberOfScores;
            return aveScore;
        }
    }
}
