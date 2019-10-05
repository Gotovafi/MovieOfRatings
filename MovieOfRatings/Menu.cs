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
            const string V = @"D:\Ratings\ratings.json";
            List<Review> x1 = Program.GetReviewsFromFile(V);
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

        public double FindAveGradeByReviewer(int name)
        {
            List<Review> x1 = new List<Review>();
            int numberOfGrade = 0;
            int totalGrade = 0;
            double aveGrade;

            x1.ForEach(delegate (Review review)
            {
                if (review.Reviewer == name)
                {
                    numberOfGrade++;
                    totalGrade = totalGrade + review.Grade;
                }
            });

            aveGrade = totalGrade / numberOfGrade;
            return aveGrade;
        }

        public int FindNrGradesByReviewer(int name, int grade)
        {
            List<Review> x1 = new List<Review>();
            int numberOfGrades = 0;

            x1.ForEach(delegate (Review review)
            {
                if (review.Reviewer == name)
                {
                    if (review.Grade == grade)
                    {
                        numberOfGrades++;
                    }
                }
            });

            return numberOfGrades;
        }

        public int FindNrReviewsOfMovie(int name)
        {
            List<Review> x1 = new List<Review>();
            int numberOfReviews = 0;

            x1.ForEach(delegate (Review review)
            {
                if (review.Movie == name)
                {
                    numberOfReviews++;
                }
            });

            return numberOfReviews;
        }

        public double FindAveGradeOfMovie(int name)
        {
            List<Review> x1 = new List<Review>();
            int numberOfGrade = 0;
            int totalGrade = 0;
            double aveGrade;

            x1.ForEach(delegate (Review review)
            {
                if (review.Movie == name)
                {
                    numberOfGrade++;
                    totalGrade = totalGrade + review.Grade;
                }
            });

            aveGrade = totalGrade / numberOfGrade;
            return aveGrade;
        }

        public int FindNrGradesOfMovie(int name, int grade)
        {
            List<Review> x1 = new List<Review>();
            int numberOfGrades = 0;

            x1.ForEach(delegate (Review review)
            {
                if (review.Movie == name)
                {
                    if (review.Grade == grade)
                    {
                        numberOfGrades++;
                    }
                }
            });
            return numberOfGrades;
        }


    }
}
