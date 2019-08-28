using System;
namespace Lab1
{
    public class Movie
    {
        private String Name { get; set; }
        private Rating Rating { get; set; }
        private Genre Genre { get; set; }

        public Movie(String name, Rating rating, Genre genre)
        {
            this.Name = name;
            this.Rating = rating;
            this.Genre = genre;
        }
}