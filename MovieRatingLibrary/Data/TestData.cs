using System;
using System.Collections.Generic;
using MovieRatingLibrary.Entities;

namespace MovieRatingLibrary
{
    public class TestData
    {
        public List<MovieReview> MovieReviews { get; set; }

        public TestData()
        {
            InitializeTestData();
        }

        //Initialize 20 MovieReview objects, 4 reviewers with reviews of 5 movies
        public void InitializeTestData()
        {
            List<MovieReview> temp = new List<MovieReview>();

            MovieReview review_1 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                Movie = 1,
                Reviewer = 1
            };
            temp.Add(review_1);

            MovieReview review_2 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                Movie = 2,
                Reviewer = 1
            };
            temp.Add(review_2);

            MovieReview review_3 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                Movie = 3,
                Reviewer = 1
            };
            temp.Add(review_3);

            MovieReview review_4 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                Movie = 4,
                Reviewer = 1
            };
            temp.Add(review_4);

            MovieReview review_5 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                Movie = 5,
                Reviewer = 1
            };
            temp.Add(review_5);

            MovieReview review_6 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                Movie = 1,
                Reviewer = 2
            };
            temp.Add(review_6);

            MovieReview review_7 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                Movie = 2,
                Reviewer = 2
            };
            temp.Add(review_7);

            MovieReview review_8 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                Movie = 3,
                Reviewer = 2
            };
            temp.Add(review_8);

            MovieReview review_9 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                Movie = 4,
                Reviewer = 2
            };
            temp.Add(review_9);

            MovieReview review_10 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                Movie = 5,
                Reviewer = 2
            };
            temp.Add(review_10);

            MovieReview review_11 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                Movie = 1,
                Reviewer = 3
            };
            temp.Add(review_11);

            MovieReview review_12 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                Movie = 2,
                Reviewer = 3
            };
            temp.Add(review_12);

            MovieReview review_13 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                Movie = 3,
                Reviewer = 3
            };
            temp.Add(review_13);

            MovieReview review_14 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                Movie = 4,
                Reviewer = 3
            };
            temp.Add(review_14);

            MovieReview review_15 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                Movie = 5,
                Reviewer = 3
            };
            temp.Add(review_15);

            MovieReview review_16 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                Movie = 1,
                Reviewer = 4
            };
            temp.Add(review_16);

            MovieReview review_17 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                Movie = 2,
                Reviewer = 4
            };
            temp.Add(review_17);

            MovieReview review_18 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                Movie = 3,
                Reviewer = 4
            };
            temp.Add(review_18);

            MovieReview review_19 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                Movie = 4,
                Reviewer = 4
            };
            temp.Add(review_19);

            MovieReview review_20 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                Movie = 5,
                Reviewer = 4
            };
            temp.Add(review_20);

            MovieReview review_21 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                Movie = 5,
                Reviewer = 4
            };
            temp.Add(review_21);

            MovieReviews = temp;
        }


    }
}