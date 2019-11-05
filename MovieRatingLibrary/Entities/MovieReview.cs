using System;

namespace MovieRatingLibrary.Entities
{
    public class MovieReview: IComparable<MovieReview>
    {
        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public int CompareTo(MovieReview other)
        {
            if (this.Grade > other.Grade)
            {
                return -1;
            }
            else if (this.Grade == other.Grade)
            {
                return this.Date.CompareTo(other.Date);

            }
            else
            {
                return 1;
            }
        }
    }
}