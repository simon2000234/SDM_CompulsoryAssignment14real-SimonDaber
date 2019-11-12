using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MovieRatingLibrary.Entities;

namespace MovieRatingLibrary
{
    public class MovieRating: IMovieRating
    {
        public List<MovieReview> AllMovieReviews { get; set; }

        public MovieRating()
        {
            var data = new TestData();
            AllMovieReviews = data.MovieReviews;
        }


        public MovieRating(List<MovieReview> reviewList)
        {
            AllMovieReviews = reviewList;
        }

        public List<MovieReview> AllReviewsFromReviewer(int reviewerId)
        {
            List<MovieReview> reviewList = new List<MovieReview>();

            foreach (var review in AllMovieReviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    reviewList.Add(review);
                }
            }

            return reviewList;
        }

        public double AverageRatingFromReviewer(int reviewerId)
        {
            int count = 0;
            double average = 0;

            foreach (var review in AllMovieReviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    average += review.Grade;
                    count++;
                }
            }

            average = average / count;

            return average;

        }

        public int TimesReviewerHasGivenGrade(int reviewerId, int grade)
        {
            int count = 0;

            foreach (var review in AllMovieReviews)
            {
                if (reviewerId == review.Reviewer && grade == review.Grade)
                {
                    count++;
                }
            }

            return count;
        }

        public int HowManyReviewsOfMovie(int movieId)
        {
            int count = 0;

            foreach (var review in AllMovieReviews)
            {
                if (movieId == review.Movie)
                {
                    count++;
                }
            }

            return count;
        }

        public double AverageRatingMovieReceived(int movieId)
        {
            int count = 0;
            double average = 0;

            foreach (var review in AllMovieReviews)
            {
                if (review.Movie == movieId)
                {
                    average += review.Grade;
                    count++;
                }
            }

            average = average / count;

            return average;
        }

        public int TimesMovieReceivedGrade(int movieId, int grade)
        {
            int count = 0;

            foreach (var review in AllMovieReviews)
            {
                if (movieId == review.Movie && grade == review.Grade)
                {
                    count++;
                }
            }

            return count;
        }

        public int MovieWithMostTopRates()
        {
            List<MovieReview> temp = new List<MovieReview>();
            temp.AddRange(AllMovieReviews);
            int curretnTopRate = 0;
            int count = 0;
            int currentTopCount = 0;
            int movie = 1;
            foreach (var reviews in AllMovieReviews)
            {
                if (reviews.Grade < 5)
                {
                    temp.Remove(reviews);
                }
            }

            Dictionary<int, int> candidates = new Dictionary<int, int>();
            for (int i = 0; i < temp.Count; i++)
            {
                if (!candidates.ContainsKey(temp[i].Movie))
                {
                    candidates[temp[i].Movie] = 1;
                }
                else
                {
                    candidates[temp[i].Movie]++;
                }
            }

            count = 0;
            movie = -1;
            foreach (KeyValuePair<int, int> kv in candidates)
            {
                if (kv.Value > count)
                {
                    count = kv.Value;
                    movie = kv.Key;
                }
            }

            return movie;


            /*for (int i = 0; i < AllMovieReviews.Count; i++)
            {
                foreach (var review in AllMovieReviews)
                {
                    if (review.Movie == movie && review.Grade == 5)
                    {
                        count++;
                    }
                }

                if (currentTopCount < count)
                {
                    currentTopCount = count;
                    curretnTopRate = movie;
                }

                movie++;
            }

            return curretnTopRate;*/
        }

        public int ReviewerWithMostReviews()
        {
            int topCount = 0;
            int count = 0;
            int topReviewer = -1;

            foreach (var reviewer in AllMovieReviews.Select(r => r.Reviewer).Distinct())
            {
                foreach (var review in AllMovieReviews)
                {
                    if (review.Reviewer == reviewer)
                    {
                        count++;
                    }
                }

                if (topCount < count)
                {
                    topCount = count;
                    topReviewer = reviewer;
                }

                count = 0;
            }

            return topReviewer;

        }

        public List<int> TopNofMovies(int numberOfMovies)
        {
            var temp = new List<int>();
            var localAllMovieReviews = AllMovieReviews.Select(m => m.Movie).Distinct().ToList();
            var movieAverage = -1.0;
            var topMovie = -1;
            var currentTop = -1.0;
            for (int i = 0; i < numberOfMovies; i++)
            {
                foreach (var movie in localAllMovieReviews)
                {
                    movieAverage = AverageRatingMovieReceived(movie);

                    if (currentTop < movieAverage)
                    {
                        currentTop = movieAverage;
                        topMovie = movie;
                    }
                }

                temp.Add(topMovie);
                currentTop = -1.0;
                localAllMovieReviews.Remove(topMovie);
            }
            



            return temp;
        }

        public List<MovieReview> MoviesReviewedByN(int reviewerId)
        {
            var temp = new List<MovieReview>();

            foreach (var review in AllMovieReviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    temp.Add(review);
                }
            }

            temp.Sort();

            return temp;
        }

        public List<MovieReview> ReviewersThatReviewedMovie(int movieId)
        {
            var temp = new List<MovieReview>();

            foreach (var review in AllMovieReviews)
            {
                if (review.Movie == movieId)
                {
                    temp.Add(review);
                }
            }

            temp.Sort();

            return temp;
        }
    }
}