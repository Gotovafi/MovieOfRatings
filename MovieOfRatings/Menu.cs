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
            List<Review> x1 = Program.GetReviewsFromFile();
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
            List<Review> x1 = Program.GetReviewsFromFile();
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
            List<Review> x1 = Program.GetReviewsFromFile();
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
            List<Review> x1 = Program.GetReviewsFromFile();
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
            List<Review> x1 = Program.GetReviewsFromFile();
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
            List<Review> x1 = Program.GetReviewsFromFile();
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

        public List<int> FindIntOfMoveWithMostScore()
        {
            List<Review> x1 = Program.GetReviewsFromFile();
            List<int> movieIds = new List<int>();
            int highestYet = 0;
            int numberOfGrades = 0;

            for (int i = 0; i < 2649429; i++) 
            {
                numberOfGrades = 0;

                x1.ForEach(delegate (Review review)
                {
                    if (review.Movie == i)
                    {
                        if (review.Grade == 5)
                        {
                            numberOfGrades++;
                        }
                    }
                });

                if(highestYet < numberOfGrades)
                {
                    highestYet = numberOfGrades;
                    movieIds.Clear();
                    movieIds.Add(i);
                }
                else if (highestYet == numberOfGrades)
                {
                    highestYet = numberOfGrades;
                    movieIds.Add(i);
                }
            }

            return movieIds;
        }

        public List<int> FindIntOfReviewerWithMostReviews()
        {
            List<Review> x1 = Program.GetReviewsFromFile();
            List<int> reviewerIds = new List<int>();
            int highestYet = 0;
            int numberOfGrades = 0;

            for (int i = 0; i < 999; i++)
            {
                numberOfGrades = 0;

                x1.ForEach(delegate (Review review)
                {
                    if (review.Reviewer == i)
                    {
                        numberOfGrades++;
                    }
                });

                if (highestYet < numberOfGrades)
                {
                    highestYet = numberOfGrades;
                    reviewerIds.Clear();
                    reviewerIds.Add(i);
                }
                else if (highestYet == numberOfGrades)
                {
                    highestYet = numberOfGrades;
                    reviewerIds.Add(i);
                }
            }

            return reviewerIds;
        }

        public List<int> FindIntOfMovies(int name)
        {
            List<Review> x1 = Program.GetReviewsFromFile();
            List<int> movieIds = new List<int>();



            x1.ForEach(delegate (Review review)
            {
                if (review.Reviewer == name)
                {
                    movieIds.Add(review.Movie);
                }
            });


            return movieIds;
        }

        public List<int> FindIntOfReviewers(int name)
        {
            List<Review> x1 = Program.GetReviewsFromFile();
            List<int> reviewerIds = new List<int>();

            

            x1.ForEach(delegate (Review review)
            {
                if (review.Movie == name)
                {
                    reviewerIds.Add(review.Reviewer);
                }
            });


            return reviewerIds;
        }

    }
}
