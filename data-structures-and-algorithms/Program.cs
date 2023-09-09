﻿namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main()
        {


            List<Movie> movies = new List<Movie>
{
new Movie
{
    Title = "The Lion King",
    Year = 1994,
    Genres = new List<string> { "Animation", "Adventure", "Family" }
}
,
new Movie
{
    Title = "Toy Story",
    Year = 1995,
    Genres = new List<string> { "Animation", "Adventure", "Comedy" }
},

new Movie
{
    Title = "The Lord of the Rings",
    Year = 2001,
    Genres = new List<string> { "Fantasy", "Adventure", "Action" }
},

new Movie
{
    Title = "Blade Runner",
    Year = 1982,
    Genres = new List<string> { "Sci-Fi", "Action" }
},



new Movie
{
    Title = "Saving Private Ryan",
    Year = 1998,
    Genres = new List<string> { "Drama", "War" }
},

new Movie
{
    Title = "Scream",
    Year = 1996,
    Genres = new List<string> { "Horror", "Mystery" }
}
,
new Movie
{
    Title = "The Departed",
    Year = 2006,
    Genres = new List<string> { "Crime", "Thriller", "Drama" }
},

new Movie
{
    Title = "The Incredibles",
    Year = 2004,
    Genres = new List<string> { "Animation", "Action" }
}

};
            List<Movie> sortedByYear = Sorting.SortByYear(new List<Movie>(movies));
            List<Movie> sortedByTitle = Sorting.SortByName(new List<Movie>(movies));

            Console.WriteLine("{0,-30} {1}", "Title", "Year");
            Console.WriteLine(new string('-', 36));

            foreach (var movie in sortedByYear)
            {
                Console.WriteLine("{0,-30} {1}", movie.Title, movie.Year);
            }


            Console.WriteLine("\nSorted by title:");
            foreach (var movie in sortedByTitle)
            {
                Console.WriteLine($"Title: {movie.Title}.");


            }




        }

        public class Sorting
        {
            public static List<Movie> SortByName(List<Movie> movies)
            {


                string[] skipWord = { "The", "An", "A" };

                for (int i = 0; i < movies.Count - 1; i++)
                {
                    for (int j = 0; j < movies.Count - i - 1; j++)
                    {
                        string firstOne = movies[j].Title;
                        string secondOne = movies[j + 1].Title;

                        foreach (string word in skipWord)
                        {
                            firstOne = firstOne.Replace($"{word} ", "");
                            secondOne = secondOne.Replace($"{word} ", "");
                        }

                        if (CompareTitles(firstOne, secondOne) > 0)
                        {
                            Movie temp = movies[j];
                            movies[j] = movies[j + 1];
                            movies[j + 1] = temp;
                        }
                    }
                }
                return movies;
            }

            public static int CompareTitles(string firstMovie, string secondMovie)
            {
                for (int i = 0; i < Math.Min(firstMovie.Length, secondMovie.Length); i++)
                {
                    if (firstMovie[i] < secondMovie[i])
                    {
                        return -1;
                    }
                    else if (firstMovie[i] > secondMovie[i])
                    {
                        return 1;
                    }
                }

                return 0;
            }
            public static List<Movie> SortByYear(List<Movie> movies)
            {
                for (int i = 0; i < movies.Count - 1; i++)
                {
                    for (int j = 0; j < movies.Count - i - 1; j++)
                    {
                        if (movies[j].Year > movies[j + 1].Year)
                        {
                            Movie temp = movies[j];
                            movies[j] = movies[j + 1];
                            movies[j + 1] = temp;
                        }
                    }
                }
                return movies;
            }


            public bool FirstPart(string str)
            {
                if (str == "The" || str == "A" || str == "An")
                    return true;
                else return false;
            }

        }
        public class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public List<string> Genres { get; set; }

        }
    }

}
