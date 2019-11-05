using System;
using System.Collections.Generic;
using MovieRatingLibrary.Entities;

namespace MovieRatingLibrary
{
    public interface IMovieRating
    {
        //1. On input N, what are the number of reviews from reviewer N?
        List<MovieReview> AllReviewsFromReviewer(int reviewerId);

        //2. On input N, what is the average rate that reviewer N had given?
        double AverageRatingFromReviewer(int reviewerId);

        //3. On input N and G, how many times has reviewer N given a movie grade G?
        int TimesReviewerHasGivenGrade(int reviewerId, int grade);

        //4. On input N, how many have reviewed movie N?
        int HowManyReviewsOfMovie(int movieId);

        //5. On input N, what is the average rate the movie N had received?
        double AverageRatingMovieReceived(int movieId);

        //6. On input N and G, how many times had movie N received grade G?
        int TimesMovieReceivedGrade(int movieId, int grade);

        //7. What is the id(s) of the movie(s) with the highest number of top rates (5)?
        int MovieWithMostTopRates();

        //8. What reviewer(s) had done most reviews?
        int ReviewerWithMostReviews();

        //9. On input N, what is top N of movies? The score of a movie is its average rate.
        List<int> TopNofMovies(int numberOfMovies);

        //10. On input N, what are the movies that reviewer N has reviewed? The list should
        //be sorted decreasing by rate first, and date secondly.
        List<MovieReview> MoviesReviewedByN(int reviewerId);

        //11. On input N, what are the reviewers that have reviewed movie N? The list
        //should be sorted decreasing by rate first, and date secondly.
        List<MovieReview> ReviewersThatReviewedMovie(int movieId);
    }
}