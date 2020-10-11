using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DZ_9
{
    enum Genre
    {
        Adventure, Action, Comedy, Drama, Fantasy, Horror, Romance, Thriller
    }
    class Director
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public Director()
        {
            FirstName = "Empty";
            LastName = "Empty";
        }
        public Director(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"First name: {FirstName} Last name: {LastName}";
        }
    }
    class Movie
    {
        public string Title { set; get; }
        public Director Director { set; get; }
        public string Country { set; get; }
        public Genre Genre { set; get; }
        public DateTime Year { set; get; }
        public short Rating { set; get; }
        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"{Director}\n" +
                   $"Country: {Country}\n" +
                   $"Genre: {Genre}\n" +
                   $"{Year.ToShortDateString()}\n" +
                   $"Rating: {Rating}";
        }
    }
    class Cinema
    {
        public string Address { get; set; }
        private Movie[] movies;

        public Cinema()
        {
            Address = "Anonymous";
            movies = new Movie[]
            {
                new Movie()
                {
                    Title = "Spider-Man: Homecoming",
                    Director = new Director("Jon", "Watts"),
                    Country = "United States",
                    Genre = Genre.Action,
                    Year = new DateTime(2017, 7, 7),
                    Rating = 9
                },
                new Movie()
                {
                    Title = "Detective Pikachu",
                    Director = new Director("Rob", "Letterman"),
                    Country = "United States, Japan",
                    Genre = Genre.Fantasy,
                    Year = new DateTime(2019, 5, 10),
                    Rating = 9
                },
                new Movie()
                {
                    Title = "Teenage Mutant Ninja Turtles",
                    Director = new Director("Jonathan", "Liebesman"),
                    Country = "United States",
                    Genre = Genre.Action,
                    Year = new DateTime(2014, 8, 8),
                    Rating = 9
                },
                new Movie()
                {
                    Title = "Spider-Man: Into the Spider-Verse",
                    Director = new Director("Bob", "Persichetti"),
                    Country = "United States",
                    Genre = Genre.Adventure,
                    Year = new DateTime(2019, 12, 14),
                    Rating = 9
                },
                new Movie()
                {
                    Title = "Deadpool",
                    Director = new Director("Tim", "Miller"),
                    Country = "United States",
                    Genre = Genre.Comedy,
                    Year = new DateTime(2016, 2, 12),
                    Rating = 9
                }

            };
        }
        public Cinema(string address) : this()
        {
            Address = address;
        }
        public void Sort()
        {
            Array.Sort(movies);
        }

        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
