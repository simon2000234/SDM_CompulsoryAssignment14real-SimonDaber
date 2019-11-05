using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRatingLibrary;
using MovieRatingLibrary.Entities;

namespace MovieReview_Tests
{
    [TestClass]
    public class PerformanceTests
    {
        public static List<MovieReview> JsonReaderList;

        [AssemblyInitialize]
        public static void InitializeList(TestContext context)
        {
            JsonReaderList = new JsonReader().Readthejson("C:/Users/Caspe/Desktop/ratings.json");
        }

        [TestMethod]
        public void TestIfNoReviews()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            IMovieRating mr = new MovieRating(JsonReaderList);
            List<MovieReview> list = mr.AllReviewsFromReviewer(-1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_AllReviewsFromReviewer()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int numberOfReviews = mr.AllReviewsFromReviewer(1).Count;
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_AverageRatingFromReviewer()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actualAverage = mr.AverageRatingFromReviewer(2);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_TimesReviewerHasGivenGrade()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actual = mr.TimesReviewerHasGivenGrade(2, 4);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_HowManyReviewsOfMovie()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actual = mr.HowManyReviewsOfMovie(1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);


        }

        [TestMethod]
        public void Test_AverageRatingMovieReceived()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double actual = mr.AverageRatingMovieReceived(1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_TimesMovieReceivedGrade()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int actual = mr.TimesMovieReceivedGrade(1, 1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }


        [TestMethod]
        public void Test_MovieWithMostTopRates()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int actual = mr.MovieWithMostTopRates();
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_ReviewerWithMostReviews()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int actual = mr.ReviewerWithMostReviews();
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_TopNofMovies()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actual = mr.TopNofMovies(1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_MoviesReviewedByN()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actual = mr.MoviesReviewedByN(1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }

        [TestMethod]
        public void Test_ReviewersThatReviewedMovie()
        {
            var mr = new MovieRating(JsonReaderList);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var actual = mr.ReviewersThatReviewedMovie(1);
            sw.Stop();
            double time = sw.ElapsedMilliseconds / 1000.0;
            Assert.IsTrue(time < 4.0);
        }
    }
}