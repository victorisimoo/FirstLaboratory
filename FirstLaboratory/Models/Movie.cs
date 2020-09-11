using System;

namespace FirstLaboratory.Models
{
    public class Movie {
        public string Director { get; set; }
        public double ImdbRating { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public int RottenTomatoesRating { get; set; }
        public string Title { get; set; }

        public static Comparison<Movie> CompareByTitle = delegate (Movie MovieOne, Movie MovieTwo) {
            return MovieOne.Title.CompareTo(MovieTwo.Title);
        };
    }
    
}
