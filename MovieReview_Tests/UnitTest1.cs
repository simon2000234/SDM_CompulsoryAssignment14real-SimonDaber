using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MovieRatingLibrary;
using MovieRatingLibrary.Entities;

namespace MovieReview_Tests
{
    [TestClass]
    public class UnitTest1
    {
        public List<MovieReview> MemoryDB = new TestData().MovieReviews;

        [TestMethod]
        public void TestIfNoReviews()
        {
            IMovieRating mr = new MovieRating(MemoryDB);
            List<MovieReview> list = mr.AllReviewsFromReviewer(-1);
            Assert.AreEqual(0,list.Count);
        }

        [TestMethod]
        public void Test_AllReviewsFromReviewer()
        {
            var mr = new MovieRating(MemoryDB);

            int numberOfReviews = mr.AllReviewsFromReviewer(1).Count;
            
            Assert.AreEqual(5,numberOfReviews);
        }

        [TestMethod]
        public void Test_AverageRatingFromReviewer()
        {
            var mr = new MovieRating(MemoryDB);

            var actualAverage = mr.AverageRatingFromReviewer(2);

            double expectedAverage = (1 + 2 + 3 + 4 + 5) / 5;

            Assert.AreEqual(expectedAverage,actualAverage);
        }

        [TestMethod]
        public void Test_TimesReviewerHasGivenGrade()
        {
            var mr = new MovieRating(MemoryDB);

            var actual = mr.TimesReviewerHasGivenGrade(2, 4);

            var expected = 1;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_HowManyReviewsOfMovie()
        {
            var mr = new MovieRating(MemoryDB);

            var actual = mr.HowManyReviewsOfMovie(1);

            var expected = 4;

            Assert.AreEqual(expected,actual);


        }

        [TestMethod]
        public void Test_AverageRatingMovieReceived()
        {
            var mr = new MovieRating(MemoryDB);

            double actual = mr.AverageRatingMovieReceived(1);

            double expected = 13.0 / 4.0;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_TimesMovieReceivedGrade()
        {
            var mr = new MovieRating(MemoryDB);

            int actual = mr.TimesMovieReceivedGrade(1, 1);

            int expected = 1;

            Assert.AreEqual(expected,actual);
        }


        [TestMethod]
        public void Test_MovieWithMostTopRates()
        {
            var mr = new MovieRating(MemoryDB);

            int actual = mr.MovieWithMostTopRates();

            int expected = 5;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_ReviewerWithMostReviews()
        {
            var mr = new MovieRating(MemoryDB);

            int actual = mr.ReviewerWithMostReviews();

            int expected = 4;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_TopNofMovies()
        {
            var mr = new MovieRating(MemoryDB);

            var actual = mr.TopNofMovies(1);

            var expected = 5;

            Assert.AreEqual(expected,actual[0]);
        }

        [TestMethod]
        public void Test_MoviesReviewedByN()
        {
            var mr = new MovieRating(MemoryDB);
            var actual = mr.MoviesReviewedByN(1);

            Assert.IsTrue(actual[0].Grade > actual[1].Grade);
            Assert.IsTrue(actual[1].Grade > actual[2].Grade);
            Assert.IsTrue(actual[2].Grade > actual[3].Grade);
        }

        [TestMethod]
        public void Test_ReviewersThatReviewedMovie()
        {
            var mr = new MovieRating(MemoryDB);
            var actual = mr.ReviewersThatReviewedMovie(1);

            Assert.IsTrue(actual[0].Grade > actual[1].Grade);
            Assert.IsTrue(actual[1].Grade > actual[2].Grade);
            Assert.IsTrue(actual[2].Grade > actual[3].Grade);
        }

    }
}
